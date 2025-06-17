SELECT [Name] AS DisplayName
     , ProcessId
  FROM dbo.BPAProcess WITH (NOLOCK)
 WHERE ProcessType = 'P'
   AND LEFT([NAME], 5) NOT IN ('Chang','Check','Login','Logou','Test_','Timer','Unloc','Downl','Reboo','Strip')
   AND [NAME] NOT IN ('Login','Login - No Startup Parameters')
 ORDER BY [Name]