/* BEGIN INPUT VARIABLES */
DECLARE @InPriorHourStart INT = {0};
DECLARE @UtcHourDiff INT = {1};
/* END INPUT VARIABLES */

/* Variable to limit how far back to query in hours AND must account for UTC to current time difference */
DECLARE @FromDatetime DATETIME = DATEADD(HOUR, -@InPriorHourStart, GETDATE());

SELECT DISTINCT *
  FROM (
   SELECT 'DPA Email Attachment Did Not Run' AS Error_Type
        , 'Application: Did not run' AS Error_Desc
        , 'DPA Email Extraction' AS Process_Name
        , 'Application' AS Resource_Name
        , -1 AS Sess_Num
        , (SELECT MAX([TimeStamp])
			FROM Application_Logs WITH (NOLOCK)) AS Session_Start
        , NULL AS Session_End
        , 'Application' AS Resource_Status
        , 0 AS Runtime
    /* 1. Process only runs be between 6 am and 6 pm
       2. No rows are returned within the last hour */
    WHERE DATEPART(HOUR, GETDATE()) BETWEEN 6 AND 18
      AND (SELECT COUNT(*)
             FROM Application_Logs WITH (NOLOCK)
            WHERE ProcessName = 'EmailAttachmentsExtraction'
              AND [Timestamp] > DATEADD(HOUR, -1, GETDATE())) = 0
    UNION ALL
   SELECT 'DPA Email Attachment Error' AS ErrorStateText
        , ErrorMessage AS Error_Desc
        , ProcessName
        , 'Application' AS ResourceName
        , COUNT(*) AS SessionNumber
        , MIN([TimeStamp]) AS Session_Start
        , MAX([Timestamp]) AS Session_End
        , 'Application' AS Resource_Status
        , DATEDIFF(SECOND, MIN([Timestamp]), MAX([Timestamp])) AS Runtime
	/* Select a rows with an error message within the last hour */
     FROM Application_Logs WITH (NOLOCK)
    WHERE ProcessName = 'EmailAttachmentsExtraction'
      AND LEN(ISNULL(ErrorMessage, '')) > 0
      AND [Timestamp] > DATEADD(HOUR, -1, GETDATE())
    GROUP BY ProcessName
        , ErrorMessage
    UNION ALL
    /* Get general application errors. Since each run can log multiple errors
       while retrieving emails then roll this up based on the error message. */
    SELECT 'General Application Error' AS ErrorStateText
        , ErrorMessage AS Error_Desc
        , ProcessName
        , 'Application' AS ResourceName
        , COUNT(*) AS SessionNumber
        , MAX([TimeStamp]) AS Session_Start
        , NULL AS Session_End
        , 'Application' AS Resource_Status
        , 0 AS Runtime
     FROM Application_Logs WITH (NOLOCK)
    WHERE ProcessName NOT IN ('EmailAttachmentsExtraction', 'SAMuel')
      AND LEN(ISNULL(ErrorMessage, '')) > 0
      AND [Timestamp] >= @FromDatetime
    GROUP BY ProcessName
        , ErrorMessage
    ) dt