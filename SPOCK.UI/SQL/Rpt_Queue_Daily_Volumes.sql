--USE BP_RPA_Prod
--GO
/* BEGIN INPUT PARAMS */
DECLARE @QueueName NVARCHAR(50) = '{0}'
DECLARE @FromDate DATE = '{1}'
DECLARE @ToDate DATE = '{2}'
/* END INPUT PARAMS */

DECLARE @UtcHourDiff INT = --{0};
    (SELECT TOP 1 StartTimeZoneOffset / 60 / 60
       FROM dbo.BPVSessionInfo si WITH (NOLOCK)
      ORDER BY StartDatetime DESC)
;

SELECT LoadedDate AS DateRef
     , SUM(CmplCnt) AS Completed
     , SUM(BizExcCnt) AS BizExceptions
     , SUM(SysExcCnt) AS SysExceptions
     , COUNT(*) AS TotalCount
 FROM (
       SELECT CONVERT(DATE, DATEADD(HOUR, @UtcHourDiff, Loaded)) AS LoadedDate
            , CONVERT(DATE, DATEADD(HOUR, @UtcHourDiff, Completed)) AS CompletedDate
            , CONVERT(DATE, DATEADD(HOUR, @UtcHourDiff, Exception)) AS ExceptionDate
            , qi.[status]
            , qi.ExceptionReasonVarchar
            , CASE WHEN Completed IS NOT NULL THEN 1 ELSE 0 END AS CmplCnt
            , CASE WHEN Exception IS NOT NULL AND [Status] = 'Business Exception' THEN 1 ELSE 0 END AS BizExcCnt
            , CASE WHEN Exception IS NOT NULL AND [Status] = 'System Exception' THEN 1 ELSE 0 END AS SysExcCnt
         FROM [dbo].[BPAWorkQueue] AS q WITH (NOLOCK)
               INNER JOIN [dbo].[BPAWorkQueueItem] AS qi WITH (NOLOCK)
                  ON q.id = qi.queueid
        WHERE q.[name] = @queueName
          AND CONVERT(DATE, DATEADD(HOUR, @UtcHourDiff, Finished)) BETWEEN @FromDate AND @ToDate
          AND qi.Finished IS NOT NULL
     ) dt
 GROUP BY LoadedDate
 ORDER BY LoadedDate DESC