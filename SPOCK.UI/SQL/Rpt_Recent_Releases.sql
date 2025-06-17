/*
Show recent releases
- Would be nice to be able to see process change history
*/
/* BEGIN INPUT VARIABLES */
DECLARE @FromDatetime DATETIME = '{0}';
/* END INPUT VARIABLES */

DECLARE @UtcHourDiff INT =
    (SELECT TOP 1 StartTimeZoneOffset / 60 / 60
       FROM dbo.BPVSessionInfo si WITH (NOLOCK)
	  WHERE StartTimeZoneOffset < 0
      ORDER BY StartDatetime DESC)

SELECT r.ID
     , PackageId
     , DATEADD(HOUR, @UtcHourDiff, r.Created) AS ReleaseDatetime
     , p.[Name] AS ReleasePackage
     , r.[Name] AS ReleaseName
     , [Notes]
  FROM BPARelease r WITH (NOLOCK)
          INNER JOIN BPAPackage p WITH (NOLOCK)
             ON r.packageid = p.Id
 WHERE DATEADD(HOUR, @UtcHourDiff, r.Created) >= @FromDatetime
 ORDER BY r.Created DESC
;