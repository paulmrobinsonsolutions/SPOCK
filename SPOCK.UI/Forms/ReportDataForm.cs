using DAL;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace SPOCK
{
    public partial class ReportForm : Form
    {
        private bool _isFormLoaded = false;
        private BackgroundWorker _reportWorker = new BackgroundWorker();
        private ExcelService _excelSvc = new ExcelService();
        private DataService _dataSvc = new DataService();

        ////private string _queryFilepath = string.Empty;
        private string _querySqlText = string.Empty;
        private string _selectedListOptionText = string.Empty;

        /* Default option settings */
        private DateTime _fromDatetime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, DateTimeKind.Local);
        private DateTime _thruDatetime = DateTime.Now;

        public ReportForm(string reportTag, string menuLabelText)
        {
            InitializeComponent();

            _reportWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnWorkerRunWorkerCompleted);
            _reportWorker.DoWork += new DoWorkEventHandler(OnWorkerDoWork);
            _reportWorker.WorkerSupportsCancellation = true;

            this.Text = string.Format(this.Text, menuLabelText);
            PrepareDataView(reportTag);
        }

        private void PrepareDataView(string reportTag)
        {
            string listOptionsFilename = string.Empty;
            // Set to false as default
            bool enableDateControls = false;

            //if (dataQuery.ToUpper().EndsWith("RUNNING_PROCESS_TIMING_GRAPH"))
            //    LoadRunningProcessGraphView();
            //else

            switch (reportTag)
            {
                case "RESOURCE_LAST_LOGGED_IN":
                    //_queryFilepath = @"SQL\Rpt_Resource_Last_Logged_In.sql";
                    _querySqlText = File.ReadAllText(Constants.QUERY_RPT_LAST_LOGGED_IN_BOTS);
                    LoadReportData();
                    break;

                case "ENVIRONMENT_VARIABLE_COMPARE":
                    _querySqlText = File.ReadAllText(Constants.QUERY_RPT_ENVIRONMENT_VARIABLES);
                    listOptionsFilename = Constants.QUERY_PATH_LIST_ENVIRONMENT_VARIABLES;
                    break;

                case "RECENT_RELEASES":
                    _fromDatetime = _fromDatetime.AddDays(-30);
                    _querySqlText = File.ReadAllText(Constants.QUERY_RPT_RECENT_RELEASES);
                    LoadReportData();
                    break;

                case "QUEUE_REPORT":
                    _querySqlText = File.ReadAllText(Constants.QUERY_RPT_GENERATE_QUEUE_REPORT);
                    listOptionsFilename = Constants.QUERY_PATH_LIST_QUEUE_NAMES;
                    enableDateControls = true;
                    break;

                case "QUEUE_DAILY_VOLUMES":
                    _querySqlText = File.ReadAllText(Constants.QUERY_RPT_QUEUE_DAILY_VOLUMES);
                    listOptionsFilename = Constants.QUERY_PATH_LIST_QUEUE_NAMES;
                    enableDateControls = true;
                    break;

                case "PROCESS_RUN_OVERVIEW":
                    _querySqlText = File.ReadAllText(Constants.QUERY_RPT_PROCESS_RUN_OVERVIEW);
                    listOptionsFilename = Constants.QUERY_PATH_LIST_PROCESS_NAMES;
                    enableDateControls = true;
                    break;

                case "NET_FRAMEWORKS_INSTALLED":
                    LoadNetFrameworkInstalled();
                    break;

                case "MORNING_READOUT":
                    _thruDatetime = new DateTime(_thruDatetime.Year, _thruDatetime.Month, _thruDatetime.Day, 8, 0, 0);
                    _querySqlText = File.ReadAllText(Constants.QUERY_RPT_RECENT_PROCESS_RUN_OVERVIEW);
                    LoadReportData();
                    break;
            }

            // Set each to the defaults specified above
            _datetimeFrom.Value = _fromDatetime;
            _datetimeTo.Value = _thruDatetime;

            _datetimeFrom.Enabled = enableDateControls;
            _datetimeTo.Enabled = enableDateControls;

            // If the tag contains the path to the .sql file query then set this
            // This is a custom query menu item
            if (reportTag.ToUpper().EndsWith(Constants.SQL_FILE_EXTENSION))
            {
                _querySqlText = File.ReadAllText(reportTag);

                // Does the SQL indicate to load a list of Queue names?
                if (_querySqlText.Contains(Constants.SQL_FILE_PARAM_EVAL_TEXT_QUEUE))
                    listOptionsFilename = Constants.QUERY_PATH_LIST_QUEUE_NAMES;

                // Does the SQL indicate to load a list of Process names?
                if (_querySqlText.Contains(Constants.SQL_FILE_PARAM_EVAL_TEXT_PROCESS))
                    listOptionsFilename = Constants.QUERY_PATH_LIST_QUEUE_NAMES;

                LoadReportData();
            }

            if (!string.IsNullOrEmpty(listOptionsFilename))
            {
                _comboSearchList.DataSource = ListService.GET_LIST_OPTIONS(Config.DSN_BP_PROD, listOptionsFilename);
                _comboSearchList.SelectedIndex = -1;
            }

            // Enable the "From Date" control if the query has a param for it
            _datetimeFrom.Enabled = _querySqlText.ToUpper().Contains(Constants.SQL_FILE_PARAM_EVAL_TEXT_FROM_DATE);

            // Enable the "To Date" control if the query has a param for it
            _datetimeTo.Enabled = _querySqlText.ToUpper().Contains(Constants.SQL_FILE_PARAM_EVAL_TEXT_TO_DATE);

            _comboSearchList.Enabled = _comboSearchList.Items.Count > 0;
            _isFormLoaded = true;
        }

        private void LoadNetFrameworkInstalled()
        {
            _gridResults.DataSource = NetFrameworkService.GetNetFrameworkInstalledDetails();
            _gridResults.Refresh();
            _gridResults.ClearSelection();
            EnableControls(true);
        }

        private void LoadReportData()
        {
            // Clear out any previous data
            _gridResults.DataSource = null;
            _gridResults.Refresh();

            // Secondary to ensure a valid from date is set on the control
            if (_datetimeFrom.Value.ToString().StartsWith("1/1/1001"))
                _datetimeFrom.Value = _fromDatetime;

            EnableControls(false);
            _reportWorker.RunWorkerAsync(_querySqlText);
        }

        private void EnableControls(bool doEnable)
        {
            _btnGenerateReport.Enabled = doEnable;
            _btnExport.Enabled = doEnable;
            _gridResults.Enabled = doEnable;
            Application.UseWaitCursor = !doEnable; // Opposite of enable/disable controls
        }

        private void LoadRunningProcessGraphView()
        {
            // Clear the panel before loading

            //ControlRunningProcess crp1 = new ControlRunningProcess();
            //crp1.SetControlValues("Tommy Boy", "12 h 22 m", "12:30 pm", 300);
            //_panel.Controls.Add(crp1);

            //ControlRunningProcess crp2 = new ControlRunningProcess();
            //crp2.SetControlValues("Random Process Name", "5 h 44 m", "3:22 pm", 220);
            //_panel.Controls.Add(crp2);

            //ControlRunningProcess crp3 = new ControlRunningProcess();
            //crp3.SetControlValues("My Last Process Sampler", "2 h 20 m", "11:45 pm", 110);
            //_panel.Controls.Add(crp3);
        }

        private DataTable GetReportData()
        {
            Util.DataQueryFilterDto dto = new Util.DataQueryFilterDto();
            dto.Query = _dataSvc.BuildQuery(_querySqlText, _selectedListOptionText, _fromDatetime, _thruDatetime);

            // Due to the need for multiple queries below is an exception to the standard
            if (this.Text.ToUpper().EndsWith("VARIABLE COMPARE"))
            {
                return _dataSvc.GetVariableCompareData(_querySqlText, _selectedListOptionText);
            }
            else
            {
                SQLConnector sqlConn = _dataSvc.GeTargetDatabaseConnecter(dto.Query);
                try
                {
                    return sqlConn.ExecuteQuery(dto);
                }
                catch (Exception ex)
                {
                    return _dataSvc.BuildDatasetForErrorResult(ex.Message);
                }
            }
        }

        private void SetReportDataResults(DataTable resultData)
        {
            _gridResults.DataSource = resultData;
            _gridResults.ClearSelection();

            EnableControls(true);

            _btnExport.Enabled = _gridResults.Rows.Count > 0;
            _lblResultRowCount.Text = string.Format("Total Rows: {0}", _gridResults.Rows.Count);
        }

        private void OnWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = GetReportData();
        }

        private void OnWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetReportDataResults((DataTable)e.Result);
        }

        private void OnGenerateReportClick(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void OnListOptionSelected(object sender, EventArgs e)
        {
            if (_isFormLoaded == false)
                return;

            if (_comboSearchList.SelectedItem != null)
                _selectedListOptionText = _comboSearchList.SelectedItem.ToString();

            // Exception: If "Queue Reporting" and PO Parking then address reporting differences with special query
            if (this.Text.ToUpper().Contains("QUEUE REPORT") &&
                   _comboSearchList.SelectedItem.ToString().ToUpper() == Constants.RPT_MENU_ITEM_PO_PARKING)
                _querySqlText = File.ReadAllText(Constants.QUERY_RPT_GENERATE_QUEUE_REPORT_PO_PARKING);

            if (!_datetimeFrom.Enabled)
                LoadReportData();
        }

        private void OnExportDataClick(object sender, EventArgs e)
        {
            string errMsg = string.Empty;

            try
            { 
                _gridResults.SelectAll();
                DataObject dataObj = _gridResults.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);

                errMsg = _excelSvc.PerformExport(null, "ReportData");
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                _gridResults.ClearSelection();
            }

            if (!string.IsNullOrEmpty(errMsg))
            {
                LocalService.ShowWarningMessage(this, string.Format("Excel Error: {0}", errMsg));
            }
        }

        private void OnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void OnFromDateChanged(object sender, EventArgs e)
        {
            if (_datetimeFrom.Value == null)
                return;

            DateTime.TryParse(_datetimeFrom.Value.ToString(), out _fromDatetime);
            // strip off seconds value
            _fromDatetime = _fromDatetime.AddSeconds(-_fromDatetime.Second);
        }

        private void OnThruDateChanged(object sender, EventArgs e)
        {
            if (_datetimeTo.Value == null)
                return;

            DateTime.TryParse(_datetimeTo.Value.ToString(), out _thruDatetime);
            // strip of seconds value
            _thruDatetime = _thruDatetime.AddSeconds(-_thruDatetime.Second);
        }
    }
}
