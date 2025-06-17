using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOCK
{
    public class Config
    {
        public static string RPA_RPT
        {
            get { return GetConnectionStringValue("RPA_Rpt"); }
        }

        public static string DSN_BP_PROD
        {
            get { return GetConnectionStringValue("DSN_BP_Prod"); }
        }

        public static string DSN_BP_TEST
        {
            get { return GetConnectionStringValue("DSN_BP_Test"); }
        }

        public static string DSN_BP_STAGE
        {
            get { return GetConnectionStringValue("DSN_BP_Stage"); }
        }

        public static string PROCEDURE_CURRENT_PROCESSING_ERRORS
        {
            get { return GetConfigValue("ProcedureCurrentProcessingErrors"); }
        }

        public static string EMAIL_ALERT_SUBJECT
        {
            get { return GetConfigValue("EmailAlertSubject"); }
        }

        public static string QUERY_LIST_PROCESS_NAMES
        {
            get { return GetConfigValue("Query_ListProcessNames"); }
        }

        public static string QUERY_LIST_ERROR_TYPES
        {
            get { return GetConfigValue("Query_ListErrorTypes"); }
        }
        
        public static string MAPIEX_LOG_TEST
        {
            get { return GetConfigValue("MAPIEx_Log_Test"); }
        }

        public static string MAPIEX_LOG_PROD
        {
            get { return GetConfigValue("MAPIEx_Log_Prod"); }
        }

        public static string PROCESS_ERROR_THRESHOLD_PERCENTAGE
        {
            get { return GetConfigValue("Process_Error_Threshold_Percentage"); }
        }

        private static string GetConfigValue(string configKey)
        {
            if (ConfigurationManager.AppSettings[configKey] == null)
                //throw new ApplicationException("ERROR: The config key does NOT exist.");
                return string.Empty;

            return ConfigurationManager.AppSettings[configKey];
        }

        private static string GetConnectionStringValue(string configKey)
        {
            if (ConfigurationManager.ConnectionStrings[configKey] == null)
                //throw new ApplicationException("ERROR: The config key does NOT exist.");
                return string.Empty;

            return ConfigurationManager.ConnectionStrings[configKey].ConnectionString;
        }
    }
}
