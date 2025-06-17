namespace SPOCK
{
    partial class NotificationSettings
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
            this._lblLastRefreshed = new System.Windows.Forms.Label();
            this._txtPriorHours = new System.Windows.Forms.TextBox();
            this._lblPriorHours = new System.Windows.Forms.Label();
            this._txtRefreshMinutes = new System.Windows.Forms.TextBox();
            this._lblRefreshMinutes = new System.Windows.Forms.Label();
            this._btnExit = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblLastRefreshed
            // 
            this._lblLastRefreshed.Location = new System.Drawing.Point(12, 9);
            this._lblLastRefreshed.Name = "_lblLastRefreshed";
            this._lblLastRefreshed.Size = new System.Drawing.Size(531, 34);
            this._lblLastRefreshed.TabIndex = 90;
            this._lblLastRefreshed.Text = "Use the below options to set the desired notifications you would like to recieve " +
    "in the desired time frame.";
            // 
            // _txtPriorHours
            // 
            this._txtPriorHours.Location = new System.Drawing.Point(15, 42);
            this._txtPriorHours.Name = "_txtPriorHours";
            this._txtPriorHours.Size = new System.Drawing.Size(33, 20);
            this._txtPriorHours.TabIndex = 1;
            // 
            // _lblPriorHours
            // 
            this._lblPriorHours.Location = new System.Drawing.Point(54, 42);
            this._lblPriorHours.Name = "_lblPriorHours";
            this._lblPriorHours.Size = new System.Drawing.Size(489, 30);
            this._lblPriorHours.TabIndex = 91;
            this._lblPriorHours.Text = "Enter the number of hours to pull data from. For example, 4 would indicate to pul" +
    "l data from 4 hours prior to the time the data refresh kicks off.";
            // 
            // _txtRefreshMinutes
            // 
            this._txtRefreshMinutes.Location = new System.Drawing.Point(15, 102);
            this._txtRefreshMinutes.Name = "_txtRefreshMinutes";
            this._txtRefreshMinutes.Size = new System.Drawing.Size(33, 20);
            this._txtRefreshMinutes.TabIndex = 2;
            // 
            // _lblRefreshMinutes
            // 
            this._lblRefreshMinutes.Location = new System.Drawing.Point(54, 102);
            this._lblRefreshMinutes.Name = "_lblRefreshMinutes";
            this._lblRefreshMinutes.Size = new System.Drawing.Size(489, 30);
            this._lblRefreshMinutes.TabIndex = 92;
            this._lblRefreshMinutes.Text = "Enter the refresh timespan recurrence. For example, 30 would indicate to perform " +
    "the refresh every 30 minutes while the application is open";
            // 
            // _btnExit
            // 
            this._btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExit.ForeColor = System.Drawing.Color.Green;
            this._btnExit.Location = new System.Drawing.Point(468, 160);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 93;
            this._btnExit.Text = "&Save";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnClose.ForeColor = System.Drawing.Color.Red;
            this._btnClose.Location = new System.Drawing.Point(387, 160);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 94;
            this._btnClose.Text = "&Cancel";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // NotificationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(555, 195);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._lblRefreshMinutes);
            this.Controls.Add(this._txtRefreshMinutes);
            this.Controls.Add(this._lblPriorHours);
            this.Controls.Add(this._txtPriorHours);
            this.Controls.Add(this._lblLastRefreshed);
            this.Name = "NotificationSettings";
            this.Text = "Alert Notification Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _lblLastRefreshed;
        private System.Windows.Forms.TextBox _txtPriorHours;
        private System.Windows.Forms.Label _lblPriorHours;
        private System.Windows.Forms.TextBox _txtRefreshMinutes;
        private System.Windows.Forms.Label _lblRefreshMinutes;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button _btnClose;
    }
}