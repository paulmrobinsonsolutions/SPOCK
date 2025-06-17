using DAL;
using System;
using System.Data;
using System.IO;

namespace SPOCK
{
    internal class DataService
    {
        private DAL.IDatabaseConnector _dbConnector = Constants.DB_CONN_BP_PROD_USER;
        private DAL.IDatabaseConnector _dbConnectorRpaRpt = Constants.DB_CONN_RPT_USER;

        public DateTime ALERT_BEFORE_TIME { get; internal set; }
        public DateTime ALERT_AFTER_TIME { get; internal set; }
        public string NEW_ALERT_EMAIL_MESSAGE { get; internal set; }

        internal DataTable GetCurrentErrorData(string priorHoursFilter)//(Hashtable inputArgs)
        {
            // Clear value from any prior run
            this.NEW_ALERT_EMAIL_MESSAGE = string.Empty;

            DataTable bpDT = new DataTable("BPData");
            DataTable appsDT = new DataTable("AppData");

            // On each refresh get the current days email alerting since the
            // application could theoretically be left open for days
            string todaysEmailAlerting = LocalService.GetCurrentEmailAlerting();

            // If an "All Day" alert then set time constraints from the 0 hour/minute/second to the last second of the day
            if (todaysEmailAlerting == Constants.SETTING_ALL_DAY)
            {
                // Due to possibility of milliseconds move "before" time to zero seconds of next day to then evaluate as before or "<"
                ALERT_BEFORE_TIME = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, 0, 0, 0);
                ALERT_AFTER_TIME = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            }

            // If not the first "if" then if it's not empty hour limitations must've been selected
            else if (!string.IsNullOrEmpty(todaysEmailAlerting))
            {
                string[] splitValues = todaysEmailAlerting.Split(Constants.SETTING_DIVIDER_BAR);
                int tempHour = 0;

                // If the "before" hour was selected...
                if (!string.IsNullOrEmpty(splitValues[0]))
                {
                    tempHour = LocalService.GetHourSelectionValue(splitValues[0]);
                    ALERT_BEFORE_TIME = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, tempHour, 0, 0);
                }

