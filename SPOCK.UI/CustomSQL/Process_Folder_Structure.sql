SELECT ISNULL(gLvl2.[Name], g.[Name]) AS TopLvl_GroupName
     , p.[Name] AS ProcessName
     --, p.ProcessId
     --, gp.GroupId AS L1_GroupId
     --, g.[Name] AS L1_GroupName
  FROM dbo.BPAProcess p WITH (NOLOCK)
          INNER JOIN dbo.BPAGroupProcess gp WITH (NOLOCK)
             ON gp.ProcessId = p.ProcessId
          INNER JOIN dbo.BPAGroup g WITH (NOLOCK)
             ON g.Id = gp.GroupId
           LEFT OUTER JOIN dbo.BPAGroupGroup gg WITH (NOLOCK)
             ON gg.MemberId = gp.GroupId
 	   LEFT OUTER JOIN dbo.BPAGroup gLvl2 WITH (NOLOCK)
             ON gg.GroupId = gLvl2.Id
 WHERE ISNULL(gLvl2.[Name], g.[Name]) NOT IN ('Admin','Brian','retire','test')
   AND ProcessType = 'P'

 ORDER BY ISNULL(gLvl2.[Name], g.[Name])
     , p.[Name]
;
