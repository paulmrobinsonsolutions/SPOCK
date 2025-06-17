namespace SPOCK
{
    partial class AboutCustomReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutCustomReports));
            this._lblLastRefreshed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._linkLabelOpenCustomReportFolder = new System.Windows.Forms.LinkLabel();
            this._btnExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._txtExampleQuery = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lblLastRefreshed
            // 
            this._lblLastRefreshed.Location = new System.Drawing.Point(12, 9);
            this._lblLastRefreshed.Name = "_lblLastRefreshed";
            this._lblLastRefreshed.Size = new System.Drawing.Size(569, 40);
            this._lblLastRefreshed.TabIndex = 1;
            this._lblLastRefreshed.Text = resources.GetString("_lblLastRefreshed.Text");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test    = --Test\r\nStaging = --Staging\r\nDev     = Not supported due to risk potent" +
    "ial";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(574, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "3. Save your .sql file to the \"CustomSQL\" folder indicated below.";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Example:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(480, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "\"My_Awesome_Reports\" will display as a report menu option of \"My Awesome Report\"";
            // 
            // _linkLabelOpenCustomReportFolder
            // 
            this._linkLabelOpenCustomReportFolder.AutoSize = true;
            this._linkLabelOpenCustomReportFolder.Location = new System.Drawing.Point(34, 259);
            this._linkLabelOpenCustomReportFolder.Name = "_linkLabelOpenCustomReportFolder";
            this._linkLabelOpenCustomReportFolder.Size = new System.Drawing.Size(56, 13);
            this._linkLabelOpenCustomReportFolder.TabIndex = 9;
            this._linkLabelOpenCustomReportFolder.TabStop = true;
            this._linkLabelOpenCustomReportFolder.Text = "Click Here";
            this._linkLabelOpenCustomReportFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnOpenCustomReportsFolderClick);
            // 
            // _btnExit
            // 
            this._btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExit.ForeColor = System.Drawing.Color.Red;
            this._btnExit.Location = new System.Drawing.Point(511, 529);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 90;
            this._btnExit.Text = "E&xit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.OnExitClick);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(492, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "to open the folder where your custom .sql should be saved";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 15);
            this.label3.TabIndex = 91;
            this.label3.Text = "NOTE: Underscores (\"_\") in the file name will be replaced with spaces. For those " +
    "who dislike spaces in file names.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(569, 29);
            this.label4.TabIndex = 92;
            this.label4.Text = "4. To enable the reporting controls (queue/process list options, date from and to" +
    ") the following must be specified in the .sql file *AND* must also be declared i" +
    "n the order outlined below.";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(557, 42);
            this.label10.TabIndex = 94;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(552, 15);
            this.label11.TabIndex = 95;
            this.label11.Text = "You may copy the below example sql to build from";
            // 
            // _txtExampleQuery
            // 
            this._txtExampleQuery.BackColor = System.Drawing.SystemColors.Menu;
            this._txtExampleQuery.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtExampleQuery.Location = new System.Drawing.Point(15, 299);
            this._txtExampleQuery.Multiline = true;
            this._txtExampleQuery.Name = "_txtExampleQuery";
            this._txtExampleQuery.Size = new System.Drawing.Size(571, 227);
            this._txtExampleQuery.TabIndex = 96;
            this._txtExampleQuery.Text = resources.GetString("_txtExampleQuery.Text");
            // 
            // AboutCustomReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(589, 555);
            this.Controls.Add(this._txtExampleQuery);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._linkLabelOpenCustomReportFolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblLastRefreshed);
            this.Name = "AboutCustomReports";
            this.Text = "About Custom Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblLastRefreshed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel _linkLabelOpenCustomReportFolder;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _txtExampleQuery;
    }
}