@echo off

REM It's assumed this batch file will be in the root folder where the SPOCK.exe resides
REM This is because the SQL folders are assumed to be relative to the SPOCK.exe
REM **Note that xcopy will create a folder if it does NOT exist! This simplifies things!

REM The folder path below is the source of any new SPOCK updates.
set sourceCodeFolder=B:\Automation\Installs\SPOCK
set localBackupFolder=Backup_SQL

REM Check if local backup folder exists. If not, create it...
if not exist %localBackupFolder%\ (
   md %localBackupFolder%\
)

echo Starting local backup of SQL folder...
if exist %localBackupFolder%\SQL_2 (
   rmdir /s /q %localBackupFolder%\SQL_2
)

if exist %localBackupFolder%\SQL_1 (
   echo backing up files from %localBackupFolder%\SQL_1 directory to SQL_2...
   xcopy /s /i %localBackupFolder%\SQL_1 %localBackupFolder%\SQL_2
   rmdir /s /q %localBackupFolder%\SQL_1
)

REM Always copy the current SQL files to backup
xcopy /s /i SQL %localBackupFolder%\SQL_1

echo.

echo Starting local backup of CustomSQL folder...
if exist %localBackupFolder%\CustomSQL_2 (
   rmdir /s /q %localBackupFolder%\CustomSQL_2
)

if exist %localBackupFolder%\CustomSQL_1 (
   echo backing up files from %localBackupFolder%\CustomSQL_1 directory to SQL_2...
   xcopy /s /i /y %localBackupFolder%\CustomSQL_1 %localBackupFolder%\CustomSQL_2
   rmdir /s /q %localBackupFolder%\CustomSQL_1
)

REM Always copy the current SQL files to backup
xcopy /s /i /y CustomSQL %localBackupFolder%\CustomSQL_1

echo.

echo Updating app SQL folder with updated files...
xcopy /s /i /y %sourceCodeFolder%\SQL\*.* SQL\

echo.
echo Updating app CustomSQL folder with updated files...
xcopy /s /i /y %sourceCodeFolder%\CustomSQL\*.* CustomSQL\

timeout /t 20
exit