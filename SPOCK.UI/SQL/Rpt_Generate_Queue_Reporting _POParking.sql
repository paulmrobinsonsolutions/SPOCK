/* BEGIN INPUT PARAMS */
DECLARE @QueueName nvarchar(50) = '{0}';
DECLARE @FromDatetime datetime = '{1}';
DECLARE @ToDatetime datetime = '{2}';
/* END INPUT PARAMS */

DECLARE @UtcHourDiff INT =
    (SELECT TOP 1 StartTimeZoneOffset / 60 / 60
       FROM dbo.BPVSessionInfo si WITH (NOLOCK)
	  WHERE si.LastUpdated < @ToDatetime
      ORDER BY StartDatetime DESC)
;

WITH CTE AS
(
SELECT *
    , (SELECT TOP 1 d.tag
         FROM [dbo].[BPAWorkQueueItemTag] AS C WITH (NOLOCK)
               INNER JOIN [dbo].BPATag AS D WITH (NOLOCK)
                  ON C.tagid = D.id
        WHERE QueueItemIdent = dt.ident) AS ItemTag
  FROM (
        SELECT REPLACE(REPLACE(
                    CAST([Data] AS XML).value('(/collection/row/field/@value)[1]', 'nvarchar(max)'),
                         '\\natsvrhix003\USBS\Automation\PA_Prod\P2P\SAP Invoice Extraction\Downloaded Invoices BP\', ''), '.pdf', '') AS WorkFlowID
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[2]', 'nvarchar(max)') AS [PONumber]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[3]', 'nvarchar(max)') AS [VendorId]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[4]', 'nvarchar(max)') AS [Invoice Number]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[5]', 'nvarchar(max)') AS [InvoiceDate]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[6]', 'nvarchar(max)') AS [BaselineDT]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[7]', 'nvarchar(max)') AS [Total]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[8]', 'nvarchar(max)') AS [Name]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[9]', 'nvarchar(max)') AS [Street]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[10]', 'nvarchar(max)') AS [State]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[11]', 'nvarchar(max)') AS [City]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[12]', 'nvarchar(max)') AS [Zip]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[13]', 'nvarchar(max)') AS [Sales_Tax]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[14]', 'nvarchar(max)') AS [Freight]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[15]', 'nvarchar(max)') AS [POBox]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[16]', 'nvarchar(max)') AS [CoCd]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[17]', 'nvarchar(max)') AS [GR-IV]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[18]', 'nvarchar(max)') AS [Tx]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[19]', 'nvarchar(max)') AS [IncoT]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[20]', 'nvarchar(max)') AS [Interfaced Invoices Found?]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[21]', 'nvarchar(max)') AS [Invoice_Verifier]
             , CAST([Data] AS XML).value('(/collection/row/field/@value)[22]', 'nvarchar(max)') AS [Exception_Comments]
             , CASE WHEN B.Completed IS NOT NULL THEN 'Completed' ELSE B.status END AS [Result]
             , CASE WHEN B.exceptionreasonvarchar IS NULL THEN '' ELSE B.exceptionreasonvarchar END AS [Exception Reason]
             , B.attemptworktime
             , DATEADD(HOUR, @UtcHourDiff, B.finished) AS Finished
             , DATEADD(HOUR, @UtcHourDiff, B.loaded) AS Loaded
             , DATEADD(HOUR, @UtcHourDiff, B.Completed) AS Completed
             , B.ident
          FROM [dbo].[BPAWorkQueue] AS A WITH (NOLOCK)
                  INNER JOIN [dbo].[BPAWorkQueueItem] AS B WITH (NOLOCK)
                     ON A.id = B.queueid
         WHERE A.[Name] = @QueueName
           AND DATEADD(HOUR, @UtcHourDiff, B.Finished) BETWEEN @FromDatetime AND @ToDatetime
      ) dt
)

SELECT WorkFlowID
     , ISNULL(ItemTag, 'Exception: ' + [Exception Reason]) AS [Status]
     , PONumber
     , Loaded
     , Completed
     , '0.' + REPLACE(CONVERT(VARCHAR, DATEADD(ms, attemptworktime * 1000, 2), 114), ':000', '') AS AvgWorktime
     , CASE WHEN ISNULL([Exception Reason], '') = '' THEN 'Pass' ELSE 'Fail' END AS [Pass/Fail]
     , 'PO Invoice Parking' AS Stage
     , [Exception Reason]
     , [Invoice Number]
     , VendorId
     , InvoiceDate
     , BaselineDT
     , Total
     , Name
     , Street
     , State
     , City
     , Zip
     , Sales_Tax
     , Freight
     , POBox
     , CoCd
     , Invoice_Verifier
     , Exception_Comments
  FROM CTE
 ORDER BY WorkFlowID