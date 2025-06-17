SELECT 'DPMS' AS QueueName
UNION ALL
SELECT CASE WHEN RIGHT(QueueName, 1) = '_'
			THEN LEFT(QueueName, LEN(QueueName) - 1)
			ELSE QueueName
		END AS QueueName
  FROM (
		SELECT DISTINCT
			  CASE WHEN CHARINDEX('_', REPLACE([Name], 'CSS_', '')) < 4
						THEN LEFT([Name], CHARINDEX('_', [Name], 6))
					WHEN CHARINDEX('_', REPLACE([Name], 'CSS_', '')) < 8
						THEN LEFT([Name], CHARINDEX('_', [Name], 10))
					ELSE LEFT([Name], CHARINDEX('_', [Name], 12))
			  END AS QueueName
			 , CHARINDEX('_', [Name], 10) as tester
		 FROM BPAEnvironmentVar WITH (NOLOCK)
        WHERE LEFT([Name], 5) NOT IN ('DPMS_', 'Admin')
	   ) dt
WHERE LEN(QueueName) > 1
ORDER BY QueueName