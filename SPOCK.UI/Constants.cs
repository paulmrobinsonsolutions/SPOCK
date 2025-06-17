using System;

namespace SPOCK
{
    public static class Constants
    {
        internal static string SETTING_ALL_DAY = "All Day";
        internal static char SETTING_DIVIDER_BAR = '|';
        internal static string SETTING_EMAIL_ALERT_DAY = "EmailAlert{0}";

        internal static string DATA_FIELD_ERROR_TYPE = "Error_Type";
        internal static string DATA_FIELD_PROCESS_NAME = "Process_Name";
        internal static string DATA_FIELD_SESSION_START = "Session_Start";
        internal static string DATA_FIELD_RESOURCE_NAME = "Resource_Name";

        internal static string DATA_FIELD_LAG_SECONDS = "SecondsLag";
        internal static string DATA_FIELD_FROZEN_TIME = "FrozenTime";
        internal static string DATA_FIELD_AVG_WORKTIME = "AvgWorktime";

        internal static string DATA_ERROR_MSG_LAG_SECONDS = "Process seems frozen/hung";
        internal static string DATA_ERROR_MSG_SYSTEM_EXCEPTIONS = "Excessive system exceptions encountered";
        internal static string DATA_ERROR_MSG_REMAINING_QUEUE_ITEMS = "Queue items remaining with no active resource";
        internal static string DATA_FIELD_QUEUE_GRID_SYSTEM_EXCEPTIONS = "SysExceptions";
        internal static string DATA_FIELD_QUEUE_GRID_TOTAL_ITEMS = "TotalProcessed";
        internal static string DATA_FIELD_QUEUE_GRID_RESOURCES = "Resources";
        internal static string DATA_FIELD_QUEUE_GRID_REMAINING = "Remaining";

        internal static string DATA_GENERAL_TIME_FORMAT_TOOLTIP = "Format = hours : minutes : seconds : milliseconds";

        internal static string DATA_QUERY_APP_ACTIVE_SESSIONS = @"SQL\App_Active_Session_Details.sql";
        internal static string DATA_QUERY_APP_QUEUE_ITEMS_REMAINING = @"SQL\App_Active_Session_Queue_Measures.sql";
        internal static string DATA_QUERY_APP_CURRENT_PROCESS_ERRORS_BP = @"SQL\App_Current_Process_Errors_BP.sql";
        internal static string DATA_QUERY_APP_CURRENT_PROCESS_ERRORS_APP = @"SQL\App_Current_Process_Errors_Apps.sql";

        internal static string RPT_MENU_ITEM_PO_PARKING = "PO INVOICE_OCR_TO_SAP_INVOICE_PASS";

        internal static string SQL_FILE_EXTENSION = ".SQL";
        internal static string SQL_FILE_PARAM_EVAL_TEXT_QUEUE = "@Queue";
        internal static string SQL_FILE_PARAM_EVAL_TEXT_PROCESS = "@Process";
        internal static string SQL_FILE_PARAM_EVAL_TEXT_FROM_DATE = "@FROMDATE";
        internal static string SQL_FILE_PARAM_EVAL_TEXT_TO_DATE = "@TODATE";

        // Below is the registry path(regedit) to look for the.NET framework installs from the root HKEY_LOCAL_MACHINE
        // https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/how-to-determine-which-versions-are-installed
        // Hey! Let's see aboot using the below command line. It's a lot easier... just saying
        // dotnet --list-runtimes
        internal static string[] NET_FRAMEWORK_REGISTRY_PATH = new string[3]
            {
                @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full",
                @"SOFTWARE\Microsoft\NET Framework Setup\NDP",
                @"SOFTWARE\Microsoft\.NETFramework"
            };

        internal static string LOGGED_IN_USER = Environment.UserName;

        // MAPIEx Log file
        internal static string DATA_FIELD_TIMESTAMP = "Timestamp";
        internal static string DATA_FIELD_LOGMESSAGE = "LogMessage";

        internal static string EMAIL_DATA_ROW_HTML = "<tr><td>{0}</td>"
                                            + "<td>{1}</td>"
                                            + "<td>{2}</td></tr>";

        internal static string LOCAL_TIME_ZONE = "Eastern Standard Time";

        // Note these are PROD database references
        internal static string DB_REPORT_USER = "User ID=Report_User;Password=Syracuse123!";
        internal static string DB_DATABASE_USER = "User ID=SQLAdmin17;Password=RPAusers2017";

        internal static DAL.SQLConnector DB_CONN_RPT_USER =
            new DAL.SQLConnector(string.Format(Config.RPA_RPT, DB_REPORT_USER));
        internal static DAL.SQLConnector DB_CONN_BP_PROD_USER =
            new DAL.SQLConnector(string.Format(Config.DSN_BP_PROD, DB_DATABASE_USER));
        internal static DAL.SQLConnector DB_CONN_BP_STAGE_USER =
            new DAL.SQLConnector(string.Format(Config.DSN_BP_STAGE, DB_DATABASE_USER));
        internal static DAL.SQLConnector DB_CONN_BP_TEST_USER =
            new DAL.SQLConnector(string.Format(Config.DSN_BP_TEST, DB_DATABASE_USER));

        internal static string CUSTOM_REPORTS_FOLDER_NAME = @"\CustomSQL";
        internal static string QUERY_PATH_LIST_QUEUE_NAMES = @"SQL\List_QueueNames.sql";
        internal static string QUERY_PATH_LIST_ENVIRONMENT_VARIABLES = @"SQL\List_EnvironmentVariables.sql";
        internal static string QUERY_PATH_LIST_PROCESS_NAMES = @"SQL\List_ProcessNames.sql";
        internal static string QUERY_RPT_LAST_LOGGED_IN_BOTS = @"SQL\Rpt_Resource_Last_Logged_In.sql";
        internal static string QUERY_RPT_ENVIRONMENT_VARIABLES = @"SQL\Rpt_Environment_Variables.sql";
        internal static string QUERY_RPT_RECENT_RELEASES = @"SQL\Rpt_Recent_Releases.sql";
        internal static string QUERY_RPT_GENERATE_QUEUE_REPORT = @"SQL\Rpt_Generate_Queue_Reporting.sql";
        internal static string QUERY_RPT_GENERATE_QUEUE_REPORT_PO_PARKING = @"SQL\Rpt_Generate_Queue_Reporting _POParking.sql";
        internal static string QUERY_RPT_PROCESS_RUN_OVERVIEW = @"SQL\Rpt_Process_Run_Overview.sql";
        internal static string QUERY_RPT_QUEUE_DAILY_VOLUMES = @"SQL\Rpt_Queue_Daily_Volumes.sql";
        internal static string QUERY_RPT_RECENT_PROCESS_RUN_OVERVIEW = @"SQL\Rpt_Recent_Process_Run_Overview.sql";

        // "http://www.onthisday.com"
        internal static string WEB_HISTORY_RSS = @"http://feeds.feedburner.com/historyorb/todayinhistory";
    }
}
