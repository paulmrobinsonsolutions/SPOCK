/* BEGIN INPUT VARIABLES */
DECLARE @InPriorHourStart INT = -{0}; -- Note the "-" to make it a negative
/* END INPUT VARIABLES */

-- Get the time zone offset to then calculate UTC hour difference
DECLARE @UtcHourDiff INT = --{0};
    (SELECT TOP 1 StartTimeZoneOffset / 60 / 60
       FROM dbo.BPASession si WITH (NOLOCK)
	  WHERE StartTimeZoneOffset < 0
      ORDER BY StartDatetime DESC)
;

DECLARE @ProcessHungMinuteThreshold INT = 20;

/* Since we may need to account for UTC time difference, set a defined variable to
   evaluate against table data instead of use of GETDATE() function directly */
DECLARE @CurrentDatetime DATETIME = DATEADD(HOUR, @UtcHourDiff, GETDATE());

/* Variable to limit how far back to query in hours AND must account for UTC to current time difference */
DECLARE @FromDatetime DATETIME = DATEADD(HOUR, @InPriorHourStart, @CurrentDatetime);

/* Variable to hold all process sessions which could have some problem */
DECLARE @SuspectTable TABLE
(
	SessionNumber INT,
	ErrorStateText NVARCHAR(MAX)
)

/* Get the latest process sessions within the user's time constraint */
DECLARE @SessionsWithinTimeConstraint TABLE
(
	SessionNumber INT,
	SessionStarttime DATETIME,
	SessionEndTime DATETIME,
	StatusId INT
)

--SELECT @FromDatetime

INSERT INTO @SessionsWithinTimeConstraint (SessionNumber, SessionStarttime, SessionEndTime, StatusId)
SELECT sess.SessionNumber
     , sess.StartDatetime
     , sess.EndDatetime
	 , sess.StatusId
  FROM dbo.BPASession sess WITH (NOLOCK)
  -- Reference EndDatetime to ensure we capture long running processes
 WHERE ISNULL(sess.EndDatetime, '12/31/2999') >= @FromDatetime
   -- If a process is still running after 2 days, there's a bigger issue
   AND sess.StartDatetime >= DATEADD(DAY, -2, @FromDatetime)
;

/* 1. Identify Terminated, Stopped and Stopping sessions */
INSERT INTO @SuspectTable (SessionNumber, ErrorStateText)
SELECT swtc.sessionnumber
     , 'Process ' + sta.[description] AS ProcessState
  FROM @SessionsWithinTimeConstraint swtc
		INNER JOIN dbo.BPAStatus sta WITH (NOLOCK)
		   ON swtc.statusid = sta.statusid
 WHERE swtc.statusid IN (2,3,7) -- Terminated, Stopped, Stopping
;

/* 2. Identify Running, Debugging or Stopping processes which may need intervention */
INSERT INTO @SuspectTable (SessionNumber, ErrorStateText)
SELECT SessionNumber
     , 'Process seems frozen' AS ProcessState
 FROM (
	SELECT sl.sessionnumber
		 , MAX(sl.Startdatetime) AS LastStageStarttime
	  FROM dbo.BPASessionLog_NonUnicode sl WITH (NOLOCK)
     WHERE sl.SessionNumber IN (SELECT SessionNumber
                                  FROM @SessionsWithinTimeConstraint swtc
							     WHERE swtc.statusid IN (0,1,7) -- Pending, Running, Stopping
								   AND swtc.SessionEndTime IS NULL)
	 GROUP BY sl.sessionnumber
	) dt
/* Compare minute difference of current time to last stage start time
   NOTE: Apply minus to flip negative number to positive to then compare >= threshold value */
WHERE -DATEDIFF(MINUTE, @CurrentDatetime, LastStageStarttime) >= @ProcessHungMinuteThreshold
;

/* 3. Identify process errors sending emails */
-- Due to process logging differences with logged references this would 
-- need various customization in order to identify email issues

/* 7. Identify SAP application problems
05/12/20 Paul R     Changed to subquery then added group by to only return one row per SAP launch failure
07/06/20 Paul R     Removed secondary check on result details since this was returning failure prior to all retries
*/
INSERT INTO @SuspectTable (SessionNumber, ErrorStateText)
SELECT swtc.SessionNumber
     , 'SAP Application failed to start' AS ErrText
  FROM @SessionsWithinTimeConstraint swtc
		INNER JOIN dbo.BPASessionLog_NonUnicode sl WITH (NOLOCK)
		    ON swtc.sessionnumber = sl.sessionnumber
  WHERE sl.StageName = 'SAP tried to restart and failed' -- Unique to PO and Non-PO invoice extractions
;

SELECT DISTINCT Error_Type
     , Error_Desc
     , Process_Name
     , Resource_Name
     , Sess_Num
     /* UTC to EST hour adjustment to the date field at that date/time it 
		happened, not the current date/time */
     , Session_Start
     , Session_End
     , Runtime
  FROM (
		SELECT 'Schedule failed to start' AS Error_Type
			 , ScheduleName AS Process_Name
			 --, NULL AS SystemName
			 , ScheduleLogId AS Sess_Num
			 , TerminationReason AS Error_Desc
			 , 'Schedule' AS Resource_Name
			 , DATEADD(HOUR, @UtcHourDiff, EntryTime) AS Session_Start
			 , NULL AS Session_End
			 , 0 AS Runtime
			 --, NULL AS AttributeXml
		  FROM (
				SELECT (SELECT DISTINCT [Name]
                  FROM dbo.BPASchedule s WITH (NOLOCK)
                 WHERE s.id = sl.scheduleid) AS ScheduleName
					 , sle.*
					 , ROW_NUMBER() OVER(PARTITION BY ScheduleLogId
											 ORDER BY EntryTime DESC) AS RowNum
				  FROM dbo.BPAScheduleLogEntry sle WITH (NOLOCK)
						INNER JOIN dbo.BPAScheduleLog sl WITH (NOLOCK)
							ON sle.schedulelogid = sl.id
				 WHERE DATEADD(HOUR, @UtcHourDiff, sle.entrytime) >= @FromDatetime
				  AND TaskId IS NOT NULL
				) dt
		  WHERE RowNum <= 1
		    AND TerminationReason IS NOT NULL
		UNION ALL
		SELECT st.ErrorStateText
		     , ProcessName
		     , si.SessionNumber
			 , sta.[description] AS StatusDesc
			 , si.RunningResourceName AS ResourceName
			 , si.StartDatetime
			 , si.EndDatetime
			 , DATEDIFF(SECOND, si.startdatetime, si.enddatetime) AS TotalRuntime
		  FROM dbo.BPVSessionInfo si WITH (NOLOCK)
				INNER JOIN dbo.BPAStatus sta WITH (NOLOCK)
				   ON si.statusid = sta.statusid
				INNER JOIN @SuspectTable st
				   ON si.sessionnumber = st.SessionNumber
	) dt
 ORDER BY Session_Start DESC
     , Process_Name