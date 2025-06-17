using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SPOCK
{
    public static class LocalService
    {
        public static string GetCurrentEmailAlerting()
        {
            string result = string.Empty;
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    result = Properties.Settings.Default.EmailAlertMonday;
                    break;
                case DayOfWeek.Tuesday:
                    result = Properties.Settings.Default.EmailAlertTuesday;
                    break;
                case DayOfWeek.Wednesday:
                    result = Properties.Settings.Default.EmailAlertWednesday;
                    break;
                case DayOfWeek.Thursday:
                    result = Properties.Settings.Default.EmailAlertThursday;
                    break;
                case DayOfWeek.Friday:
                    result = Properties.Settings.Default.EmailAlertFriday;
                    break;
                case DayOfWeek.Saturday:
                    result = Properties.Settings.Default.EmailAlertSaturday;
                    break;
                case DayOfWeek.Sunday:
                    result = Properties.Settings.Default.EmailAlertSunday;
                    break;
            }

            return result;
        }
        
        internal static int GetHourSelectionValue(string selectedHourOption)
        {
            int result = -1;

            if (!string.IsNullOrEmpty(selectedHourOption))
            {
                if (selectedHourOption.EndsWith("AM"))
                {
                    if (selectedHourOption == "12 AM")
                        result = 0;
                    else
                        int.TryParse(selectedHourOption.Replace("AM", string.Empty).Trim(), out result);
                }
                else
                {
                    if (selectedHourOption == "12 PM")
                        result = 12;
                    {
                        int.TryParse(selectedHourOption.Replace("PM", string.Empty).Trim(), out result);
                        // Add 12 hours for PM
                        result = result + 12;
                    }
                }
            }

            return result;
        }

        public static void OpenCustomReportsFolder()
        {
            string folderStr = GetCustomReportsFolder();

            if (!Directory.Exists(folderStr))
                Directory.CreateDirectory(folderStr);

            Process.Start("explorer.exe", folderStr);
        }

        public static string GetCustomReportsFolder()
        {
            return Application.StartupPath + Constants.CUSTOM_REPORTS_FOLDER_NAME;
        }

        internal static int GetUtcHourDifference()
        {
            TimeZoneInfo cst = TimeZoneInfo.FindSystemTimeZoneById(Constants.LOCAL_TIME_ZONE);
            TimeSpan ts = cst.GetUtcOffset(DateTime.Now);
            return ts.Hours;
        }

        internal static void ShowWarningMessage(IWin32Window senderWindow, string msg)
        {
            try
            {
                MessageBox.Show(senderWindow,
                    msg,
                    "Warning Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            { }
        }

        internal static void PerformUpdateCheck()
        {
            string filePath = Application.StartupPath + @"\Get SQL Updates.bat";

            var processInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/c \"" + filePath + "\"",
                UseShellExecute = true,
                RedirectStandardError = false,
                RedirectStandardOutput = false
            };

            Process p = Process.Start(processInfo);
            p.Close();
        }
    }
}
