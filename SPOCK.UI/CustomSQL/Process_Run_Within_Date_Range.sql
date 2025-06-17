/* BEGIN INPUT VARIABLES */
DECLARE @FromDate DATETIME = '{1}';
DECLARE @ToDate DATETIME = '{2}';
/* END INPUT VARIABLES */

SELECT si.ProcessName
     , si.RunningResourceName
     , (SELECT TOP 1 REPLACE(REPLACE(RIGHT(LEFT(StartParamsXml, CHARINDEX('/>', StartParamsXml) - 3), 9), '"', ''),'=','')
          FROM BPVSessionInfo l WITH (NOLOCK)
         WHERE l.ProcessName = 'Login By network ID'
           AND l.RunningResourceID = si.RunningResourceId
           AND l.StartDatetime < si.StartDatetime
         ORDER BY StartDatetime DESC) AS LoggedInId
     , FORMAT(si.StartDatetime, 'yyyy-MM-dd hh:mm tt') AS StartTime
     , FORMAT(si.EndDatetime, 'yyyy-MM-dd hh:mm tt') AS EndTime
     , si.SessionNumber
     , DATEDIFF(MINUTE, si.StartDatetime, si.EndDatetime) AS MinuteRunTime
     --, si.StatusId
     , sta.[Description] AS SessStatus
  FROM BPVSessionInfo si WITH (NOLOCK)
		INNER JOIN dbo.BPAStatus sta WITH (NOLOCK)
			ON si.StatusId = sta.StatusId
 WHERE si.StartDatetime BETWEEN @FromDate AND @ToDate
   AND LEFT(si.ProcessName, 5) NOT IN ('Chang','Check','Login','Logou','Test_','Timer','Unloc','reboo')
