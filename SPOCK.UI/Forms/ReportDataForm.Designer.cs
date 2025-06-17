namespace SPOCK
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this._btnExit = new System.Windows.Forms.Button();
            this._gridResults = new System.Windows.Forms.DataGridView();
            this._lblLastRefreshed = new System.Windows.Forms.Label();
            this._btnGenerateReport = new System.Windows.Forms.Button();
            this._btnExport = new System.Windows.Forms.Button();
            this._datetimeFrom = new System.Windows.Forms.DateTimePicker();
            this._datetimeTo = new System.Windows.Forms.DateTimePicker();
            this._lblResultRowCount = new System.Windows.Forms.Label();
            this._comboSearchList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnExit
            // 
            this._btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExit.ForeColor = System.Drawing.Color.Red;
            this._btnExit.Location = new System.Drawing.Point(906, 437);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 6;
            this._btnExit.Text = "E&xit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.OnExit_Click);
            // 
            // _gridResults
            // 
            this._gridResults.AllowUserToAddRows = false;
            this._gridResults.AllowUserToDeleteRows = false;
            this._gridResults.AllowUserToResizeRows = false;
            this._gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridResults.BackgroundColor = System.Drawing.Color.Gainsboro;
            this._gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridResults.Location = new System.Drawing.Point(3, 29);
            this._gridResults.Name = "_gridResults";
            this._gridResults.ReadOnly = true;
            this._gridResults.RowHeadersVisible = false;
            this._gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridResults.Size = new System.Drawing.Size(979, 406);
            this._gridResults.TabIndex = 80;
            this._gridResults.TabStop = false;
            // 
            // _lblLastRefreshed
            // 
            this._lblLastRefreshed.Location = new System.Drawing.Point(5, 4);
            this._lblLastRefreshed.Name = "_lblLastRefreshed";
            this._lblLastRefreshed.Size = new System.Drawing.Size(127, 19);
            this._lblLastRefreshed.TabIndex = 10;
            this._lblLastRefreshed.Text = "Select search option:";
            this._lblLastRefreshed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _btnGenerateReport
            // 
            this._btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGenerateReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this._btnGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("_btnGenerateReport.Image")));
            this._btnGenerateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnGenerateReport.Location = new System.Drawing.Point(829, 2);
            this._btnGenerateReport.Name = "_btnGenerateReport";
            this._btnGenerateReport.Size = new System.Drawing.Size(75, 23);
            this._btnGenerateReport.TabIndex = 4;
            this._btnGenerateReport.Text = "Generate";
            this._btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnGenerateReport.UseVisualStyleBackColor = true;
            this._btnGenerateReport.Click += new System.EventHandler(this.OnGenerateReportClick);
            // 
            // _btnExport
            // 
            this._btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExport.Image = ((System.Drawing.Image)(resources.GetObject("_btnExport.Image")));
            this._btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnExport.Location = new System.Drawing.Point(907, 2);
            this._btnExport.Name = "_btnExport";
            this._btnExport.Size = new System.Drawing.Size(75, 23);
            this._btnExport.TabIndex = 5;
            this._btnExport.Text = "Export  ";
            this._btnExport.UseVisualStyleBackColor = true;
            this._btnExport.Click += new System.EventHandler(this.OnExportDataClick);
            // 
            // _datetimeFrom
            // 
            this._datetimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._datetimeFrom.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this._datetimeFrom.Enabled = false;
            this._datetimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._datetimeFrom.Location = new System.Drawing.Point(395, 3);
            this._datetimeFrom.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this._datetimeFrom.Name = "_datetimeFrom";
            this._datetimeFrom.Size = new System.Drawing.Size(146, 20);
            this._datetimeFrom.TabIndex = 2;
            this._datetimeFrom.ValueChanged += new System.EventHandler(this.OnFromDateChanged);
            // 
            // _datetimeTo
            // 
            this._datetimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._datetimeTo.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this._datetimeTo.Enabled = false;
            this._datetimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._datetimeTo.Location = new System.Drawing.Point(547, 3);
            this._datetimeTo.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this._datetimeTo.Name = "_datetimeTo";
            this._datetimeTo.Size = new System.Drawing.Size(144, 20);
            this._datetimeTo.TabIndex = 3;
            this._datetimeTo.ValueChanged += new System.EventHandler(this.OnThruDateChanged);
            // 
            // _lblResultRowCount
            // 
            this._lblResultRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblResultRowCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this._lblResultRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblResultRowCount.Location = new System.Drawing.Point(708, 7);
            this._lblResultRowCount.Name = "_lblResultRowCount";
            this._lblResultRowCount.Size = new System.Drawing.Size(115, 13);
            this._lblResultRowCount.TabIndex = 16;
            this._lblResultRowCount.Text = "Total Rows: 0";
            this._lblResultRowCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _comboSearchList
            // 
            this._comboSearchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._comboSearchList.DisplayMember = "DisplayName";
            this._comboSearchList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboSearchList.FormattingEnabled = true;
            this._comboSearchList.Location = new System.Drawing.Point(139, 1);
            this._comboSearchList.Name = "_comboSearchList";
            this._comboSearchList.Size = new System.Drawing.Size(250, 21);
            this._comboSearchList.TabIndex = 1;
            this._comboSearchList.SelectedIndexChanged += new System.EventHandler(this.OnListOptionSelected);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this._comboSearchList);
            this.Controls.Add(this._lblResultRowCount);
            this.Controls.Add(this._datetimeTo);
            this.Controls.Add(this._datetimeFrom);
            this.Controls.Add(this._btnExport);
            this.Controls.Add(this._btnGenerateReport);
            this.Controls.Add(this._lblLastRefreshed);
            this.Controls.Add(this._gridResults);
            this.Controls.Add(this._btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Report - {0}";
            ((System.ComponentModel.ISupportInitialize)(this._gridResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.DataGridView _gridResults;
        private System.Windows.Forms.Label _lblLastRefreshed;
        private System.Windows.Forms.Button _btnGenerateReport;
        private System.Windows.Forms.Button _btnExport;
        private System.Windows.Forms.DateTimePicker _datetimeFrom;
        private System.Windows.Forms.DateTimePicker _datetimeTo;
        private System.Windows.Forms.Label _lblResultRowCount;
        private System.Windows.Forms.ComboBox _comboSearchList;
    }
}