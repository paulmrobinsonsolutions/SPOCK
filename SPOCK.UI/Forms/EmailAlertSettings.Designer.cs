namespace SPOCK
{
    partial class EmailAlertSettings
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
            this.components = new System.ComponentModel.Container();
            this._btnClose = new System.Windows.Forms.Button();
            this._btnExit = new System.Windows.Forms.Button();
            this._lblLastRefreshed = new System.Windows.Forms.Label();
            this._lblEmailAddresses = new System.Windows.Forms.Label();
            this._txtEmailAddresses = new System.Windows.Forms.TextBox();
            this._lblDaysOfWeekAlertingDesc = new System.Windows.Forms.Label();
            this._lblMonday = new System.Windows.Forms.Label();
            this._lblTuesday = new System.Windows.Forms.Label();
            this._lblWednesday = new System.Windows.Forms.Label();
            this._lblThursday = new System.Windows.Forms.Label();
            this._lblFriday = new System.Windows.Forms.Label();
            this._lblSaturday = new System.Windows.Forms.Label();
            this._lblSunday = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._comboFromMonday = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this._comboToMonday = new System.Windows.Forms.ComboBox();
            this._ckbAllDayMonday = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this._ckbAllDayTuesday = new System.Windows.Forms.CheckBox();
            this._comboToTuesday = new System.Windows.Forms.ComboBox();
            this._comboFromTuesday = new System.Windows.Forms.ComboBox();
            this._ckbAllDayWednesday = new System.Windows.Forms.CheckBox();
            this._comboToWednesday = new System.Windows.Forms.ComboBox();
            this._comboFromWednesday = new System.Windows.Forms.ComboBox();
            this._ckbAllDayThrsday = new System.Windows.Forms.CheckBox();
            this._comboToThursday = new System.Windows.Forms.ComboBox();
            this._comboFromThursday = new System.Windows.Forms.ComboBox();
            this._ckbAllDayFriday = new System.Windows.Forms.CheckBox();
            this._comboToFriday = new System.Windows.Forms.ComboBox();
            this._comboFromFriday = new System.Windows.Forms.ComboBox();
            this._ckbAllDaySaturday = new System.Windows.Forms.CheckBox();
            this._comboToSaturday = new System.Windows.Forms.ComboBox();
            this._comboFromSaturday = new System.Windows.Forms.ComboBox();
            this._ckbAllDaySunday = new System.Windows.Forms.CheckBox();
            this._comboToSunday = new System.Windows.Forms.ComboBox();
            this._comboFromSunday = new System.Windows.Forms.ComboBox();
            this._groupEmailAlertSettings = new System.Windows.Forms.GroupBox();
            this._lblEmailMultipleEntries = new System.Windows.Forms.Label();
            this._lblSelectErrorTypes = new System.Windows.Forms.Label();
            this._ckbListErrorTypes = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this._ckbEnableEmailAlerting = new System.Windows.Forms.CheckBox();
            this._errorValidEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this._groupEmailAlertSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorValidEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnClose.ForeColor = System.Drawing.Color.Red;
            this._btnClose.Location = new System.Drawing.Point(408, 415);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 30;
            this._btnClose.Text = "&Cancel";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // _btnExit
            // 
            this._btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExit.ForeColor = System.Drawing.Color.Green;
            this._btnExit.Location = new System.Drawing.Point(489, 415);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 31;
            this._btnExit.Text = "&Save";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // _lblLastRefreshed
            // 
            this._lblLastRefreshed.Enabled = false;
            this._lblLastRefreshed.Location = new System.Drawing.Point(12, 9);
            this._lblLastRefreshed.Name = "_lblLastRefreshed";
            this._lblLastRefreshed.Size = new System.Drawing.Size(531, 34);
            this._lblLastRefreshed.TabIndex = 80;
            this._lblLastRefreshed.Text = "Use the below options to set the desired alerting day and time constraints to be " +
    "alerted (email or SMS) based on the email address(es) specified";
            // 
            // _lblEmailAddresses
            // 
            this._lblEmailAddresses.Location = new System.Drawing.Point(9, 16);
            this._lblEmailAddresses.Name = "_lblEmailAddresses";
            this._lblEmailAddresses.Size = new System.Drawing.Size(505, 16);
            this._lblEmailAddresses.TabIndex = 81;
            this._lblEmailAddresses.Text = "Enter the email addresses below to receive notifications. MMS example, 1112223333" +
    "@mms.att.net";
            this._lblEmailAddresses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _txtEmailAddresses
            // 
            this._errorValidEmail.SetError(this._txtEmailAddresses, "A valid email must be entered.");
            this._txtEmailAddresses.Location = new System.Drawing.Point(12, 50);
            this._txtEmailAddresses.Name = "_txtEmailAddresses";
            this._txtEmailAddresses.Size = new System.Drawing.Size(502, 20);
            this._txtEmailAddresses.TabIndex = 1;
            this._txtEmailAddresses.Leave += new System.EventHandler(this.OnFocusLeave);
            // 
            // _lblDaysOfWeekAlertingDesc
            // 
            this._lblDaysOfWeekAlertingDesc.Location = new System.Drawing.Point(9, 87);
            this._lblDaysOfWeekAlertingDesc.Name = "_lblDaysOfWeekAlertingDesc";
            this._lblDaysOfWeekAlertingDesc.Size = new System.Drawing.Size(259, 17);
            this._lblDaysOfWeekAlertingDesc.TabIndex = 82;
            this._lblDaysOfWeekAlertingDesc.Text = "Enter the days and times that you want to be alerted.";
            this._lblDaysOfWeekAlertingDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblMonday
            // 
            this._lblMonday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblMonday.Location = new System.Drawing.Point(9, 163);
            this._lblMonday.Name = "_lblMonday";
            this._lblMonday.Size = new System.Drawing.Size(86, 18);
            this._lblMonday.TabIndex = 83;
            this._lblMonday.Text = "Monday";
            // 
            // _lblTuesday
            // 
            this._lblTuesday.Location = new System.Drawing.Point(9, 187);
            this._lblTuesday.Name = "_lblTuesday";
            this._lblTuesday.Size = new System.Drawing.Size(86, 18);
            this._lblTuesday.TabIndex = 102;
            this._lblTuesday.Text = "Tuesday";
            // 
            // _lblWednesday
            // 
            this._lblWednesday.Location = new System.Drawing.Point(9, 211);
            this._lblWednesday.Name = "_lblWednesday";
            this._lblWednesday.Size = new System.Drawing.Size(86, 18);
            this._lblWednesday.TabIndex = 103;
            this._lblWednesday.Text = "Wednesday";
            // 
            // _lblThursday
            // 
            this._lblThursday.Location = new System.Drawing.Point(9, 235);
            this._lblThursday.Name = "_lblThursday";
            this._lblThursday.Size = new System.Drawing.Size(86, 18);
            this._lblThursday.TabIndex = 104;
            this._lblThursday.Text = "Thursday";
            // 
            // _lblFriday
            // 
            this._lblFriday.Location = new System.Drawing.Point(9, 259);
            this._lblFriday.Name = "_lblFriday";
            this._lblFriday.Size = new System.Drawing.Size(86, 18);
            this._lblFriday.TabIndex = 105;
            this._lblFriday.Text = "Friday";
            // 
            // _lblSaturday
            // 
            this._lblSaturday.Location = new System.Drawing.Point(9, 283);
            this._lblSaturday.Name = "_lblSaturday";
            this._lblSaturday.Size = new System.Drawing.Size(86, 18);
            this._lblSaturday.TabIndex = 106;
            this._lblSaturday.Text = "Saturday";
            // 
            // _lblSunday
            // 
            this._lblSunday.Location = new System.Drawing.Point(9, 307);
            this._lblSunday.Name = "_lblSunday";
            this._lblSunday.Size = new System.Drawing.Size(86, 18);
            this._lblSunday.TabIndex = 107;
            this._lblSunday.Text = "Sunday";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(9, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 108;
            this.label8.Text = "Day of Week";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(101, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 109;
            this.label9.Text = "Before";
            // 
            // _comboFromMonday
            // 
            this._comboFromMonday.DisplayMember = "Label";
            this._comboFromMonday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFromMonday.FormattingEnabled = true;
            this._comboFromMonday.Location = new System.Drawing.Point(104, 162);
            this._comboFromMonday.Name = "_comboFromMonday";
            this._comboFromMonday.Size = new System.Drawing.Size(55, 21);
            this._comboFromMonday.TabIndex = 2;
            this._comboFromMonday.ValueMember = "Value";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(165, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 111;
            this.label10.Text = "After";
            // 
            // _comboToMonday
            // 
            this._comboToMonday.DisplayMember = "Label";
            this._comboToMonday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboToMonday.FormattingEnabled = true;
            this._comboToMonday.Location = new System.Drawing.Point(165, 162);
            this._comboToMonday.Name = "_comboToMonday";
            this._comboToMonday.Size = new System.Drawing.Size(55, 21);
            this._comboToMonday.TabIndex = 3;
            this._comboToMonday.ValueMember = "Value";
            // 
            // _ckbAllDayMonday
            // 
            this._ckbAllDayMonday.AutoSize = true;
            this._ckbAllDayMonday.Location = new System.Drawing.Point(229, 165);
            this._ckbAllDayMonday.Name = "_ckbAllDayMonday";
            this._ckbAllDayMonday.Size = new System.Drawing.Size(15, 14);
            this._ckbAllDayMonday.TabIndex = 4;
            this._ckbAllDayMonday.Tag = "Monday";
            this._ckbAllDayMonday.UseVisualStyleBackColor = true;
            this._ckbAllDayMonday.CheckedChanged += new System.EventHandler(this.OnAllDayCheckChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(226, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 114;
            this.label11.Text = "All Day?";
            // 
            // _ckbAllDayTuesday
            // 
            this._ckbAllDayTuesday.AutoSize = true;
            this._ckbAllDayTuesday.Location = new System.Drawing.Point(229, 189);
            this._ckbAllDayTuesday.Name = "_ckbAllDayTuesday";
            this._ckbAllDayTuesday.Size = new System.Drawing.Size(15, 14);
            this._ckbAllDayTuesday.TabIndex = 7;
            this._ckbAllDayTuesday.Tag = "Tuesday";
            this._ckbAllDayTuesday.UseVisualStyleBackColor = true;
            this._ckbAllDayTuesday.CheckedChanged += new System.EventHandler(this.OnAllDayCheckChanged);
            // 
            // _comboToTuesday
            // 
            this._comboToTuesday.DisplayMember = "Label";
            this._comboToTuesday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboToTuesday.FormattingEnabled = true;
            this._comboToTuesday.Location = new System.Drawing.Point(165, 186);
            this._comboToTuesday.Name = "_comboToTuesday";
            this._comboToTuesday.Size = new System.Drawing.Size(55, 21);
            this._comboToTuesday.TabIndex = 6;
            this._comboToTuesday.ValueMember = "Value";
            // 
            // _comboFromTuesday
            // 
            this._comboFromTuesday.DisplayMember = "Label";
            this._comboFromTuesday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFromTuesday.FormattingEnabled = true;
            this._comboFromTuesday.Location = new System.Drawing.Point(104, 186);
            this._comboFromTuesday.Name = "_comboFromTuesday";
            this._comboFromTuesday.Size = new System.Drawing.Size(55, 21);
            this._comboFromTuesday.TabIndex = 5;
            this._comboFromTuesday.ValueMember = "Value";
            // 
            // _ckbAllDayWednesday
            // 
            this._ckbAllDayWednesday.AutoSize = true;
            this._ckbAllDayWednesday.Location = new System.Drawing.Point(229, 213);
            this._ckbAllDayWednesday.Name = "_ckbAllDayWednesday";
            this._ckbAllDayWednesday.Size = new System.Drawing.Size(15, 14);
            this._ckbAllDayWednesday.TabIndex = 10;
            this._ckbAllDayWednesday.Tag = "Wednesday";
            this._ckbAllDayWednesday.UseVisualStyleBackColor = true;
            this._ckbAllDayWednesday.CheckedChanged += new System.EventHandler(this.OnAllDayCheckChanged);
            // 
            // _comboToWednesday
            // 
            this._comboToWednesday.DisplayMember = "Label";
            this._comboToWednesday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboToWednesday.FormattingEnabled = true;
            this._comboToWednesday.Location = new System.Drawing.Point(165, 210);
            this._comboToWednesday.Name = "_comboToWednesday";
            this._comboToWednesday.Size = new System.Drawing.Size(55, 21);
            this._comboToWednesday.TabIndex = 9;
            this._comboToWednesday.ValueMember = "Value";
            // 
            // _comboFromWednesday
            // 
            this._comboFromWednesday.DisplayMember = "Label";
            this._comboFromWednesday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFromWednesday.FormattingEnabled = true;
            this._comboFromWednesday.Location = new System.Drawing.Point(104, 210);
            this._comboFromWednesday.Name = "_comboFromWednesday";
            this._comboFromWednesday.Size = new System.Drawing.Size(55, 21);
            this._comboFromWednesday.TabIndex = 8;
            this._comboFromWednesday.ValueMember = "Value";
            // 
            // _ckbAllDayThrsday
            // 
            this._ckbAllDayThrsday.AutoSize = true;
            this._ckbAllDayThrsday.Location = new System.Drawing.Point(229, 237);
            this._ckbAllDayThrsday.Name = "_ckbAllDayThrsday";
            this._ckbAllDayThrsday.Size = new System.Drawing.Size(15, 14);
            this._ckbAllDayThrsday.TabIndex = 13;
            this._ckbAllDayThrsday.Tag = "Thursday";
            this._ckbAllDayThrsday.UseVisualStyleBackColor = true;
            this._ckbAllDayThrsday.CheckedChanged += new System.EventHandler(this.OnAllDayCheckChanged);
            // 
            // _comboToThursday
            // 
            this._comboToThursday.DisplayMember = "Label";
            this._comboToThursday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboToThursday.FormattingEnabled = true;
            this._comboToThursday.Location = new System.Drawing.Point(165, 234);
            this._comboToThursday.Name = "_comboToThursday";
            this._comboToThursday.Size = new System.Drawing.Size(55, 21);
            this._comboToThursday.TabIndex = 12;
            this._comboToThursday.ValueMember = "Value";
            // 
            // _comboFromThursday
            // 
            this._comboFromThursday.DisplayMember = "Label";
            this._comboFromThursday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFromThursday.FormattingEnabled = true;
            this._comboFromThursday.Location = new System.Drawing.Point(104, 234);
            this._comboFromThursday.Name = "_comboFromThursday";
            this._comboFromThursday.Size = new System.Drawing.Size(55, 21);
            this._comboFromThursday.TabIndex = 11;
            this._comboFromThursday.ValueMember = "Value";
            // 
            // _ckbAllDayFriday
            // 
            this._ckbAllDayFriday.AutoSize = true;
            this._ckbAllDayFriday.Location = new System.Drawing.Point(229, 261);
            this._ckbAllDayFriday.Name = "_ckbAllDayFriday";
            this._ckbAllDayFriday.Size = new System.Drawing.Size(15, 14);
            this._ckbAllDayFriday.TabIndex = 16;
            this._ckbAllDayFriday.Tag = "Friday";
            this._ckbAllDayFriday.UseVisualStyleBackColor = true;
            this._ckbAllDayFriday.CheckedChanged += new System.EventHandler(this.OnAllDayCheckChanged);
            // 
            // _comboToFriday
            // 
            this._comboToFriday.DisplayMember = "Label";
            this._comboToFriday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboToFriday.FormattingEnabled = true;
            this._comboToFriday.Location = new System.Drawing.Point(165, 258);
            this._comboToFriday.Name = "_comboToFriday";
            this._comboToFriday.Size = new System.Drawing.Size(55, 21);
            this._comboToFriday.TabIndex = 15;
            this._comboToFriday.ValueMember = "Value";
            // 
            // _comboFromFriday
            // 
            this._comboFromFriday.DisplayMember = "Label";
            this._comboFromFriday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFromFriday.FormattingEnabled = true;
            this._comboFromFriday.Location = new System.Drawing.Point(104, 258);
            this._comboFromFriday.Name = "_comboFromFriday";
            this._comboFromFriday.Size = new System.Drawing.Size(55, 21);
            this._comboFromFriday.TabIndex = 14;
            this._comboFromFriday.ValueMember = "Value";
            // 
            // _ckbAllDaySaturday
            // 
            this._ckbAllDaySaturday.AutoSize = true;
            this._ckbAllDaySaturday.Location = new System.Drawing.Point(229, 285);
            this._ckbAllDaySaturday.Name = "_ckbAllDaySaturday";
            this._ckbAllDaySaturday.Size = new System.Drawing.Size(15, 14);
            this._ckbAllDaySaturday.TabIndex = 19;
            this._ckbAllDaySaturday.Tag = "Saturday";
            this._ckbAllDaySaturday.UseVisualStyleBackColor = true;
            this._ckbAllDaySaturday.CheckedChanged += new System.EventHandler(this.OnAllDayCheckChanged);
            // 
            // _comboToSaturday
            // 
            this._comboToSaturday.DisplayMember = "Label";
            this._comboToSaturday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboToSaturday.FormattingEnabled = true;
            this._comboToSaturday.Location = new System.Drawing.Point(165, 282);
            this._comboToSaturday.Name = "_comboToSaturday";
            this._comboToSaturday.Size = new System.Drawing.Size(55, 21);
            this._comboToSaturday.TabIndex = 18;
            this._comboToSaturday.ValueMember = "Value";
            // 
            // _comboFromSaturday
            // 
            this._comboFromSaturday.DisplayMember = "Label";
            this._comboFromSaturday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFromSaturday.FormattingEnabled = true;
            this._comboFromSaturday.Location = new System.Drawing.Point(104, 282);
            this._comboFromSaturday.Name = "_comboFromSaturday";
            this._comboFromSaturday.Size = new System.Drawing.Size(55, 21);
            this._comboFromSaturday.TabIndex = 17;
            this._comboFromSaturday.ValueMember = "Value";
            // 
            // _ckbAllDaySunday
            // 
            this._ckbAllDaySunday.AutoSize = true;
            this._ckbAllDaySunday.Location = new System.Drawing.Point(229, 309);
            this._ckbAllDaySunday.Name = "_ckbAllDaySunday";
            this._ckbAllDaySunday.Size = new System.Drawing.Size(15, 14);
            this._ckbAllDaySunday.TabIndex = 22;
            this._ckbAllDaySunday.Tag = "Sunday";
            this._ckbAllDaySunday.UseVisualStyleBackColor = true;
            this._ckbAllDaySunday.CheckedChanged += new System.EventHandler(this.OnAllDayCheckChanged);
            // 
            // _comboToSunday
            // 
            this._comboToSunday.DisplayMember = "Label";
            this._comboToSunday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboToSunday.FormattingEnabled = true;
            this._comboToSunday.Location = new System.Drawing.Point(165, 306);
            this._comboToSunday.Name = "_comboToSunday";
            this._comboToSunday.Size = new System.Drawing.Size(55, 21);
            this._comboToSunday.TabIndex = 21;
            this._comboToSunday.ValueMember = "Value";
            // 
            // _comboFromSunday
            // 
            this._comboFromSunday.DisplayMember = "Label";
            this._comboFromSunday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFromSunday.FormattingEnabled = true;
            this._comboFromSunday.Location = new System.Drawing.Point(104, 306);
            this._comboFromSunday.Name = "_comboFromSunday";
            this._comboFromSunday.Size = new System.Drawing.Size(55, 21);
            this._comboFromSunday.TabIndex = 20;
            this._comboFromSunday.ValueMember = "Value";
            // 
            // _groupEmailAlertSettings
            // 
            this._groupEmailAlertSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupEmailAlertSettings.Controls.Add(this._lblEmailMultipleEntries);
            this._groupEmailAlertSettings.Controls.Add(this._lblSelectErrorTypes);
            this._groupEmailAlertSettings.Controls.Add(this._ckbListErrorTypes);
            this._groupEmailAlertSettings.Controls.Add(this.label1);
            this._groupEmailAlertSettings.Controls.Add(this._txtEmailAddresses);
            this._groupEmailAlertSettings.Controls.Add(this._lblEmailAddresses);
            this._groupEmailAlertSettings.Controls.Add(this._ckbAllDaySunday);
            this._groupEmailAlertSettings.Controls.Add(this._lblDaysOfWeekAlertingDesc);
            this._groupEmailAlertSettings.Controls.Add(this._comboToSunday);
            this._groupEmailAlertSettings.Controls.Add(this.label8);
            this._groupEmailAlertSettings.Controls.Add(this._comboFromSunday);
            this._groupEmailAlertSettings.Controls.Add(this.label9);
            this._groupEmailAlertSettings.Controls.Add(this._ckbAllDaySaturday);
            this._groupEmailAlertSettings.Controls.Add(this.label10);
            this._groupEmailAlertSettings.Controls.Add(this._comboToSaturday);
            this._groupEmailAlertSettings.Controls.Add(this.label11);
            this._groupEmailAlertSettings.Controls.Add(this._comboFromSaturday);
            this._groupEmailAlertSettings.Controls.Add(this._comboFromMonday);
            this._groupEmailAlertSettings.Controls.Add(this._ckbAllDayFriday);
            this._groupEmailAlertSettings.Controls.Add(this._lblMonday);
            this._groupEmailAlertSettings.Controls.Add(this._comboToFriday);
            this._groupEmailAlertSettings.Controls.Add(this._lblTuesday);
            this._groupEmailAlertSettings.Controls.Add(this._comboFromFriday);
            this._groupEmailAlertSettings.Controls.Add(this._lblWednesday);
            this._groupEmailAlertSettings.Controls.Add(this._ckbAllDayThrsday);
            this._groupEmailAlertSettings.Controls.Add(this._lblThursday);
            this._groupEmailAlertSettings.Controls.Add(this._comboToThursday);
            this._groupEmailAlertSettings.Controls.Add(this._lblFriday);
            this._groupEmailAlertSettings.Controls.Add(this._comboFromThursday);
            this._groupEmailAlertSettings.Controls.Add(this._lblSaturday);
            this._groupEmailAlertSettings.Controls.Add(this._ckbAllDayWednesday);
            this._groupEmailAlertSettings.Controls.Add(this._lblSunday);
            this._groupEmailAlertSettings.Controls.Add(this._comboToWednesday);
            this._groupEmailAlertSettings.Controls.Add(this._comboToMonday);
            this._groupEmailAlertSettings.Controls.Add(this._comboFromWednesday);
            this._groupEmailAlertSettings.Controls.Add(this._ckbAllDayMonday);
            this._groupEmailAlertSettings.Controls.Add(this._ckbAllDayTuesday);
            this._groupEmailAlertSettings.Controls.Add(this._comboFromTuesday);
            this._groupEmailAlertSettings.Controls.Add(this._comboToTuesday);
            this._groupEmailAlertSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._groupEmailAlertSettings.ForeColor = System.Drawing.Color.Black;
            this._groupEmailAlertSettings.Location = new System.Drawing.Point(24, 72);
            this._groupEmailAlertSettings.Name = "_groupEmailAlertSettings";
            this._groupEmailAlertSettings.Size = new System.Drawing.Size(540, 337);
            this._groupEmailAlertSettings.TabIndex = 115;
            this._groupEmailAlertSettings.TabStop = false;
            this._groupEmailAlertSettings.Text = "Email Alert Settings";
            // 
            // _lblEmailMultipleEntries
            // 
            this._lblEmailMultipleEntries.Location = new System.Drawing.Point(9, 32);
            this._lblEmailMultipleEntries.Name = "_lblEmailMultipleEntries";
            this._lblEmailMultipleEntries.Size = new System.Drawing.Size(505, 15);
            this._lblEmailMultipleEntries.TabIndex = 118;
            this._lblEmailMultipleEntries.Text = "*NOTE: Use semicolon to separate multiple addresses";
            this._lblEmailMultipleEntries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblSelectErrorTypes
            // 
            this._lblSelectErrorTypes.Location = new System.Drawing.Point(313, 107);
            this._lblSelectErrorTypes.Name = "_lblSelectErrorTypes";
            this._lblSelectErrorTypes.Size = new System.Drawing.Size(221, 19);
            this._lblSelectErrorTypes.TabIndex = 117;
            this._lblSelectErrorTypes.Text = "Select the type of errors to be alerted of";
            this._lblSelectErrorTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _ckbListErrorTypes
            // 
            this._ckbListErrorTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ckbListErrorTypes.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ckbListErrorTypes.CheckOnClick = true;
            this._ckbListErrorTypes.FormattingEnabled = true;
            this._ckbListErrorTypes.Location = new System.Drawing.Point(313, 132);
            this._ckbListErrorTypes.Name = "_ckbListErrorTypes";
            this._ckbListErrorTypes.Size = new System.Drawing.Size(221, 199);
            this._ckbListErrorTypes.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 115;
            this.label1.Text = "Example. Selecting Friday Before 7 AM means you want to get message prior to 7 AM" +
    "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _ckbEnableEmailAlerting
            // 
            this._ckbEnableEmailAlerting.AutoSize = true;
            this._ckbEnableEmailAlerting.Location = new System.Drawing.Point(15, 47);
            this._ckbEnableEmailAlerting.Name = "_ckbEnableEmailAlerting";
            this._ckbEnableEmailAlerting.Size = new System.Drawing.Size(163, 17);
            this._ckbEnableEmailAlerting.TabIndex = 0;
            this._ckbEnableEmailAlerting.Text = "Enable email / SMS alerting?";
            this._ckbEnableEmailAlerting.UseVisualStyleBackColor = true;
            this._ckbEnableEmailAlerting.CheckedChanged += new System.EventHandler(this.OnEnableEmailSettingsChecked);
            // 
            // _errorValidEmail
            // 
            this._errorValidEmail.ContainerControl = this;
            // 
            // EmailAlertSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(576, 448);
            this.Controls.Add(this._ckbEnableEmailAlerting);
            this.Controls.Add(this._groupEmailAlertSettings);
            this.Controls.Add(this._lblLastRefreshed);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnExit);
            this.MinimumSize = new System.Drawing.Size(575, 478);
            this.Name = "EmailAlertSettings";
            this.Text = "Email Alert Settings";
            this._groupEmailAlertSettings.ResumeLayout(false);
            this._groupEmailAlertSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorValidEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Label _lblLastRefreshed;
        private System.Windows.Forms.Label _lblEmailAddresses;
        private System.Windows.Forms.TextBox _txtEmailAddresses;
        private System.Windows.Forms.Label _lblDaysOfWeekAlertingDesc;
        private System.Windows.Forms.Label _lblMonday;
        private System.Windows.Forms.Label _lblTuesday;
        private System.Windows.Forms.Label _lblWednesday;
        private System.Windows.Forms.Label _lblThursday;
        private System.Windows.Forms.Label _lblFriday;
        private System.Windows.Forms.Label _lblSaturday;
        private System.Windows.Forms.Label _lblSunday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox _comboFromMonday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox _comboToMonday;
        private System.Windows.Forms.CheckBox _ckbAllDayMonday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox _ckbAllDayTuesday;
        private System.Windows.Forms.ComboBox _comboToTuesday;
        private System.Windows.Forms.ComboBox _comboFromTuesday;
        private System.Windows.Forms.CheckBox _ckbAllDayWednesday;
        private System.Windows.Forms.ComboBox _comboToWednesday;
        private System.Windows.Forms.ComboBox _comboFromWednesday;
        private System.Windows.Forms.CheckBox _ckbAllDayThrsday;
        private System.Windows.Forms.ComboBox _comboToThursday;
        private System.Windows.Forms.ComboBox _comboFromThursday;
        private System.Windows.Forms.CheckBox _ckbAllDayFriday;
        private System.Windows.Forms.ComboBox _comboToFriday;
        private System.Windows.Forms.ComboBox _comboFromFriday;
        private System.Windows.Forms.CheckBox _ckbAllDaySaturday;
        private System.Windows.Forms.ComboBox _comboToSaturday;
        private System.Windows.Forms.ComboBox _comboFromSaturday;
        private System.Windows.Forms.CheckBox _ckbAllDaySunday;
        private System.Windows.Forms.ComboBox _comboToSunday;
        private System.Windows.Forms.ComboBox _comboFromSunday;
        private System.Windows.Forms.GroupBox _groupEmailAlertSettings;
        private System.Windows.Forms.CheckBox _ckbEnableEmailAlerting;
        private System.Windows.Forms.ErrorProvider _errorValidEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblSelectErrorTypes;
        private System.Windows.Forms.CheckedListBox _ckbListErrorTypes;
        private System.Windows.Forms.Label _lblEmailMultipleEntries;
    }
}