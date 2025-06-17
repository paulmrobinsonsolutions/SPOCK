using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOCK
{
    class NetFrameworkService
    {
        internal static DataTable GetNetFrameworkInstalledDetails()
        {
            string[] registryPathSearchList = Constants.NET_FRAMEWORK_REGISTRY_PATH;
            DataTable resultTable = CreateNetFrameworkTableStructure();

            foreach (string regPath in registryPathSearchList)
            {
                Microsoft.Win32.RegistryKey installed_versions = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(regPath);
                string[] version_names = installed_versions.GetSubKeyNames();
                for (int i = 1; i <= version_names.Length - 1; i++)
                {
                    string temp_name = ".NET Framework " + version_names[i].ToString() + "  SP" + installed_versions.OpenSubKey(version_names[i]).GetValue("SP");
                    if (temp_name.ToUpper().Contains("FRAMEWORK V"))
                    {
                        DataRow newRow = resultTable.NewRow();
                        newRow[0] = regPath;
                        newRow[1] = temp_name;
                        resultTable.Rows.Add(newRow);
                    }
                }
            }

            return resultTable;
        }

        private static DataTable CreateNetFrameworkTableStructure()
        {
            DataTable results = new DataTable();
            results.Columns.Add("RegistryPath");
            results.Columns.Add("RegistryValue");

            return results;
        }
    }
}
