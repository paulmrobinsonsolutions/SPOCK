/*
Get session details of all actively running sessions with resource name, bot login id and stage last run time
*/
-- Get the time zone offset to then calculate UTC hour difference
DECLARE @UtcHourDiff INT =
    (SELECT TOP 1 StartTimeZoneOffset / 60 / 60
       FROM dbo.BPVSessionInfo si WITH (NOLOCK)
      ORDER BY StartDatetime DESC)
;

DECLARE @ActiveSessionDetails TABLE
(
    ProcessName NVARCHAR(MAX)
  , SessionNumber INT
  , SessionId NVARCHAR(MAX)
  , RunningResourceName NVARCHAR(MAX)
  , StarterUsername NVARCHAR(MAX)
  , LastStageStartTime DATETIME
  , LastStageName NVARCHAR(MAX)
  , LoginId NVARCHAR(10)
  , SessionStartTime DATETIME
)

INSERT INTO @ActiveSessionDetails
SELECT si.ProcessName
     --, ProcessId
     , si.SessionNumber
     , si.SessionId
     --, RunningResourceId
     , si.RunningResourceName
	 , si.StarterUsername
     , si.LastUpdated
     , si.LastStage
     , (SELECT TOP 1 REPLACE(REPLACE(RIGHT(LEFT(StartParamsXml, CHARINDEX('/>', StartParamsXml) - 3), 9), '"', ''),'=','')
          FROM BPVSessionInfo l WITH (NOLOCK)
         WHERE l.ProcessName = 'Login By network ID'
           AND l.RunningResourceID = si.RunningResourceId
           AND l.StartDatetime < si.StartDatetime
         ORDER BY StartDatetime DESC) AS LoggedInId
     , CONVERT(VARCHAR, si.StartDatetime, 22) AS SessionStartTime
  FROM dbo.BPVSessionInfo si WITH (NOLOCK)
       -- NOTE: Not all business processes are associated with a queue
          LEFT OUTER JOIN dbo.VW_RPA_QueueToProcessLink q2pr
            ON si.ProcessId = q2pr.ProcessId
WHERE RIGHT(RunningResourceName, 5) <> 'debug'  -- Exclude any test/debug runs
	AND si.enddatetime IS NULL
ORDER BY si.ProcessName
	, si.LastUpdated

/* SHOW DETAILS FOR ANY RUNNING SESSIONS */
SELECT DISTINCT *
  FROM (
SELECT sd.ProcessName
     , sd.SessionNumber AS SessNum
	 --, sd.SessionId
	 , sd.LoginId
	 , sd.RunningResourceName AS ResourceName
	 , sd.StarterUsername AS StartedBy
	 , FORMAT(sd.SessionStartTime, 'MM/dd/yy hh:mm:ss tt') AS SessStartTime
	 , FORMAT(sd.LastStageStartTime, 'MM/dd/yy hh:mm:ss tt') AS LastStageStartTime
	 , LastStageName
     -- Note that in the application this field is hidden since the "FrozenTime" field represents
     -- the hours:minutes:seconds in much cleaner way
	 , ISNULL(DATEDIFF(SECOND, sd.LastStageStartTime, DATEADD(HOUR, @UtcHourDiff, GETDATE())), 0) AS SecondsLag
     , CONVERT(VARCHAR, DATEADD(ms, FLOOR(0.0 + 
            ISNULL(DATEDIFF(SECOND, sd.LastStageStartTime, DATEADD(HOUR, @UtcHourDiff, GETDATE())), 0)
            ) * 1000, 2), 114) AS FrozenTime
  FROM @ActiveSessionDetails sd
    ) dt
 ORDER BY FrozenTime DESC
     , ProcessName
     , LastStageStartTime
	 , ResourceName