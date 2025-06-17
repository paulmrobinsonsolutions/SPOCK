using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SPOCK
{
    public partial class MainForm : Form
    {
        private BackgroundWorker _workerErrorDetails = new BackgroundWorker();
        private BackgroundWorker _workerActiveSessions = new BackgroundWorker();
        private BackgroundWorker _workerQueueItems = new BackgroundWorker();

        private ExcelService _excelSvc = new ExcelService();
        private EmailService _emailSvc = new EmailService();
        private DataService _dataSvc = new DataService();
        
        Timer _timer = new Timer();
        
        // Used to store the system exception threshold defined in the config file
        private double _processRunExceptionThreshold = 0.0;

        ToolTip tt = new ToolTip();

        // Below is meant to build the email body error message for alerting
        private string _newAlertEmailBody = string.Empty;

        // This is needed in order to catch data retrieval errors due to multi-threading
        private string _dataRetrieveError = string.Empty;

        // This is to determine if the last error encountered is the same.
        // If it, don't show another error message for the same thing
        private string _lastErrMsg = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            ConfigureBackgroundWorker();
            ConfigureDefaults();

            // Perform the initial load of data
            PerformDataRefresh();
            LoadCustomReportSQL();
        }

        private void LoadCustomReportSQL()
        {
            // If the directory does not exist it clearly has not been created, therefore, not in use
            if (!Directory.Exists(LocalService.GetCustomReportsFolder()))
                return;

            string fileName = string.Empty;
            string[] dirFiles = Directory.GetFiles(LocalService.GetCustomReportsFolder(), "*.sql");
            foreach (string filePath in dirFiles)
            {
                // Get the file name only for display with a little nicer formatting display
                fileName = filePath.Substring(filePath.LastIndexOf(@"\") + 1)
                                .Replace("_", " ")
                                .Replace(".sql", "");
                var mi = new ToolStripMenuItem(fileName);

                _menuStripReporting.DropDownItems.Add(fileName, null, OnReportItemClicked);

                // Note that tags must be set after the menu item has been added to the menu strip item list
                // since the tag will get dropped (null) if added to the menu item before the menu item is 
                // added to the menu strip item list for some reason. Not cool.
                _menuStripReporting.DropDownItems[_menuStripReporting.DropDownItems.Count - 1].Tag = filePath;
            }
        }

        private void ConfigureBackgroundWorker()
        {
            // Wire up background worker for recent error grid
            _workerErrorDetails.ProgressChanged += OnWorkerRecentErrors_ProgressChanged;
            _workerErrorDetails.DoWork += OnWorkerRecentErrors_DoWork;
            _workerErrorDetails.RunWorkerCompleted += OnWorkerRecentErrors_Completed;
            _workerErrorDetails.WorkerSupportsCancellation = true;
            _workerErrorDetails.WorkerReportsProgress = true;

            // Wire up background worker for active sessions grid
            _workerActiveSessions.DoWork += OnWorkerActiveSessions_DoWork;
            _workerActiveSessions.RunWorkerCompleted += OnWorkerActiveSessions_Completed;

            // Wire up background worker for queue items remaining grid
            _workerQueueItems.DoWork += OnWorkerQueueItems_DoWork;
            _workerQueueItems.RunWorkerCompleted += OnWorkerQueueItems_Completed;
        }

        private void ConfigureDefaults()
        {
            _gridCurrentProcessErrors.DataSource = null;
            _btnExportErrors.Enabled = _gridCurrentProcessErrors.Rows.Count > 0;

            _timer.Tick += new EventHandler(OnTimerTick);   // Everytime timer ticks, timer_Tick will be called
            _timer.Enabled = true;                          // Enable the timer

            SetTimerRefreshInterval();

            double.TryParse(Config.PROCESS_ERROR_THRESHOLD_PERCENTAGE, out _processRunExceptionThreshold);
        }

        private void SetTimerRefreshInterval()
        {
            // The value of this is meant to be in minutes
            int timerRefresh;
            int.TryParse(Properties.Settings.Default.DataRefreshMinuteTimespan.ToString(), out timerRefresh);
            if (timerRefresh == 0)
                timerRefresh = 30;

            _timer.Interval = (1000 * 60) * timerRefresh;   // Timer will tick every n seconds
            _lblRefreshMinutes.Text = timerRefresh.ToString();

            /*ToDo: Should this be elsewhere? */
            _lblRefreshHourLimit.Text = Properties.Settings.Default.DataRefreshPriorHourLimit.ToString();
        }

        private void PerformDataRefresh()
        {
            EnableControls(false);

            string priorHourStart = Properties.Settings.Default.DataRefreshPriorHourLimit.ToString();

            // Clear the last error message to prepare for new run
            _newAlertEmailBody = string.Empty;
            _dataRetrieveError = string.Empty;
            
            // If the async call is not busy, meaning previous call has completed, then fire it off again
            if (!_workerErrorDetails.IsBusy)
                _workerErrorDetails.RunWorkerAsync(priorHourStart);
            if (!_workerActiveSessions.IsBusy)
                _workerActiveSessions.RunWorkerAsync();
            if (!_workerQueueItems.IsBusy)
                _workerQueueItems.RunWorkerAsync();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            PerformDataRefresh();
        }

        private void OnWorkerRecentErrors_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument == null)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                // Set result DataTable
                e.Result = _dataSvc.GetCurrentErrorData(e.Argument.ToString());
                // Set dynamically formatted new email alert per last data query (above)
                _newAlertEmailBody = _dataSvc.NEW_ALERT_EMAIL_MESSAGE;
            }
            catch (TimeoutException te)
            {
                _dataRetrieveError += "Timeout Error: " + te.Message;
                e.Result = _dataSvc.BuildDatasetForErrorResult(te.Message);
            }
            catch (Exception ex)
            {
                _dataRetrieveError += "Unhandled Exception: " + ex.Message;
                e.Result = _dataSvc.BuildDatasetForErrorResult(ex.Message);
            }
        }

        private void OnWorkerRecentErrors_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_dataRetrieveError))
            {
                if (_lastErrMsg != _dataRetrieveError)
                    _lastErrMsg = _dataRetrieveError;

                return;
            }

            if (e.Error != null)
            {
                if (_lastErrMsg != e.Error.Message)
                    _lastErrMsg = _dataRetrieveError;

                _lastErrMsg = e.Error.Message;
                return;
            }

            _gridCurrentProcessErrors.DataSource = e.Result;
            _gridCurrentProcessErrors.ClearSelection();
            _btnExportErrors.Enabled = _gridCurrentProcessErrors.Rows.Count > 0;
        }

        private void OnWorkerActiveSessions_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = _dataSvc.ExecuteQuery(File.ReadAllText(Constants.DATA_QUERY_APP_ACTIVE_SESSIONS));
            }
            catch(TimeoutException te)
            {
                _dataRetrieveError += "Timeout Error: " + te.Message;
                e.Result = _dataSvc.BuildDatasetForErrorResult(te.Message);
            }
            catch (Exception ex)
            {
                _dataRetrieveError += "Unhandled Exception: " + ex.Message;
                e.Result = _dataSvc.BuildDatasetForErrorResult(ex.Message);
            }
        }

        private void OnWorkerActiveSessions_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            _gridActiveResourceSessions.DataSource = e.Result;
            _gridActiveResourceSessions.ClearSelection();
            _btnExportActiveSessions.Enabled = _gridActiveResourceSessions.Rows.Count > 0;

            if (_gridActiveResourceSessions.Rows.Count > 0)
            {
                _gridActiveResourceSessions.Columns[0].Width = 180;
                // Hide the seconds field since last field will contain this with better formatting
                _gridActiveResourceSessions.Columns[Constants.DATA_FIELD_LAG_SECONDS].Visible = false;
                // Since data is loaded dynamically, add tool tip text programmatically for reference
                _gridActiveResourceSessions.Columns[Constants.DATA_FIELD_FROZEN_TIME].ToolTipText =
                    Constants.DATA_GENERAL_TIME_FORMAT_TOOLTIP;
            }
        }

        private void OnWorkerQueueItems_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = _dataSvc.ExecuteQuery(File.ReadAllText(Constants.DATA_QUERY_APP_QUEUE_ITEMS_REMAINING));
            }
            catch (TimeoutException te)
            {
                _dataRetrieveError += "Timeout Error: " + te.Message;
                e.Result = _dataSvc.BuildDatasetForErrorResult(te.Message);
            }
            catch (Exception ex)
            {
                _dataRetrieveError += "Unhandled Exception: " + ex.Message;
                e.Result = _dataSvc.BuildDatasetForErrorResult(ex.Message);
            }
        }

        private void OnWorkerQueueItems_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            _gridQueueForActiveSession.DataSource = e.Result;
            _gridQueueForActiveSession.ClearSelection();
            _btnExportPendingQueueDetails.Enabled = _gridQueueForActiveSession.Rows.Count > 0;

            // If rows were returned then set widths
            if (_gridQueueForActiveSession.Rows.Count > 0)
            {
                _gridQueueForActiveSession.DataSource = e.Result;
                _gridQueueForActiveSession.ClearSelection();
                _gridQueueForActiveSession.Columns[0].Width = 180;
                _gridQueueForActiveSession.Columns[_gridQueueForActiveSession.ColumnCount - 1].Width = 120;

                // Since data is loaded dynamically, add tool tip text programmatically for reference
                if (_gridQueueForActiveSession.Columns.Contains(Constants.DATA_FIELD_AVG_WORKTIME))
                {
                    _gridQueueForActiveSession.Columns[Constants.DATA_FIELD_AVG_WORKTIME].ToolTipText =
                        Constants.DATA_GENERAL_TIME_FORMAT_TOOLTIP;
                }
            }
            else
            {
                // Can we determine a timeout error? vs no data returned
                // Ex. No results at 1 am Sunday = all queues are empty, nothing is running
                // and it's Sunday morning so just go to sleep so you can enjoy the day off
            }

            _lblLastRefreshedTimestamp.Text = DateTime.Now.ToString();

            EnableControls(true);
            SetHighlightOfNewErrors();
            SetHighlightForQueueItemAlerting();
            SetRowCounts();

            // If the alert email body is not empty then alerting is turned and meets
            // the current days desired time constraints specified by this person
            if (!string.IsNullOrEmpty(_newAlertEmailBody) && !string.IsNullOrEmpty(Properties.Settings.Default.EmailAlertEmailAddress))
            {
                string emailBodyHtml = GetHtmlPageContent();

                // wrap HTML text in valid HTML table syntax
                _newAlertEmailBody = string.Format(emailBodyHtml, _newAlertEmailBody);

                string errMsg =
                    _emailSvc.SendEmail(Properties.Settings.Default.EmailAlertEmailAddress
                    , Config.EMAIL_ALERT_SUBJECT
                    , _newAlertEmailBody);

                if (!string.IsNullOrEmpty(errMsg))
                {
                    _lblErrorMessage.Text = errMsg;
                    _lblErrorMessage.Visible = true;
                }
            }

            FlashWindow.Flash(this);
        }

        /// <summary>
        /// Set row highlighting for the Queue details grid which may need
        /// attention and/or analysis for potential issues
        /// </summary>
        private void SetHighlightForQueueItemAlerting()
        {
            int cellLagSeconds = 0;
            
            // Evaluate errors in the Active Resource Sessions grid
            foreach (DataGridViewRow row in _gridActiveResourceSessions.Rows)
            {
                cellLagSeconds = Convert.ToInt32(row.Cells[Constants.DATA_FIELD_LAG_SECONDS].Value);

                // If the cell value is less than 10 minutes then exit. Since results are in descending order
                // there won't be any more rows to highlight, so let's not waste our time here.
                if (cellLagSeconds < 600)
                    continue;

                // If the row's seconds lag is greater than 10 minutes then highlight
                if (cellLagSeconds > 600)
                {
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    row.Cells[Constants.DATA_FIELD_FROZEN_TIME].ErrorText = Constants.DATA_ERROR_MSG_LAG_SECONDS;
                }
            }

            /* VARIABLES FOR EXCESS ERROR COUNTS. FIRST EVALUATION CODE BLOCK */
            int processExceptionCount = 0;
            int processTotalItemsCount = 0;
            double errorPercentage = 0.0;

            /* VARIABLES FOR EXCESS ERROR COUNTS. FIRST EVALUATION CODE BLOCK */
            int activeResources = 0;
            int remainingQueueItems = 0;

            if (_gridQueueForActiveSession.Columns.Count == 1)
                return;

            // Evaluate errors in the Queue Details for Active Sessions grid
            foreach (DataGridViewRow row in _gridQueueForActiveSession.Rows)
            {
                /* BEGIN EVALUATION OF EXCESS ERROR COUNTS */
                // clear for each new row
                processExceptionCount = 0;
                errorPercentage = 0.0;
                int.TryParse(row.Cells[Constants.DATA_FIELD_QUEUE_GRID_SYSTEM_EXCEPTIONS].Value.ToString(),
                                out processExceptionCount);
                if (processExceptionCount > 0)
                {
                    int.TryParse(row.Cells[Constants.DATA_FIELD_QUEUE_GRID_TOTAL_ITEMS].Value.ToString(),
                                    out processTotalItemsCount);
                    errorPercentage = (errorPercentage + processExceptionCount) / processTotalItemsCount;
                }

                if (errorPercentage > _processRunExceptionThreshold)
                {
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    row.Cells[Constants.DATA_FIELD_QUEUE_GRID_SYSTEM_EXCEPTIONS].ErrorText 
                                = Constants.DATA_ERROR_MSG_SYSTEM_EXCEPTIONS;
                }
                /* END EVALUATION OF EXCESS ERROR COUNTS */

                /* BEGIN EVALUATION OF REMAINING QUEUE ITEMS WITH NO ACTIVE RESOURCE WORKING THEM */
                // clear for each new row
                activeResources = 0;
                remainingQueueItems = 0;
                int.TryParse(row.Cells[Constants.DATA_FIELD_QUEUE_GRID_RESOURCES].Value.ToString(), out activeResources);
                int.TryParse(row.Cells[Constants.DATA_FIELD_QUEUE_GRID_REMAINING].Value.ToString(), out remainingQueueItems);
                if (remainingQueueItems > 0 && activeResources == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    row.Cells[Constants.DATA_FIELD_QUEUE_GRID_REMAINING].ErrorText
                                = Constants.DATA_ERROR_MSG_REMAINING_QUEUE_ITEMS;
                }
                /* END EVALUATION OF REMAINING QUEUE ITEMS WITH NO ACTIVE RESOURCE WORKING THEM */
            }
        }

        private void SetHighlightOfNewErrors()
        {
            // Set evaluation date based on specified refresh minutes limit
            DateTime evalDate = DateTime.Now.AddMinutes(-Properties.Settings.Default.DataRefreshMinuteTimespan);
            DateTime rowSessionStart;
            string rowErrorType = string.Empty;
            bool errorTypeFound = false;

            // Evaluate new items in the Current Processing Errors grid
            foreach (DataGridViewRow row in _gridCurrentProcessErrors.Rows)
            {
                rowSessionStart = Convert.ToDateTime(row.Cells[Constants.DATA_FIELD_SESSION_START].Value);
                rowErrorType = row.Cells[Constants.DATA_FIELD_ERROR_TYPE].Value.ToString();

                // If the row's date/time is after the refresh period, it's a new item so highlight it and send notification if desired
                if (rowSessionStart >= evalDate)
                {
                    row.DefaultCellStyle.BackColor = Color.LightSteelBlue;

                    // If the session start time is within the user's chosen alert before and after time
                    // AND the row's error type is one the one's selected by the user to be alerted of
                    errorTypeFound = Properties.Settings.Default.EmailAlertingSelectedErrorTypes.Contains(rowErrorType);
                    if ((rowSessionStart < _dataSvc.ALERT_BEFORE_TIME 
                        || rowSessionStart >= _dataSvc.ALERT_AFTER_TIME) && errorTypeFound == true)
                    {
                        _newAlertEmailBody += string.Format(Constants.EMAIL_DATA_ROW_HTML,
                            row.Cells[Constants.DATA_FIELD_ERROR_TYPE].Value,
                            row.Cells[Constants.DATA_FIELD_PROCESS_NAME].Value,
                            row.Cells[Constants.DATA_FIELD_SESSION_START].Value);
                    }
                }
            }
        }
        
        private void SetRowCounts()
        {
            _lblCurrentProcessErrorsRowCount.Text = string.Format("Total Rows: {0}", _gridCurrentProcessErrors.Rows.Count);
            _lblActiveResourceSessionRowCount.Text = string.Format("Total Rows: {0}", _gridActiveResourceSessions.Rows.Count);
            _lblQueueDetailsRowCount.Text = string.Format("Total Rows: {0}", _gridQueueForActiveSession.Rows.Count);
        }

        private string GetHtmlPageContent()
        {
            string result = string.Empty;

            using (WebClient client = new WebClient())
            {
                string url = "EmailBody.htm";
                result = client.DownloadString(url);
            }

            return result;
        }
        
        private void EnableControls(bool doEnable)
        {
            _btnRefresh.Enabled = doEnable;
            _gridActiveResourceSessions.Enabled = doEnable;
            _gridCurrentProcessErrors.Enabled = doEnable;
            _gridQueueForActiveSession.Enabled = doEnable;
            Application.UseWaitCursor = !doEnable; // Opposite of enable/disable controls
        }

        private void LoadReportForm(string menuItemTag, string menuLabelText)
        {
            var rf = new ReportForm(menuItemTag, menuLabelText);
            rf.StartPosition = FormStartPosition.CenterParent;
            rf.ShowDialog(this);
        }

        private void PerformExportToExcel(DataGridView gridView)
        {
            gridView.SelectAll();
            DataObject dataObj = gridView.GetClipboardContent();

            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            gridView.ClearSelection();

            string errMsg = _excelSvc.PerformExport(null, "ProcessData");
            if (!string.IsNullOrEmpty(errMsg))
                LocalService.ShowWarningMessage(this, string.Format("Excel Error: {0}", errMsg));
        }

        private void OnWorkerRecentErrors_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //_lblResultCount.Text = string.Format("Progress... {0}%", e.ProgressPercentage);
        }

        private void OnExportCurrentErrorsClick(object sender, EventArgs e)
        {
            PerformExportToExcel(_gridCurrentProcessErrors);
        }

        private void OnExportActiveSessionsClick(object sender, EventArgs e)
        {
            PerformExportToExcel(_gridActiveResourceSessions);
        }

        private void OnExportActiveSessionQueueDetailsClick(object sender, EventArgs e)
        {
            PerformExportToExcel(_gridQueueForActiveSession);
        }

        private void OnMenuAboutClick(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog(this);
        }

        private void OnMenuNotificationSettingsClick(object sender, EventArgs e)
        {
            NotificationSettings ns = new NotificationSettings();
            ns.StartPosition = FormStartPosition.CenterParent;
            ns.ShowDialog(this);
            SetTimerRefreshInterval();
        }

        private void OnMenuEmailAlertSettingsClick(object sender, EventArgs e)
        {
            EmailAlertSettings eas = new EmailAlertSettings();
            eas.StartPosition = FormStartPosition.CenterParent;
            eas.ShowDialog(this);
        }
        
        private void OnReportItemClicked(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Tag.ToString() == "RUNNING_PROCESS_TIMING_GRAPH")
                LocalService.ShowWarningMessage(this, "This has not been implemented yet.");
            else
                LoadReportForm(((ToolStripMenuItem)sender).Tag.ToString(), ((ToolStripMenuItem)sender).Text);
        }

        private void OnRefreshClick(object sender, EventArgs e)
        {
            PerformDataRefresh();
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void OnMenuOnThisDayClick(object sender, EventArgs e)
        {
            var wb = new WebViewer();
            wb.StartPosition = FormStartPosition.CenterParent;
            wb.ShowDialog(this);
        }

        private void OnCustomReportAboutClick(object sender, EventArgs e)
        {
            AboutCustomReports acr = new AboutCustomReports();
            acr.StartPosition = FormStartPosition.CenterParent;
            acr.ShowDialog(this);
        }

        private void OnOpenCustomFolderClick(object sender, EventArgs e)
        {
            LocalService.OpenCustomReportsFolder();
        }

        private void OnEnter_RefreshMinuteInterval(object sender, EventArgs e)
        {
            //tt.ToolTipIcon = ToolTipIcon.Info;
            tt.IsBalloon = true;
            tt.UseFading = true;
            Cursor.Current = Cursors.Hand;
            tt.SetToolTip((Control)sender, ((Control)sender).AccessibleDescription);
        }

        private void OnMenuGetSqlUpdatesClick(object sender, EventArgs e)
        {
            LocalService.PerformUpdateCheck();
        }
    }
}
