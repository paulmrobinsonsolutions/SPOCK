using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SPOCK
{
    public class ExcelService
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public ExcelService() { }

        public string PerformExport(DataTable dataTableDataToExport, string worksheetName)
        {
            string result = string.Empty;
            Microsoft.Office.Interop.Excel.Application xlApp = null;

            try
            {
                // Instantiate a new Excel application and start excel via "new"
                xlApp = new Microsoft.Office.Interop.Excel.Application();
            }
            catch(Exception ex)
            {
                // Excel could not be instantiated due to Windows reference issues
                return "Excel could not be launched due to conflicting Excel and/or Windows DLLs. " + ex.Message;
            }

            xlApp.Visible = true;

            // Get a new workbook
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(Missing.Value);

            // Get the active worksheet
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.ActiveSheet;

            try
            {
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = 
                    (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[1, 1];
                CR.Select();
                xlWorksheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                CR.Select();

                // Resize columns
                xlWorksheet.Columns.AutoFit();
                IntPtr handler = FindWindow(null, xlApp.Caption);
                SetForegroundWindow(handler);

            }   
            catch (Exception ex)
            {
                // If an error occurs while trying to output the data to Excel
                result = ex.Message.ToString();
            }
            finally
            {
                // Clear used resources from memory
                xlWorksheet = null;
                xlWorkbook = null;
            }
            
            // Clean up resources
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            return result;
        }
    }
}
