namespace SPOCK
{
    partial class ControlRunningProcess
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblProcessDescription = new System.Windows.Forms.Label();
            this._lblTimeRemaining = new System.Windows.Forms.Label();
            this._lblEstEndTime = new System.Windows.Forms.Label();
            this._txtTimeSpan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lblProcessDescription
            // 
            this._lblProcessDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this._lblProcessDescription.Location = new System.Drawing.Point(0, -1);
            this._lblProcessDescription.Name = "_lblProcessDescription";
            this._lblProcessDescription.Size = new System.Drawing.Size(200, 16);
            this._lblProcessDescription.TabIndex = 0;
            this._lblProcessDescription.Text = "Process_Name";
            // 
            // _lblTimeRemaining
            // 
            this._lblTimeRemaining.BackColor = System.Drawing.Color.WhiteSmoke;
            this._lblTimeRemaining.Location = new System.Drawing.Point(202, -1);
            this._lblTimeRemaining.Name = "_lblTimeRemaining";
            this._lblTimeRemaining.Size = new System.Drawing.Size(60, 16);
            this._lblTimeRemaining.TabIndex = 1;
            this._lblTimeRemaining.Text = "10 h 55 m";
            this._lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblEstEndTime
            // 
            this._lblEstEndTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this._lblEstEndTime.Location = new System.Drawing.Point(265, -1);
            this._lblEstEndTime.Name = "_lblEstEndTime";
            this._lblEstEndTime.Size = new System.Drawing.Size(60, 16);
            this._lblEstEndTime.TabIndex = 2;
            this._lblEstEndTime.Text = "hh:mm pm";
            this._lblEstEndTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _txtTimeSpan
            // 
            this._txtTimeSpan.BackColor = System.Drawing.Color.LightSteelBlue;
            this._txtTimeSpan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtTimeSpan.Cursor = System.Windows.Forms.Cursors.No;
            this._txtTimeSpan.Location = new System.Drawing.Point(327, 0);
            this._txtTimeSpan.Name = "_txtTimeSpan";
            this._txtTimeSpan.Size = new System.Drawing.Size(468, 13);
            this._txtTimeSpan.TabIndex = 3;
            // 
            // ControlRunningProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._txtTimeSpan);
            this.Controls.Add(this._lblEstEndTime);
            this.Controls.Add(this._lblTimeRemaining);
            this.Controls.Add(this._lblProcessDescription);
            this.Name = "ControlRunningProcess";
            this.Size = new System.Drawing.Size(800, 13);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblProcessDescription;
        private System.Windows.Forms.Label _lblTimeRemaining;
        private System.Windows.Forms.Label _lblEstEndTime;
        private System.Windows.Forms.TextBox _txtTimeSpan;
    }
}
