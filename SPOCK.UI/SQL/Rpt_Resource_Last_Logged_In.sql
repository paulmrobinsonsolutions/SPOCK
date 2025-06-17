/*
Get all resources with their last logged in Bot ID
*/
SELECT r.[Name]
     , (SELECT TOP 1 CAST(StartParamsXml AS XML).value('(/inputs/input/@value)[1]', 'nvarchar(max)')  AS BotId
          FROM BPVSessionInfo l WITH (NOLOCK)
         WHERE l.ProcessName = 'Login By network ID'
           AND l.RunningResourceID = r.ResourceId
         ORDER BY StartDatetime DESC
       ) AS LastLoginId
     , (SELECT TOP 1 CONVERT(VARCHAR, l.enddatetime, 22)
          FROM BPVSessionInfo l WITH (NOLOCK)
         WHERE l.ProcessName = 'Login By network ID'
           AND l.RunningResourceID = r.ResourceId
         ORDER BY StartDatetime DESC) AS LastLoginTime
     , r.[DisplayStatus] AS ResourceStatus
     , r.LastUpdated AS ResourceLastUpdate
  FROM BPAResource r WITH (NOLOCK)
 WHERE LEFT(r.[Name], 9) IN ('AZUSE-TWP')  -- Exclude non-Prod resources; laptops
   AND r.[Name] NOT IN ('NGUSHZ007170','AZUSE-TWP03')
   AND CHARINDEX('debug', r.[Name]) = 0  -- Exclude non-Prod runs; debugging sessions
   AND AttributeID <> 1 -- These do NOT show in control room
 ORDER BY r.[Name]
;