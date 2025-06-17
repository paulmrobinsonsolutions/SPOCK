SELECT [Name]
     , DataType AS VarDataType
	 , [Value] AS VarValue
  FROM BPAEnvironmentVar WITH (NOLOCK)
 WHERE CHARINDEX('{0}', [NAME]) > 0
 ORDER BY [NAME]