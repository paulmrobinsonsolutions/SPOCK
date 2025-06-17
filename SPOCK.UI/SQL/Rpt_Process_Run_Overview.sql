/*=============================================
Create date: Long ago...
Description: Get BP work queue item data for only the AMO_CSS_RTCReport queue. The intent is to
             provide this queue item data to Customer per their request to pull into their database.

----- Change Log -------------------------------
Chg #	DATE		NAME     DESCRIPTION
------------------------------------------------
  01	11/25/2024	Paul R   Changed query where clause value "si.Loaded" to "si.Finished"
                     For more succinct details, see below comments w/in this query
					 with changes made on 11/25/2024.

------------------------------------------------


------------------------------------------------

SELECT *
  FROM RPT.VW_AMO_RTCReportData

=============================================*/
/* BEGIN INPUT VARIABLES */
DECLARE @ProcessName NVARCHAR(MAX) = '{0}';
DECLARE @FromDate DATETIME = '{1}';
DECLARE @ToDate DATETIME = '{2}';
/* END INPUT VARIABLES */

DECLARE @UtcHourDiff INT =
    (SELECT TOP 1 StartTimeZoneOffset / 60 / 60
       FROM dbo.BPVSessionInfo si WITH (NOLOCK)
	  WHERE si.LastUpdated < @ToDate
      ORDER BY StartDatetime DESC)
;

DECLARE @QueueId NVARCHAR(MAX) = 
    (SELECT TOP 1 q.Id
       FROM RPA_QueueToProcessLink qp WITH (NOLOCK)
               INNER JOIN BPAWorkQueue q WITH (NOLOCK)
		          ON qp.QueueName = q.[Name]
      WHERE qp.ProcessName = @ProcessName
	  ORDER BY qp.ProcessName)
;

WITH CTE AS
(
SELECT qi.SessionId
     , AVG(worktime) AVG_QWorktime
     , SUM(ISDATE(Completed)) AS IsFini
     , SUM(ISDATE(Exception)) AS IsExcep
     , COUNT(*) AS WorkedInSessionCnt
  FROM BPAWorkQueueItem qi
/* Change #: 01
   Change Date: 11/25/2024
   Changed By: Paul R
   Description: Replaced "qi.Loaded" (the date/time the queue item was loaded into the queue)
   with "qi.Finished" (the time all work for that queue item has ended/finished)
   This change was made so that this query would better align with standard reporting 
   practices which is based on a queue item's "finished" date/time which also reflects
   the time the queue item was marked... completed, business exception or system exception. */
 WHERE DATEADD(HOUR, @UtcHourDiff, qi.Finished)  BETWEEN @FromDate AND @ToDate
   AND qi.QueueId = @QueueId
 GROUP BY qi.SessionId
)

SELECT si.ProcessName
     , SessionNumber AS SessNum
     , sta.[Description] AS SessStatus
     , StarterResourceName AS ResourceName
     , (SELECT TOP 1 CAST(StartParamsXml AS XML).value('(/inputs/input/@value)[1]', 'nvarchar(max)')
          FROM BPVSessionInfo l WITH (NOLOCK)
         WHERE l.ProcessName = 'Login By network ID'
           AND l.RunningResourceID = si.RunningResourceId
           AND l.StartDatetime < si.StartDatetime
         ORDER BY StartDatetime DESC) AS LoggedInId
     , StarterUsername AS StartedBy
     , FORMAT(StartDatetime, 'yyyy-MM-dd hh:mm tt') AS Sess_StartTime
     , FORMAT(EndDatetime, 'yyyy-MM-dd hh:mm tt') AS Sess_EndTime
     , REPLACE(CONVERT(VARCHAR, DATEADD(ms, DATEDIFF(SECOND, StartDatetime, EndDatetime) * 1000, 2), 114),':000','') AS Sess_Worktime
     , ISNULL(CTE.IsFini, 0) AS Q_Completed
     , ISNULL(CTE.IsExcep, 0) AS Q_Exceptions
     , ISNULL(CTE.WorkedInSessionCnt, 0) AS Q_TotalItems
     , REPLACE(ISNULL(CONVERT(VARCHAR, DATEADD(ms, CTE.AVG_QWorktime * 1000, 2), 114), '00:00:00:000'),':000','') AS Q_AvgItemWorktime
  FROM BPVSessionInfo si WITH (NOLOCK)
          INNER JOIN dbo.BPAStatus sta WITH (NOLOCK)
             ON si.StatusId = sta.StatusId
           LEFT OUTER JOIN CTE
             ON si.SessionId = CTE.SessionId
 WHERE si.ProcessName = @ProcessName
   AND StartDatetime BETWEEN @FromDate AND @ToDate
 ORDER BY SessionNumber DESC