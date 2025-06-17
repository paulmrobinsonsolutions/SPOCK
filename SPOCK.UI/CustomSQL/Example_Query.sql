DECLARE @QueueName NVARCHAR(MAX) = '{0}';
DECLARE @FromDatetime DATETIME = '{1}';
DECLARE @ToDatetime DATETIME = '{2}';

SELECT TOP 20 q.[Name] AS QueueName
     , qi.KeyValue
     , qi.[Status]
     , qi.Loaded
     , qi.LastUpdated
     , qi.Exception
     , qi.ExceptionReason
  FROM BPAWorkQueue q WITH (NOLOCK)
         INNER JOIN BPAWorkQueueItem qi WITH (NOLOCK)
            ON q.Id = qi.QueueId
 WHERE q.[Name] = @QueueName
   AND qi.Finished BETWEEN @FromDatetime AND @ToDatetime
 ORDER BY NEWID()