                // If the "after" hour was selected...
                if (!string.IsNullOrEmpty(splitValues[1]))
                {
                    tempHour = LocalService.GetHourSelectionValue(splitValues[1]);
                    ALERT_AFTER_TIME = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, tempHour, 0, 0);
                }
            }

            // If no before time was selected then set to first second of current day so this criteria could never be met
            if (ALERT_BEFORE_TIME.Year == 1) // "1/1/0001 12:00:00 AM"
                ALERT_BEFORE_TIME = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            // If no after time was selected then set to first second of next day so this criteria could never be met
            if (ALERT_AFTER_TIME.Year == 1)
                ALERT_AFTER_TIME = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).AddDays(1);

            Util.DataQueryFilterDto queryDtoBP = new Util.DataQueryFilterDto();
            queryDtoBP.Query = string.Format(File.ReadAllText(Constants.DATA_QUERY_APP_CURRENT_PROCESS_ERRORS_BP)
                                        , priorHoursFilter, LocalService.GetUtcHourDifference());
            bpDT = _dbConnector.ExecuteQuery(queryDtoBP);

            Util.DataQueryFilterDto queryDtoApps = new Util.DataQueryFilterDto();
            queryDtoApps.Query = string.Format(File.ReadAllText(Constants.DATA_QUERY_APP_CURRENT_PROCESS_ERRORS_APP)
                                        , priorHoursFilter, LocalService.GetUtcHourDifference());
            appsDT = _dbConnectorRpaRpt.ExecuteQuery(queryDtoApps);

            // If no data is returned then return
            if (bpDT.Rows.Count + appsDT.Rows.Count == 0)
                return new DataTable();

            // Loop through each row and add it to first DP data table
            foreach (DataRow r in appsDT.Rows)
                bpDT.ImportRow(r);

            // Sort the combined output in the following order
            var sortedTable = bpDT.AsEnumerable()
                            .OrderByDescending(r => r.Field<DateTime>(Constants.DATA_FIELD_SESSION_START))
                            .ThenByDescending(r => r.Field<string>(Constants.DATA_FIELD_PROCESS_NAME))
                            .ThenByDescending(r => r.Field<string>(Constants.DATA_FIELD_RESOURCE_NAME))
                            .CopyToDataTable();

            return sortedTable;
        }

        internal DataTable ExecuteQuery(string queryString)
        {
            Util.DataQueryFilterDto dto = new Util.DataQueryFilterDto
            {
                Query = queryString
            };

            return _dbConnector.ExecuteQuery(dto);
        }

        internal DataTable BuildDatasetForErrorResult(string message)
        {
            DataTable results = new DataTable();
            DataColumn dataColumn = results.Columns.Add("Error_Message");
            DataRow dataRow = results.Rows.Add(message);

            return results;
        }

        internal DataTable GetVariableCompareData(string querySqlText, string selectedListOptionText)
        {
            _ = new DataTable();
            Util.DataQueryFilterDto dto = new Util.DataQueryFilterDto();

            // Get test environment variables
            dto.Query = string.Format(querySqlText, selectedListOptionText)
                        .Replace("VarDataType", "Test_DataType")
                        .Replace("VarValue", "Test_Value");
            DataTable resultTable = Constants.DB_CONN_BP_TEST_USER.ExecuteQuery(dto);

            // Set the primary key column
            resultTable.PrimaryKey = new DataColumn[] { resultTable.Columns[0] };

            // Get staging environment variables
            dto.Query = string.Format(querySqlText, selectedListOptionText)
                        .Replace("VarDataType", "Staging_DataType")
                        .Replace("VarValue", "Staging_Value");
            resultTable.Merge(Constants.DB_CONN_BP_STAGE_USER.ExecuteQuery(dto));

            // Get production envrionment variables
            dto.Query = string.Format(querySqlText, selectedListOptionText)
                        .Replace("VarDataType", "Prod_DataType")
                        .Replace("VarValue", "Prod_Value");
            resultTable.Merge(Constants.DB_CONN_BP_PROD_USER.ExecuteQuery(dto));

            return resultTable;
        }

        internal SQLConnector GeTargetDatabaseConnecter(string inQueryEval)
        {
            if (!string.IsNullOrEmpty(inQueryEval))
            {
                // Evaluate if there is a reference to Test
                if (inQueryEval.Substring(0, 6).Replace("--", "").ToUpper() == "TEST")
                    return Constants.DB_CONN_BP_TEST_USER;

                // Evaluate if there is a reference to Staging
                if (inQueryEval.ToUpper().Substring(0, 6).Replace("--", "") == "STAG")
                    return Constants.DB_CONN_BP_STAGE_USER;
            }

            return Constants.DB_CONN_BP_PROD_USER;
        }

        internal string BuildQuery(string querySqlText, string selectedListOptionText, DateTime fromDatetime, DateTime thruDatetime)
        {
            // Begin check of query paramater specifics
            if (querySqlText.ToUpper().Contains("@QUEUE") || querySqlText.ToUpper().Contains("@PROCESS"))
            {
                return string.Format(querySqlText,
                    selectedListOptionText, fromDatetime, thruDatetime, LocalService.GetUtcHourDifference());
            }

            else if (querySqlText.ToUpper().Contains("@FROMDATE") && querySqlText.ToUpper().Contains("@TODATE"))
                return string.Format(querySqlText, fromDatetime, thruDatetime);

            else if (querySqlText.ToUpper().Contains("@FROMDATE"))
                return string.Format(querySqlText, fromDatetime);

            else if (querySqlText.ToUpper().Contains("@TODATE"))
                return string.Format(querySqlText, thruDatetime);

            else
            {
                // catch-all - ONLY with new code, extending functionality could this condition ever be a problem
                // If no input parameters discovered then return incoming query text
                return string.Format(querySqlText,
                    selectedListOptionText, fromDatetime, thruDatetime, LocalService.GetUtcHourDifference());
            }
        }
    }
}
