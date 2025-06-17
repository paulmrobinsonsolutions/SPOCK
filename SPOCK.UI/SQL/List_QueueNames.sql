SELECT QueueName
     , REPLACE(QueueDisplayName, '_', ' ') AS DisplayName
  FROM (
       SELECT [Name] AS QueueName
           , CASE WHEN [Name] = 'Password_Change'
                  THEN 'Admin Network Password Change'
                  ELSE [Name]
             END AS QueueDisplayName
        FROM BPAWorkQueue WITH (NOLOCK)
       WHERE [Name] IN ('Admin_App_Password_Change', 'Password_Change')
          /* Ideally the below should refere to function RPT.RF_QueueNamesList but this is a "To Do"
             at the moment since this application currently points to BP database, not RPA reporting */
         AND '{0}' IN ('barbew1','degrac','dugasr','morsjo','robinpm','sheehad','zulbej','zinsmm','proctk')
       UNION ALL
      SELECT [Name] AS QueueName
           , CASE WHEN [Name] = 'PO Invoice_OCR_to_SAP_Invoice_Pass'
                  THEN 'SAP Invoice Parking'
                  ELSE [Name]
             END AS QueueDisplayName
        FROM BPAWorkQueue WITH (NOLOCK)
       WHERE [Name] NOT IN ('Admin_App_Password_Change', 'Password_Change', 'Queue 1')
     ) dt
ORDER BY QueueDisplayName