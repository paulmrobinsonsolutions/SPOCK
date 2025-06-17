/* BEGIN INPUT VARIABLES */
DECLARE @FromDatetime DATETIME = '{0}';
DECLARE @ToDatetime DATETIME = '{1}';
/* END INPUT VARIABLES */
;

SELECT si.ProcessName
     , si.SessionNumber
     , sta.[Description] AS SessStatus
     , si.RunningResourceName
     , (SELECT TOP 1 CAST(StartParamsXml AS XML).value('(/inputs/input/@value)[1]', 'nvarchar(max)')
          FROM BPVSessionInfo l WITH (NOLOCK)
         WHERE l.ProcessName = 'Login By network ID'
           AND l.RunningResourceID = si.RunningResourceId
           AND l.StartDatetime < si.StartDatetime
         ORDER BY StartDatetime DESC) AS LoggedInId
     , si.StartDatetime
     , si.EndDatetime
     , REPLACE(CONVERT(VARCHAR, DATEADD(ms, DATEDIFF(SECOND, si.StartDatetime, si.EndDatetime) * 1000, 2), 114),':000','') AS RunTime
     --, si.StatusId
  FROM BPVSessionInfo si WITH (NOLOCK)
          INNER JOIN dbo.BPAStatus sta WITH (NOLOCK)
             ON si.StatusId = sta.StatusId
 WHERE si.StartDatetime BETWEEN @FromDatetime AND @ToDatetime
   AND LEFT(si.ProcessName, 5) NOT IN ('Chang','Check','Login','Logou','Test_','Timer','Unloc','reboo')
;
