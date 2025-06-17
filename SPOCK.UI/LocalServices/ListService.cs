using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOCK
{
    public class ListService
    {
        internal static List<string> ERROR_TYPES()
        {
            List<string> results = new List<string>();

            // If an error types query is defined, query for results
            if (!string.IsNullOrEmpty(Config.QUERY_LIST_ERROR_TYPES))
            {
                Util.DataQueryFilterDto queryFilter = new Util.DataQueryFilterDto();
                queryFilter.Query = Config.QUERY_LIST_ERROR_TYPES;

                DataTable dt = Constants.DB_CONN_RPT_USER.ExecuteQuery(queryFilter);
                foreach (DataRow dr in dt.Rows)
                    results.Add(dr[0].ToString());
            }

            return results;
        }

        internal static List<string> ENVIRONMENT_VARIABLES()
        {
            List<string> results = new List<string>();

            Util.DataQueryFilterDto queryFilter = new Util.DataQueryFilterDto();
            queryFilter.Query = File.ReadAllText(@"SQL\List_EnvironmentVariables.sql");

            DataTable dt = new DAL.SQLConnector(string.Format(Config.DSN_BP_PROD, Constants.DB_REPORT_USER)).ExecuteQuery(queryFilter);
            foreach (DataRow dr in dt.Rows)
                results.Add(dr[0].ToString());

            return results;
        }

        internal static List<ListItemDto> HOUR_OPTIONS()
        {
            List<ListItemDto> results = new List<ListItemDto>();
            results.Add(new ListItemDto() { Value = "12 AM", Label = "12 AM" });
            for (int i = 1; i < 12; i++)
                results.Add(new ListItemDto() { Value = i + " AM", Label = i + " AM" });

            results.Add(new ListItemDto() { Value = "12 PM", Label = "12 PM" });
            for (int i = 1; i < 12; i++)
                results.Add(new ListItemDto() { Value = i + " PM", Label = i + " PM" });

            return results;
        }
        
        internal static List<string> MAPIEX_LOG_MESSAGES_IN_ORDER()
        {
            List<string> results = new List<string>();
            results.Add("MAPI login");
            results.Add("open message store");
            results.Add("open subfolder");
            results.Add("get contents");
            results.Add("sort contents");
            results.Add("get next message");
            results.Add("mark as read");
            results.Add("move message");
            return results;
        }

        internal static List<string> GET_LIST_OPTIONS(string DSN_BP_PROD, string queryFilename)
        {
            List<string> results = new List<string>();

            Util.DataQueryFilterDto queryFilter = new Util.DataQueryFilterDto();
            queryFilter.Query = string.Format(File.ReadAllText(queryFilename), Constants.LOGGED_IN_USER);
            DataTable dt = Constants.DB_CONN_BP_PROD_USER.ExecuteQuery(queryFilter);

            // ToDo: Update to use ListItemDto

            results = dt.AsEnumerable().Select(x => x[0].ToString()).ToList();
            return results;
        }
    }
}
