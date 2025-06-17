namespace SPOCK
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this._gridCurrentProcessErrors = new System.Windows.Forms.DataGridView();
            this._menu = new System.Windows.Forms.MenuStrip();
            this._menuStripFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._emailSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._onThisDayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuStripReporting = new System.Windows.Forms.ToolStripMenuItem();
            this.morningReadoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastLoggedInBotByResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envVariableCompareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processChangeHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runningProcessTimingGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNETFrameworkInstalledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.generateQueueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queueDailyVolumesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processRunOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._menuStripCustomReports = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCustomFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuStripAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this._lblLastRefreshed = new System.Windows.Forms.Label();
            this._lblLastRefreshedTimestamp = new System.Windows.Forms.Label();
            this._lblCurrentProcessErrorsRowCount = new System.Windows.Forms.Label();
            this._btnExportErrors = new System.Windows.Forms.Button();
            this._btnExit = new System.Windows.Forms.Button();
            this._btnRefresh = new System.Windows.Forms.Button();
            this._lblRefreshMinuteInterval = new System.Windows.Forms.Label();
            this._lblRefreshMinutes = new System.Windows.Forms.Label();
            this._lblRefreshHourThreshold = new System.Windows.Forms.Label();
            this._lblRefreshHourLimit = new System.Windows.Forms.Label();
            this._lblErrorMessage = new System.Windows.Forms.Label();
            this._gridActiveResourceSessions = new System.Windows.Forms.DataGridView();
            this._lblActiveResourcesSessions = new System.Windows.Forms.Label();
            this._lblQueueForActiveSessions = new System.Windows.Forms.Label();
            this._gridQueueForActiveSession = new System.Windows.Forms.DataGridView();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._lblActiveResourceSessions = new System.Windows.Forms.Label();
            this._lblActiveResourceSessionRowCount = new System.Windows.Forms.Label();
            this._btnExportActiveSessions = new System.Windows.Forms.Button();
            this._btnExportPendingQueueDetails = new System.Windows.Forms.Button();
            this._lblQueueDetailsRowCount = new System.Windows.Forms.Label();
            this._splitMainContainer = new System.Windows.Forms.SplitContainer();
            this._lblNewItemsNotice = new System.Windows.Forms.Label();
            this._lblCurrentProcessingErrors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._gridCurrentProcessErrors)).BeginInit();
            this._menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridActiveResourceSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridQueueForActiveSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitMainContainer)).BeginInit();
            this._splitMainContainer.Panel1.SuspendLayout();
            this._splitMainContainer.Panel2.SuspendLayout();
            this._splitMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gridCurrentProcessErrors
            // 
            this._gridCurrentProcessErrors.AllowUserToAddRows = false;
            this._gridCurrentProcessErrors.AllowUserToDeleteRows = false;
            this._gridCurrentProcessErrors.AllowUserToResizeRows = false;
            this._gridCurrentProcessErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridCurrentProcessErrors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridCurrentProcessErrors.BackgroundColor = System.Drawing.Color.Gainsboro;
            this._gridCurrentProcessErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridCurrentProcessErrors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._gridCurrentProcessErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridCurrentProcessErrors.DefaultCellStyle = dataGridViewCellStyle2;
            this._gridCurrentProcessErrors.Location = new System.Drawing.Point(0, 16);
            this._gridCurrentProcessErrors.Name = "_gridCurrentProcessErrors";
            this._gridCurrentProcessErrors.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridCurrentProcessErrors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._gridCurrentProcessErrors.RowHeadersVisible = false;
            this._gridCurrentProcessErrors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridCurrentProcessErrors.Size = new System.Drawing.Size(1084, 225);
            this._gridCurrentProcessErrors.TabIndex = 0;
            // 
            // _menu
            // 
            this._menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuStripFileItem,
            this._menuStripReporting,
            this._menuStripCustomReports,
            this._menuStripAboutItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._menu.Size = new System.Drawing.Size(1084, 24);
            this._menu.TabIndex = 1;
            this._menu.Text = "Menu";
            // 
            // _menuStripFileItem
            // 
            this._menuStripFileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this._toolStripMenuItem,
            this._emailSettingsToolStripMenuItem,
            this._onThisDayMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this._menuStripFileItem.Name = "_menuStripFileItem";
            this._menuStripFileItem.Size = new System.Drawing.Size(37, 20);
            this._menuStripFileItem.Text = "File";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Get SQL updates...";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.OnMenuGetSqlUpdatesClick);
            // 
            // _toolStripMenuItem
            // 
            this._toolStripMenuItem.Name = "_toolStripMenuItem";
            this._toolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this._toolStripMenuItem.Text = "Refresh Settings";
            this._toolStripMenuItem.Click += new System.EventHandler(this.OnMenuNotificationSettingsClick);
            // 
            // _emailSettingsToolStripMenuItem
            // 
            this._emailSettingsToolStripMenuItem.Name = "_emailSettingsToolStripMenuItem";
            this._emailSettingsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this._emailSettingsToolStripMenuItem.Text = "Email / SMS Alert Settings";
            this._emailSettingsToolStripMenuItem.Click += new System.EventHandler(this.OnMenuEmailAlertSettingsClick);
            // 
            // _onThisDayMenuItem
            // 
            this._onThisDayMenuItem.Name = "_onThisDayMenuItem";
            this._onThisDayMenuItem.Size = new System.Drawing.Size(210, 22);
            this._onThisDayMenuItem.Text = "On This Day...";
            this._onThisDayMenuItem.Click += new System.EventHandler(this.OnMenuOnThisDayClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitClick);
            // 
            // _menuStripReporting
            // 
            this._menuStripReporting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.morningReadoutToolStripMenuItem,
            this.lastLoggedInBotByResourceToolStripMenuItem,
            this.envVariableCompareToolStripMenuItem,
            this.processChangeHistoryToolStripMenuItem,
            this.runningProcessTimingGraphToolStripMenuItem,
            this.viewNETFrameworkInstalledToolStripMenuItem,
            this.toolStripSeparator3,
            this.generateQueueReportToolStripMenuItem,
            this.queueDailyVolumesToolStripMenuItem,
            this.processRunOverviewToolStripMenuItem,
            this.toolStripSeparator4});
            this._menuStripReporting.Name = "_menuStripReporting";
            this._menuStripReporting.Size = new System.Drawing.Size(71, 20);
            this._menuStripReporting.Text = "Reporting";
            // 
            // morningReadoutToolStripMenuItem
            // 
            this.morningReadoutToolStripMenuItem.Name = "morningReadoutToolStripMenuItem";
            this.morningReadoutToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.morningReadoutToolStripMenuItem.Tag = "MORNING_READOUT";
            this.morningReadoutToolStripMenuItem.Text = "Morning Readout";
            this.morningReadoutToolStripMenuItem.Click += new System.EventHandler(this.OnReportItemClicked);
            // 
            // lastLoggedInBotByResourceToolStripMenuItem
            // 
            this.lastLoggedInBotByResourceToolStripMenuItem.Name = "lastLoggedInBotByResourceToolStripMenuItem";
            this.lastLoggedInBotByResourceToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.lastLoggedInBotByResourceToolStripMenuItem.Tag = "RESOURCE_LAST_LOGGED_IN";
            this.lastLoggedInBotByResourceToolStripMenuItem.Text = "Resource Last Logged In";
            this.lastLoggedInBotByResourceToolStripMenuItem.Click += new System.EventHandler(this.OnReportItemClicked);
            // 
            // envVariableCompareToolStripMenuItem
            // 
            this.envVariableCompareToolStripMenuItem.Name = "envVariableCompareToolStripMenuItem";
            this.envVariableCompareToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.envVariableCompareToolStripMenuItem.Tag = "ENVIRONMENT_VARIABLE_COMPARE";
            this.envVariableCompareToolStripMenuItem.Text = "Env. Variable Compare";
            this.envVariableCompareToolStripMenuItem.Click += new System.EventHandler(this.OnReportItemClicked);
            // 
            // processChangeHistoryToolStripMenuItem
            // 
            this.processChangeHistoryToolStripMenuItem.Name = "processChangeHistoryToolStripMenuItem";
            this.processChangeHistoryToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.processChangeHistoryToolStripMenuItem.Tag = "RECENT_RELEASES";
            this.processChangeHistoryToolStripMenuItem.Text = "Recent Releases";
            this.processChangeHistoryToolStripMenuItem.Click += new System.EventHandler(this.OnReportItemClicked);
            // 
            // runningProcessTimingGraphToolStripMenuItem
            // 
            this.runningProcessTimingGraphToolStripMenuItem.Name = "runningProcessTimingGraphToolStripMenuItem";
            this.runningProcessTimingGraphToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.runningProcessTimingGraphToolStripMenuItem.Tag = "RUNNING_PROCESS_TIMING_GRAPH";
            this.runningProcessTimingGraphToolStripMenuItem.Text = "Running Process Timing Graph";
            this.runningProcessTimingGraphToolStripMenuItem.Click += new System.EventHandler(this.OnReportItemClicked);
            // 
            // viewNETFrameworkInstalledToolStripMenuItem
            // 
            this.viewNETFrameworkInstalledToolStripMenuItem.Name = "viewNETFrameworkInstalledToolStripMenuItem";
            this.viewNETFrameworkInstalledToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.viewNETFrameworkInstalledToolStripMenuItem.Tag = "NET_FRAMEWORKS_INSTALLED";
            this.viewNETFrameworkInstalledToolStripMenuItem.Text = "View .NET Framework Installed";
            this.viewNETFrameworkInstalledToolStripMenuItem.Click += new System.EventHandler(this.OnReportItemClicked);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(234, 6);
            // 
            // generateQueueReportToolStripMenuItem
            // 
            this.generateQueueReportToolStripMenuItem.Name = "generateQueueReportToolStripMenuItem";
            this.generateQueueReportToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.generateQueueReportToolStripMenuItem.Tag = "QUEUE_REPORT";
            this.generateQueueReportToolStripMenuItem.Text = "Generate Queue Report";
            this.generateQueueReportToolStripMenuItem.Click += new System.EventHandler(this.OnReportItemClicked);
            // 
            // queueDailyVolumesToolStripMenuItem
            // 
            this.queueDailyVolumesToolStripMenuItem.Name = "queueDailyVolumesToolStripMenuItem";
            this.queueDailyVolumesToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.queueDailyVolumesToolStripMenuItem.Tag = "QUEUE_DAILY_VOLUMES";
            this.queueDailyVolumesToolStripMenuItem.Text = "Queue Daily Volumes";
            this.queueDailyVolumesToolStripMenuItem.Click += new System.EventHandler(this.OnReportItemClicked);
            // 
            // processRunOverviewToolStripMenuItem
            // 
            this.processRunOverviewToolStripMenuItem.Name = "processRunOverviewToolStripMenuItem";
            this.processRunOverviewToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.processRunOverviewToolStripMenuItem.Tag = "PROCESS_RUN_OVERVIEW";
            this.processRunOverviewToolStripMenuItem.Text = "Process Run Overview";
            this.processRunOverviewToolStripMenuItem.Click += new System.EventHandler(this.OnReportItemClicked);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(234, 6);
            // 
            // _menuStripCustomReports
            // 
            this._menuStripCustomReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCRToolStripMenuItem,
            this.openCustomFolderToolStripMenuItem});
            this._menuStripCustomReports.Name = "_menuStripCustomReports";
            this._menuStripCustomReports.Size = new System.Drawing.Size(104, 20);
            this._menuStripCustomReports.Text = "Custom Reports";
            // 
            // aboutCRToolStripMenuItem
            // 
            this.aboutCRToolStripMenuItem.Name = "aboutCRToolStripMenuItem";
            this.aboutCRToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.aboutCRToolStripMenuItem.Text = "About...";
            this.aboutCRToolStripMenuItem.Click += new System.EventHandler(this.OnCustomReportAboutClick);
            // 
            // openCustomFolderToolStripMenuItem
            // 
            this.openCustomFolderToolStripMenuItem.Name = "openCustomFolderToolStripMenuItem";
            this.openCustomFolderToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openCustomFolderToolStripMenuItem.Text = "Open Custom Folder";
            this.openCustomFolderToolStripMenuItem.Click += new System.EventHandler(this.OnOpenCustomFolderClick);
            // 
            // _menuStripAboutItem
            // 
            this._menuStripAboutItem.Name = "_menuStripAboutItem";
            this._menuStripAboutItem.Size = new System.Drawing.Size(52, 20);
            this._menuStripAboutItem.Text = "About";
            this._menuStripAboutItem.Click += new System.EventHandler(this.OnMenuAboutClick);
            // 
            // _lblLastRefreshed
            // 
            this._lblLastRefreshed.Location = new System.Drawing.Point(83, 29);
            this._lblLastRefreshed.Name = "_lblLastRefreshed";
            this._lblLastRefreshed.Size = new System.Drawing.Size(96, 19);
            this._lblLastRefreshed.TabIndex = 2;
            this._lblLastRefreshed.Text = "Last Refresh Time: ";
            this._lblLastRefreshed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblLastRefreshedTimestamp
            // 
            this._lblLastRefreshedTimestamp.Location = new System.Drawing.Point(179, 29);
            this._lblLastRefreshedTimestamp.Name = "_lblLastRefreshedTimestamp";
            this._lblLastRefreshedTimestamp.Size = new System.Drawing.Size(159, 19);
            this._lblLastRefreshedTimestamp.TabIndex = 3;
            this._lblLastRefreshedTimestamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblCurrentProcessErrorsRowCount
            // 
            this._lblCurrentProcessErrorsRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblCurrentProcessErrorsRowCount.BackColor = System.Drawing.Color.Salmon;
            this._lblCurrentProcessErrorsRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCurrentProcessErrorsRowCount.Location = new System.Drawing.Point(917, 1);
            this._lblCurrentProcessErrorsRowCount.Name = "_lblCurrentProcessErrorsRowCount";
            this._lblCurrentProcessErrorsRowCount.Size = new System.Drawing.Size(106, 13);
            this._lblCurrentProcessErrorsRowCount.TabIndex = 4;
            this._lblCurrentProcessErrorsRowCount.Text = "Total Rows: 0";
            this._lblCurrentProcessErrorsRowCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _btnExportErrors
            // 
            this._btnExportErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExportErrors.BackColor = System.Drawing.Color.Transparent;
            this._btnExportErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExportErrors.Image = ((System.Drawing.Image)(resources.GetObject("_btnExportErrors.Image")));
            this._btnExportErrors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnExportErrors.Location = new System.Drawing.Point(1029, 0);
            this._btnExportErrors.Name = "_btnExportErrors";
            this._btnExportErrors.Size = new System.Drawing.Size(54, 18);
            this._btnExportErrors.TabIndex = 5;
            this._btnExportErrors.Text = "Export       ";
            this._btnExportErrors.UseVisualStyleBackColor = false;
            this._btnExportErrors.Click += new System.EventHandler(this.OnExportCurrentErrorsClick);
            // 
            // _btnExit
            // 
            this._btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExit.ForeColor = System.Drawing.Color.Red;
            this._btnExit.Location = new System.Drawing.Point(1007, 787);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 6;
            this._btnExit.Text = "E&xit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.OnExitClick);
            // 
            // _btnRefresh
            // 
            this._btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this._btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("_btnRefresh.Image")));
            this._btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnRefresh.Location = new System.Drawing.Point(4, 27);
            this._btnRefresh.Name = "_btnRefresh";
            this._btnRefresh.Size = new System.Drawing.Size(75, 23);
            this._btnRefresh.TabIndex = 7;
            this._btnRefresh.Text = "Refresh   ";
            this._btnRefresh.UseVisualStyleBackColor = true;
            this._btnRefresh.Click += new System.EventHandler(this.OnRefreshClick);
            // 
            // _lblRefreshMinuteInterval
            // 
            this._lblRefreshMinuteInterval.AccessibleDescription = "This is the number of minutes to refresh the below data.";
            this._lblRefreshMinuteInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblRefreshMinuteInterval.Location = new System.Drawing.Point(752, 29);
            this._lblRefreshMinuteInterval.Name = "_lblRefreshMinuteInterval";
            this._lblRefreshMinuteInterval.Size = new System.Drawing.Size(120, 19);
            this._lblRefreshMinuteInterval.TabIndex = 8;
            this._lblRefreshMinuteInterval.Text = "Refresh Minute Interval: ";
            this._lblRefreshMinuteInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblRefreshMinuteInterval.MouseEnter += new System.EventHandler(this.OnEnter_RefreshMinuteInterval);
            // 
            // _lblRefreshMinutes
            // 
            this._lblRefreshMinutes.AccessibleDescription = "This is the number of minutes to refresh the below data.";
            this._lblRefreshMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblRefreshMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblRefreshMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRefreshMinutes.Location = new System.Drawing.Point(875, 29);
            this._lblRefreshMinutes.Name = "_lblRefreshMinutes";
            this._lblRefreshMinutes.Size = new System.Drawing.Size(34, 19);
            this._lblRefreshMinutes.TabIndex = 9;
            this._lblRefreshMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblRefreshMinutes.MouseEnter += new System.EventHandler(this.OnEnter_RefreshMinuteInterval);
            // 
            // _lblRefreshHourThreshold
            // 
            this._lblRefreshHourThreshold.AccessibleDescription = "This is the number of prior hours you want to go back for logging.";
            this._lblRefreshHourThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblRefreshHourThreshold.Location = new System.Drawing.Point(920, 29);
            this._lblRefreshHourThreshold.Name = "_lblRefreshHourThreshold";
            this._lblRefreshHourThreshold.Size = new System.Drawing.Size(127, 19);
            this._lblRefreshHourThreshold.TabIndex = 11;
            this._lblRefreshHourThreshold.Text = "Refresh Hour Threshold: ";
            this._lblRefreshHourThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblRefreshHourThreshold.MouseEnter += new System.EventHandler(this.OnEnter_RefreshMinuteInterval);
            // 
            // _lblRefreshHourLimit
            // 
            this._lblRefreshHourLimit.AccessibleDescription = "This is the number of prior hours you want to go back for logging.";
            this._lblRefreshHourLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblRefreshHourLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblRefreshHourLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRefreshHourLimit.Location = new System.Drawing.Point(1044, 29);
            this._lblRefreshHourLimit.Name = "_lblRefreshHourLimit";
            this._lblRefreshHourLimit.Size = new System.Drawing.Size(34, 19);
            this._lblRefreshHourLimit.TabIndex = 12;
            this._lblRefreshHourLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblRefreshHourLimit.MouseEnter += new System.EventHandler(this.OnEnter_RefreshMinuteInterval);
            // 
            // _lblErrorMessage
            // 
            this._lblErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblErrorMessage.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this._lblErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this._lblErrorMessage.Location = new System.Drawing.Point(461, 789);
            this._lblErrorMessage.Name = "_lblErrorMessage";
            this._lblErrorMessage.Size = new System.Drawing.Size(543, 19);
            this._lblErrorMessage.TabIndex = 13;
            this._lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblErrorMessage.Visible = false;
            // 
            // _gridActiveResourceSessions
            // 
            this._gridActiveResourceSessions.AllowUserToAddRows = false;
            this._gridActiveResourceSessions.AllowUserToDeleteRows = false;
            this._gridActiveResourceSessions.AllowUserToResizeRows = false;
            this._gridActiveResourceSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridActiveResourceSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridActiveResourceSessions.BackgroundColor = System.Drawing.Color.Gainsboro;
            this._gridActiveResourceSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridActiveResourceSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._gridActiveResourceSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridActiveResourceSessions.DefaultCellStyle = dataGridViewCellStyle5;
            this._gridActiveResourceSessions.Location = new System.Drawing.Point(0, 16);
            this._gridActiveResourceSessions.Name = "_gridActiveResourceSessions";
            this._gridActiveResourceSessions.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridActiveResourceSessions.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._gridActiveResourceSessions.RowHeadersVisible = false;
            this._gridActiveResourceSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridActiveResourceSessions.Size = new System.Drawing.Size(1082, 223);
            this._gridActiveResourceSessions.TabIndex = 14;
            // 
            // _lblActiveResourcesSessions
            // 
            this._lblActiveResourcesSessions.BackColor = System.Drawing.Color.Lavender;
            this._lblActiveResourcesSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblActiveResourcesSessions.Dock = System.Windows.Forms.DockStyle.Top;
            this._lblActiveResourcesSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblActiveResourcesSessions.Location = new System.Drawing.Point(0, 0);
            this._lblActiveResourcesSessions.Name = "_lblActiveResourcesSessions";
            this._lblActiveResourcesSessions.Size = new System.Drawing.Size(1082, 18);
            this._lblActiveResourcesSessions.TabIndex = 15;
            this._lblActiveResourcesSessions.Text = "Active Resource Sessions";
            // 
            // _lblQueueForActiveSessions
            // 
            this._lblQueueForActiveSessions.BackColor = System.Drawing.Color.LightSteelBlue;
            this._lblQueueForActiveSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblQueueForActiveSessions.Dock = System.Windows.Forms.DockStyle.Top;
            this._lblQueueForActiveSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblQueueForActiveSessions.Location = new System.Drawing.Point(0, 0);
            this._lblQueueForActiveSessions.Name = "_lblQueueForActiveSessions";
            this._lblQueueForActiveSessions.Size = new System.Drawing.Size(1082, 18);
            this._lblQueueForActiveSessions.TabIndex = 16;
            this._lblQueueForActiveSessions.Text = "Queue Details for Active Sessions";
            // 
            // _gridQueueForActiveSession
            // 
            this._gridQueueForActiveSession.AllowUserToAddRows = false;
            this._gridQueueForActiveSession.AllowUserToDeleteRows = false;
            this._gridQueueForActiveSession.AllowUserToResizeRows = false;
            this._gridQueueForActiveSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridQueueForActiveSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridQueueForActiveSession.BackgroundColor = System.Drawing.Color.Gainsboro;
            this._gridQueueForActiveSession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridQueueForActiveSession.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this._gridQueueForActiveSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridQueueForActiveSession.DefaultCellStyle = dataGridViewCellStyle8;
            this._gridQueueForActiveSession.Location = new System.Drawing.Point(0, 14);
            this._gridQueueForActiveSession.Name = "_gridQueueForActiveSession";
            this._gridQueueForActiveSession.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridQueueForActiveSession.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this._gridQueueForActiveSession.RowHeadersVisible = false;
            this._gridQueueForActiveSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridQueueForActiveSession.Size = new System.Drawing.Size(1084, 230);
            this._gridQueueForActiveSession.TabIndex = 17;
            // 
            // _splitContainer
            // 
            this._splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Controls.Add(this._lblActiveResourceSessions);
            this._splitContainer.Panel1.Controls.Add(this._lblActiveResourceSessionRowCount);
            this._splitContainer.Panel1.Controls.Add(this._btnExportActiveSessions);
            this._splitContainer.Panel1.Controls.Add(this._lblActiveResourcesSessions);
            this._splitContainer.Panel1.Controls.Add(this._gridActiveResourceSessions);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._btnExportPendingQueueDetails);
            this._splitContainer.Panel2.Controls.Add(this._lblQueueDetailsRowCount);
            this._splitContainer.Panel2.Controls.Add(this._lblQueueForActiveSessions);
            this._splitContainer.Panel2.Controls.Add(this._gridQueueForActiveSession);
            this._splitContainer.Size = new System.Drawing.Size(1084, 490);
            this._splitContainer.SplitterDistance = 241;
            this._splitContainer.TabIndex = 18;
            // 
            // _lblActiveResourceSessions
            // 
            this._lblActiveResourceSessions.BackColor = System.Drawing.Color.Lavender;
            this._lblActiveResourceSessions.Location = new System.Drawing.Point(160, 1);
            this._lblActiveResourceSessions.Name = "_lblActiveResourceSessions";
            this._lblActiveResourceSessions.Size = new System.Drawing.Size(561, 15);
            this._lblActiveResourceSessions.TabIndex = 17;
            this._lblActiveResourceSessions.Text = "- NOTE: Rows highlighted in light orange indicate processes which have been poten" +
    "tially frozen or hung up";
            this._lblActiveResourceSessions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblActiveResourceSessionRowCount
            // 
            this._lblActiveResourceSessionRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblActiveResourceSessionRowCount.BackColor = System.Drawing.Color.Lavender;
            this._lblActiveResourceSessionRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblActiveResourceSessionRowCount.Location = new System.Drawing.Point(916, 1);
            this._lblActiveResourceSessionRowCount.Name = "_lblActiveResourceSessionRowCount";
            this._lblActiveResourceSessionRowCount.Size = new System.Drawing.Size(106, 13);
            this._lblActiveResourceSessionRowCount.TabIndex = 17;
            this._lblActiveResourceSessionRowCount.Text = "Total Rows: 0";
            this._lblActiveResourceSessionRowCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _btnExportActiveSessions
            // 
            this._btnExportActiveSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExportActiveSessions.BackColor = System.Drawing.Color.Transparent;
            this._btnExportActiveSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExportActiveSessions.Image = ((System.Drawing.Image)(resources.GetObject("_btnExportActiveSessions.Image")));
            this._btnExportActiveSessions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnExportActiveSessions.Location = new System.Drawing.Point(1028, -1);
            this._btnExportActiveSessions.Name = "_btnExportActiveSessions";
            this._btnExportActiveSessions.Size = new System.Drawing.Size(54, 18);
            this._btnExportActiveSessions.TabIndex = 17;
            this._btnExportActiveSessions.Text = "Export       ";
            this._btnExportActiveSessions.UseVisualStyleBackColor = false;
            this._btnExportActiveSessions.Click += new System.EventHandler(this.OnExportActiveSessionsClick);
            // 
            // _btnExportPendingQueueDetails
            // 
            this._btnExportPendingQueueDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExportPendingQueueDetails.BackColor = System.Drawing.Color.Transparent;
            this._btnExportPendingQueueDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExportPendingQueueDetails.Image = ((System.Drawing.Image)(resources.GetObject("_btnExportPendingQueueDetails.Image")));
            this._btnExportPendingQueueDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnExportPendingQueueDetails.Location = new System.Drawing.Point(1028, -1);
            this._btnExportPendingQueueDetails.Name = "_btnExportPendingQueueDetails";
            this._btnExportPendingQueueDetails.Size = new System.Drawing.Size(54, 18);
            this._btnExportPendingQueueDetails.TabIndex = 18;
            this._btnExportPendingQueueDetails.Text = "Export       ";
            this._btnExportPendingQueueDetails.UseVisualStyleBackColor = false;
            this._btnExportPendingQueueDetails.Click += new System.EventHandler(this.OnExportActiveSessionQueueDetailsClick);
            // 
            // _lblQueueDetailsRowCount
            // 
            this._lblQueueDetailsRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblQueueDetailsRowCount.BackColor = System.Drawing.Color.LightSteelBlue;
            this._lblQueueDetailsRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblQueueDetailsRowCount.Location = new System.Drawing.Point(916, 1);
            this._lblQueueDetailsRowCount.Name = "_lblQueueDetailsRowCount";
            this._lblQueueDetailsRowCount.Size = new System.Drawing.Size(106, 13);
            this._lblQueueDetailsRowCount.TabIndex = 18;
            this._lblQueueDetailsRowCount.Text = "Total Rows: 0";
            this._lblQueueDetailsRowCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _splitMainContainer
            // 
            this._splitMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._splitMainContainer.Location = new System.Drawing.Point(0, 51);
            this._splitMainContainer.Name = "_splitMainContainer";
            this._splitMainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitMainContainer.Panel1
            // 
            this._splitMainContainer.Panel1.Controls.Add(this._lblNewItemsNotice);
            this._splitMainContainer.Panel1.Controls.Add(this._btnExportErrors);
            this._splitMainContainer.Panel1.Controls.Add(this._lblCurrentProcessErrorsRowCount);
            this._splitMainContainer.Panel1.Controls.Add(this._lblCurrentProcessingErrors);
            this._splitMainContainer.Panel1.Controls.Add(this._gridCurrentProcessErrors);
            // 
            // _splitMainContainer.Panel2
            // 
            this._splitMainContainer.Panel2.Controls.Add(this._splitContainer);
            this._splitMainContainer.Size = new System.Drawing.Size(1084, 735);
            this._splitMainContainer.SplitterDistance = 241;
            this._splitMainContainer.TabIndex = 19;
            // 
            // _lblNewItemsNotice
            // 
            this._lblNewItemsNotice.BackColor = System.Drawing.Color.LightCoral;
            this._lblNewItemsNotice.Location = new System.Drawing.Point(151, 1);
            this._lblNewItemsNotice.Name = "_lblNewItemsNotice";
            this._lblNewItemsNotice.Size = new System.Drawing.Size(451, 16);
            this._lblNewItemsNotice.TabIndex = 10;
            this._lblNewItemsNotice.Text = "- NOTE: Rows highlighted in light blue indicate new items found within the last r" +
    "efresh interval specified";
            this._lblNewItemsNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblCurrentProcessingErrors
            // 
            this._lblCurrentProcessingErrors.BackColor = System.Drawing.Color.LightCoral;
            this._lblCurrentProcessingErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblCurrentProcessingErrors.Dock = System.Windows.Forms.DockStyle.Top;
            this._lblCurrentProcessingErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCurrentProcessingErrors.Location = new System.Drawing.Point(0, 0);
            this._lblCurrentProcessingErrors.Name = "_lblCurrentProcessingErrors";
            this._lblCurrentProcessingErrors.Size = new System.Drawing.Size(1084, 18);
            this._lblCurrentProcessingErrors.TabIndex = 16;
            this._lblCurrentProcessingErrors.Text = "Current Processing Errors";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1084, 812);
            this.Controls.Add(this._splitMainContainer);
            this.Controls.Add(this._lblErrorMessage);
            this.Controls.Add(this._lblRefreshHourLimit);
            this.Controls.Add(this._lblRefreshHourThreshold);
            this.Controls.Add(this._lblRefreshMinutes);
            this.Controls.Add(this._lblRefreshMinuteInterval);
            this.Controls.Add(this._btnRefresh);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._lblLastRefreshedTimestamp);
            this.Controls.Add(this._lblLastRefreshed);
            this.Controls.Add(this._menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menu;
            this.MinimumSize = new System.Drawing.Size(1000, 350);
            this.Name = "MainForm";
            this.Text = "SPOCK - Schedule & Process Operations Control Kit";
            ((System.ComponentModel.ISupportInitialize)(this._gridCurrentProcessErrors)).EndInit();
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridActiveResourceSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridQueueForActiveSession)).EndInit();
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._splitMainContainer.Panel1.ResumeLayout(false);
            this._splitMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitMainContainer)).EndInit();
            this._splitMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _gridCurrentProcessErrors;
        private System.Windows.Forms.MenuStrip _menu;
        private System.Windows.Forms.ToolStripMenuItem _menuStripFileItem;
        private System.Windows.Forms.ToolStripMenuItem _emailSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuStripAboutItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItem;
        private System.Windows.Forms.Label _lblLastRefreshed;
        private System.Windows.Forms.Label _lblLastRefreshedTimestamp;
        private System.Windows.Forms.Label _lblCurrentProcessErrorsRowCount;
        private System.Windows.Forms.Button _btnExportErrors;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button _btnRefresh;
        private System.Windows.Forms.Label _lblRefreshMinuteInterval;
        private System.Windows.Forms.Label _lblRefreshMinutes;
        private System.Windows.Forms.Label _lblRefreshHourThreshold;
        private System.Windows.Forms.Label _lblRefreshHourLimit;
        private System.Windows.Forms.Label _lblErrorMessage;
        private System.Windows.Forms.ToolStripMenuItem _onThisDayMenuItem;
        private System.Windows.Forms.DataGridView _gridActiveResourceSessions;
        private System.Windows.Forms.Label _lblActiveResourcesSessions;
        private System.Windows.Forms.Label _lblQueueForActiveSessions;
        private System.Windows.Forms.DataGridView _gridQueueForActiveSession;
        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.SplitContainer _splitMainContainer;
        private System.Windows.Forms.Label _lblCurrentProcessingErrors;
        private System.Windows.Forms.ToolStripMenuItem _menuStripReporting;
        private System.Windows.Forms.ToolStripMenuItem lastLoggedInBotByResourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envVariableCompareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processChangeHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runningProcessTimingGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem generateQueueReportToolStripMenuItem;
        private System.Windows.Forms.Label _lblActiveResourceSessionRowCount;
        private System.Windows.Forms.Label _lblQueueDetailsRowCount;
        private System.Windows.Forms.ToolStripMenuItem _menuStripCustomReports;
        private System.Windows.Forms.ToolStripMenuItem aboutCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCustomFolderToolStripMenuItem;
        private System.Windows.Forms.Button _btnExportActiveSessions;
        private System.Windows.Forms.Button _btnExportPendingQueueDetails;
        private System.Windows.Forms.Label _lblActiveResourceSessions;
        private System.Windows.Forms.Label _lblNewItemsNotice;
        private System.Windows.Forms.ToolStripMenuItem queueDailyVolumesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processRunOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem viewNETFrameworkInstalledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morningReadoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
    }
}

