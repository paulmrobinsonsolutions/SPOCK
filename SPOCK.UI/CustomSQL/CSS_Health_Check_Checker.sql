/* BEGIN INPUT VARIABLES */
DECLARE @FromDate DATETIME = '{0}';
DECLARE @ToDate DATETIME = '{1}';
/* END INPUT VARIABLES */

SELECT si.ProcessName
     , si.SessionNumber
	 , StarterUsername AS StartedBy
	 , sta.[Description] AS StatusDesc
	 , RunningResourceName AS ResourceName
     , (SELECT TOP 1 CAST(StartParamsXml AS XML).value('(/inputs/input/@value)[1]', 'nvarchar(max)')
         FROM BPVSessionInfo l WITH (NOLOCK)
        WHERE l.ProcessName = 'Login By network ID'
          AND l.RunningResourceID = si.RunningResourceId
          AND l.StartDatetime < si.StartDatetime
        ORDER BY StartDatetime DESC) AS LoggedInId
	 , FORMAT(si.StartDatetime, 'yyyy-MM-dd hh:mm tt') AS StartTime
	 , FORMAT(si.EndDatetime, 'yyyy-MM-dd hh:mm tt') AS EndTime
	 , sl.Result
  FROM BPVSessionInfo si WITH (NOLOCK)
          INNER JOIN BPAStatus sta WITH (NOLOCK)
		     ON si.StatusId = sta.StatusId
          INNER JOIN BPASessionLog_NonUnicode sl WITH (NOLOCK)
		     ON si.SessionNumber = sl.SessionNumber
			AND sl.StageName = 'Current Version Found?'
 WHERE si.[ProcessName] = 'CSS_HealthCheck'
   AND si.StartDatetime BETWEEN @FromDate AND @ToDate
 ORDER BY ISNULL(si.EndDatetime, si.StartDatetime)
     , si.RunningResourceName
;
