/* Description: The intent of this is to provide filtering capabilities for
   alert notifications (from main menu - File > Email / SMS Alert Settings).
   You don't want to get alerts for EVERYTHING. Believe me! So it's a good
   idea to enter relavent error types that you do care about when something
   bad happens. If nothing else, so you're aware that something happened. */
SELECT ErrorType
  FROM (
       SELECT 'Process Terminated' AS ErrorType
       UNION ALL
       SELECT 'Process Seems Frozen' AS ErrorType
       UNION ALL
       SELECT 'Schedule Failed to Start' AS ErrorType
     ) dt
ORDER BY ErrorType