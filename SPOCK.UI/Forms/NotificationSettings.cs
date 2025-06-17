using System;
using System.Windows.Forms;

namespace SPOCK
{
    public partial class NotificationSettings : Form
    {
        public NotificationSettings()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            if (Properties.Settings.Default.DataRefreshPriorHourLimit == 0)
                _txtPriorHours.Text = "4"; // Set a default of 4 hours
            else
                _txtPriorHours.Text = Properties.Settings.Default.DataRefreshPriorHourLimit.ToString();

            if (Properties.Settings.Default.DataRefreshMinuteTimespan == 0)
                _txtRefreshMinutes.Text = "30"; // Set a default of 30 minutes
            else
                _txtRefreshMinutes.Text = Properties.Settings.Default.DataRefreshMinuteTimespan.ToString();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            int hourLimit = 0;
            int.TryParse(_txtPriorHours.Text, out hourLimit);
            Properties.Settings.Default.DataRefreshPriorHourLimit = hourLimit;

            int minuteRefresh = 0;
            int.TryParse(_txtRefreshMinutes.Text, out minuteRefresh);
            Properties.Settings.Default.DataRefreshMinuteTimespan = minuteRefresh;

            Properties.Settings.Default.Save();
            CloseForm();
        }

        private void CloseForm()
        {
            this.Dispose();
            this.Close();
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}
