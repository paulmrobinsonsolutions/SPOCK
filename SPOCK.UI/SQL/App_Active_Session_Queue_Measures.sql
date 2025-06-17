/*
Get live session queue details with counts of number of active resources, remaining items, completed items, total items and
average worktime of items by queue to then calculate estimated completion times because knowing is half the battle.
*/
IF OBJECT_ID('tempdb..#QueueAverages') IS NOT NULL
      DROP TABLE #QueueAverages;

/* The underlying VW_ view needs to be updated but requires SNOW request
   so in the meantime we'll go with this ugly join... 
   
** VW_RPA_QueueToProcessLink view NEEDS to be updated ItemToItemProcessTimeSeconds field */
SELECT vqpl.QueueId
     , vqpl.QueueName
	 , qpl.ItemToItemProcessTimeSeconds AS AvgSeconds
INTO #QueueAverages
  FROM RPA_QueueToProcessLink qpl WITH (NOLOCK)
          INNER JOIN VW_RPA_QueueToProcessLink vqpl
		    ON qpl.QueueName = vqpl.QueueName
;

IF OBJECT_ID('tempdb..#CurrRunningSessions') IS NOT NULL
      DROP TABLE #CurrRunningSessions;

SELECT si.ProcessId
     , si.SessionNumber
	 , si.SessionId
	 , si.RunningResourceName
	 , ISNULL(CONVERT(NVARCHAR(MAX), si.QueueId), l.QueueId) AS QueueId
 INTO #CurrRunningSessions
 FROM BPVSessionInfo si WITH (NOLOCK)
       INNER JOIN dbo.VW_RPA_QueueToProcessLink l WITH (NOLOCK)
	      ON si.ProcessId = l.ProcessId
WHERE RIGHT(si.RunningResourceName, 5) <> 'debug'  -- Exclude any test/debug runs
  AND si.StatusId = 1
  AND ISDATE(si.enddatetime) = 0
;

IF OBJECT_ID('tempdb..#QueueItemDetail') IS NOT NULL
      DROP TABLE #QueueItemDetail;

/* Insert queue data for running processes */
SELECT QueueId
     , SUM(CASE WHEN ISDATE(Finished) = 0 THEN 1 ELSE 0 END) AS PendingCount
     , SUM(CASE WHEN ISNULL([Status], '') IN ('System Exception','Internal') THEN 1 ELSE 0 END) AS ExceptionCount
     , SUM(CASE WHEN [State] > 2 THEN 1 ELSE 0 END) AS CompletedCount
	 , MAX(LastUpdated) AS LastUpdated
	 , COUNT(DISTINCT SessionId) AS ResourceCount
  INTO #QueueItemDetail
  FROM (
       SELECT qi.QueueId
	        , qi.[Status]
			, qi.[State]
			, qi.Finished
			, qi.LastUpdated
			, crs.SessionId
         FROM BPVWorkQueueItem qi WITH (NOLOCK)
                 INNER JOIN #CurrRunningSessions crs
                    ON qi.QueueId = crs.QueueId
                   /* Get only running session queue items, you do not want everything! */
                 AND qi.SessionId = crs.SessionId
	    WHERE qi.Loaded >= CONVERT(DATE, GETDATE()-2)
	    UNION ALL
       /* Insert queue data for remaining queue items to non-running processes */
       SELECT qi.QueueId
	        , qi.[Status]
			, qi.[State]
			, qi.Finished
			, qi.LastUpdated
			, crs.SessionId
         FROM BPVWorkQueueItem qi WITH (NOLOCK)
                 LEFT OUTER JOIN #CurrRunningSessions crs
                   ON qi.QueueId = crs.QueueId
                  /* Get only running session queue items, you do not want everything! */
                  AND qi.SessionId = crs.SessionId
        WHERE ISDATE(qi.Finished) = 0
          AND crs.SessionId IS NULL
		  /* Dude did you know we have pending items from months and monthas ago????? */
          AND qi.Loaded >= CONVERT(DATE, GETDATE()-90)
	  ) dt
 GROUP BY QueueId
;

DECLARE @UtcHourDiff INT =
    (SELECT TOP 1 StartTimeZoneOffset / 60 / 60
       FROM dbo.BPVSessionInfo si WITH (NOLOCK)
	  WHERE StartTimeZoneOffset < 0
      ORDER BY StartDatetime DESC)
;

SELECT ISNULL(qa.QueueName, q.[Name] + ' (Update link table: '+ CONVERT(NVARCHAR(MAX), qid.QueueId) +')') AS QueueName
     , ISNULL(qid.ResourceCount, 0) AS Resources
     , qid.PendingCount AS Remaining
     , ISNULL(qid.ExceptionCount, 0) AS SysExceptions
     , ISNULL(qid.CompletedCount, 0) AS Cmpl
     , ISNULL(qid.ExceptionCount, 0) + ISNULL(qid.CompletedCount, 0) AS TotalProcessed
	 , FORMAT(DATEADD(HOUR, @UtcHourDiff, qid.LastUpdated), 'yyyy-MM-dd hh:mm tt')  AS LastUpdated
     --, qa.AvgSeconds
     , REPLACE(CONVERT(VARCHAR, DATEADD(ms, qa.AvgSeconds * 1000, 2), 114),':000','') AS AvgWorktime
     , REPLACE(CONVERT(VARCHAR, DATEADD(ms, qa.AvgSeconds * qid.PendingCount * 1000, 2), 114),':000','') AS EstTotalTimeRem
     , CASE WHEN qid.ResourceCount = 0 
            THEN NULL
	        ELSE FORMAT(DATEADD(HOUR, @UtcHourDiff, 
	                  DATEADD(SECOND,ROUND((qid.PendingCount * qa.AvgSeconds) / ISNULL(qid.ResourceCount, 1),0), GETDATE()))
	                  , 'yyyy-MM-dd hh:mm tt')
       END AS EstEndTime
  FROM #QueueItemDetail qid
          LEFT OUTER JOIN #QueueAverages qa
		    ON qid.QueueId = qa.QueueId
         INNER JOIN BPAWorkQueue q WITH (NOLOCK)
		    ON qid.QueueId = q.Id
 ORDER BY qid.ResourceCount
     , qa.QueueName
;