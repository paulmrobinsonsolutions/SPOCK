using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPOCK
{
    public partial class EmailAlertSettings : Form
    {
        public EmailAlertSettings()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            _comboFromMonday.DataSource = ListService.HOUR_OPTIONS();
            _comboToMonday.DataSource = ListService.HOUR_OPTIONS();
            _comboFromTuesday.DataSource = ListService.HOUR_OPTIONS();
            _comboToTuesday.DataSource = ListService.HOUR_OPTIONS();
            _comboFromWednesday.DataSource = ListService.HOUR_OPTIONS();
            _comboToWednesday.DataSource = ListService.HOUR_OPTIONS();
            _comboFromThursday.DataSource = ListService.HOUR_OPTIONS();
            _comboToThursday.DataSource = ListService.HOUR_OPTIONS();
            _comboFromFriday.DataSource = ListService.HOUR_OPTIONS();
            _comboToFriday.DataSource = ListService.HOUR_OPTIONS();
            _comboFromSaturday.DataSource = ListService.HOUR_OPTIONS();
            _comboToSaturday.DataSource = ListService.HOUR_OPTIONS();
            _comboFromSunday.DataSource = ListService.HOUR_OPTIONS();
            _comboToSunday.DataSource = ListService.HOUR_OPTIONS();

            /* check properties settings first, set to -1 as default */
            _comboFromMonday.SelectedIndex = -1;
            _comboToMonday.SelectedIndex = -1;
            _comboFromTuesday.SelectedIndex = -1;
            _comboToTuesday.SelectedIndex = -1;
            _comboFromWednesday.SelectedIndex = -1;
            _comboToWednesday.SelectedIndex = -1;
            _comboFromThursday.SelectedIndex = -1;
            _comboToThursday.SelectedIndex = -1;
            _comboFromFriday.SelectedIndex = -1;
            _comboToFriday.SelectedIndex = -1;
            _comboFromSaturday.SelectedIndex = -1;
            _comboToSaturday.SelectedIndex = -1;
            _comboFromSunday.SelectedIndex = -1;
            _comboToSunday.SelectedIndex = -1;

            _ckbEnableEmailAlerting.Checked = Properties.Settings.Default.EmailAlertingIsEnabled;
            EnableEmailAlerting(_ckbEnableEmailAlerting.Checked);

            // If email alerting is enabled 
            if (_ckbEnableEmailAlerting.Checked)
            {
                _txtEmailAddresses.Text = Properties.Settings.Default.EmailAlertEmailAddress;

                // Monday
                SetDayAlertingControls(Properties.Settings.Default.EmailAlertMonday,
                    _comboFromMonday, _comboToMonday, _ckbAllDayMonday);

                // Tuesday
                SetDayAlertingControls(Properties.Settings.Default.EmailAlertTuesday,
                    _comboFromTuesday, _comboToTuesday, _ckbAllDayTuesday);

                // Wednesday
                SetDayAlertingControls(Properties.Settings.Default.EmailAlertWednesday,
                    _comboFromWednesday, _comboToWednesday, _ckbAllDayWednesday);

                // Thursday
                SetDayAlertingControls(Properties.Settings.Default.EmailAlertThursday,
                    _comboFromThursday, _comboToThursday, _ckbAllDayThrsday);

                // Friday
                SetDayAlertingControls(Properties.Settings.Default.EmailAlertFriday,
                    _comboFromFriday, _comboToFriday, _ckbAllDayFriday);

                // Saturday
                SetDayAlertingControls(Properties.Settings.Default.EmailAlertSaturday,
                    _comboFromSaturday, _comboToSaturday, _ckbAllDaySaturday);

                // Sunday
                SetDayAlertingControls(Properties.Settings.Default.EmailAlertSunday,
                    _comboFromSunday, _comboToSunday, _ckbAllDaySunday);
            }

            string selectedErrorTypes = Properties.Settings.Default.EmailAlertingSelectedErrorTypes;

            // Load the error types
            int idx = 0;
            foreach (string errType in ListService.ERROR_TYPES())
            {
                _ckbListErrorTypes.Items.Add(errType);

                _ckbListErrorTypes.SetItemChecked(idx, selectedErrorTypes.Contains(errType));
                // Increment the counter index
                idx++;
            }
        }

        private void SetDayAlertingControls(string emailAlertDaySetting, ComboBox comboFromControl, ComboBox comboToControl, CheckBox checkboxAllDayControl)
        {
            // If no option was selected for that day then exit and move on
            if (string.IsNullOrEmpty(emailAlertDaySetting))
                return;

            if (emailAlertDaySetting == Constants.SETTING_ALL_DAY)
                checkboxAllDayControl.Checked = true;
            else
            {
                string[] splitValues = emailAlertDaySetting.Split(Constants.SETTING_DIVIDER_BAR);
                comboFromControl.SelectedValue = splitValues[0];
                comboToControl.SelectedValue = splitValues[1];
            }
        }

        private void PerformSave()
        {
            List<string> selectedErrorTypes = _ckbListErrorTypes.CheckedItems.Cast<string>().ToList();
            Properties.Settings.Default.EmailAlertingSelectedErrorTypes = 
                String.Join(Constants.SETTING_DIVIDER_BAR.ToString(), selectedErrorTypes);


            Properties.Settings.Default.EmailAlertingIsEnabled = _ckbEnableEmailAlerting.Checked;
            if (_ckbEnableEmailAlerting.Checked)
            {
                Properties.Settings.Default.EmailAlertEmailAddress = _txtEmailAddresses.Text;

                // Monday
                Properties.Settings.Default.EmailAlertMonday =
                    GetDaysSelectedAlertValue(_comboFromMonday, _comboToMonday, _ckbAllDayMonday);

                // Tuesday
                Properties.Settings.Default.EmailAlertTuesday =
                    GetDaysSelectedAlertValue(_comboFromTuesday, _comboToTuesday, _ckbAllDayTuesday);

                // Wednesday
                Properties.Settings.Default.EmailAlertWednesday =
                    GetDaysSelectedAlertValue(_comboFromWednesday, _comboToWednesday, _ckbAllDayWednesday);

                // Thursday
                Properties.Settings.Default.EmailAlertThursday =
                    GetDaysSelectedAlertValue(_comboFromThursday, _comboToThursday, _ckbAllDayThrsday);

                // Friday
                Properties.Settings.Default.EmailAlertFriday =
                    GetDaysSelectedAlertValue(_comboFromFriday, _comboToFriday, _ckbAllDayFriday);

                // Saturday
                Properties.Settings.Default.EmailAlertSaturday =
                    GetDaysSelectedAlertValue(_comboFromSaturday, _comboToSaturday, _ckbAllDaySaturday);

                // Sunday
                Properties.Settings.Default.EmailAlertSunday =
                    GetDaysSelectedAlertValue(_comboFromSunday, _comboToSunday, _ckbAllDaySunday);
            }

            Properties.Settings.Default.Save();
        }

        private string GetDaysSelectedAlertValue(ComboBox comboFromControl, ComboBox comboToControl, CheckBox checkboxAllDayControl)
        {
            string result = string.Empty;

            // If some selection was made then set accordingly. Otherwise the setting will be set to an empty string            
            if (checkboxAllDayControl.Checked)
                result = Constants.SETTING_ALL_DAY;
            else if (comboFromControl.SelectedIndex > 0 || comboToControl.SelectedIndex > 0)
            {
                result = string.Format("{0}{1}{2}", comboFromControl.SelectedValue
                                                , Constants.SETTING_DIVIDER_BAR
                                                , comboToControl.SelectedValue);
            }

            return result;
        }

        private void EnableEmailAlerting(bool doEnableEmailAlerting)
        {
            _groupEmailAlertSettings.Enabled = doEnableEmailAlerting;
            _errorValidEmail.Clear();
        }

        private void ValidateEmailAddress()
        {
            _errorValidEmail.Clear();
            bool emailIsValid = true;

            // If no email was specified (textbo is empty) then do nothing
            if (!string.IsNullOrEmpty(_txtEmailAddresses.Text))
            {
                try
                {
                    MailAddress m = new MailAddress(_txtEmailAddresses.Text);
                    if (!_txtEmailAddresses.Text.ToLowerInvariant().EndsWith(".com")
                            && !_txtEmailAddresses.Text.ToLowerInvariant().EndsWith(".net"))
                        emailIsValid = false;
                }
                catch (FormatException)
                {
                    emailIsValid = false;
                }
            }

            _btnExit.Enabled = emailIsValid;

            if (emailIsValid == false)
                _errorValidEmail.SetError(_txtEmailAddresses, "Invalid email.");
        }

        private void ClearControlsBasedOnAllDayChecked(bool isChecked, string checkboxTag)
        {
            if (!isChecked)
                return;

            switch (checkboxTag)
            {
                case "Monday":
                    _comboFromMonday.SelectedIndex = -1;
                    _comboToMonday.SelectedIndex = -1;
                    break;
                case "Tuesday":
                    _comboFromTuesday.SelectedIndex = -1;
                    _comboToTuesday.SelectedIndex = -1;
                    break;
                case "Wednesday":
                    _comboFromWednesday.SelectedIndex = -1;
                    _comboToWednesday.SelectedIndex = -1;
                    break;
                case "Thursday":
                    _comboFromThursday.SelectedIndex = -1;
                    _comboToThursday.SelectedIndex = -1;
                    break;
                case "Friday":
                    _comboFromFriday.SelectedIndex = -1;
                    _comboToFriday.SelectedIndex = -1;
                    break;
                case "Saturday":
                    _comboFromSaturday.SelectedIndex = -1;
                    _comboToSaturday.SelectedIndex = -1;
                    break;
                case "Sunday":
                    _comboFromSunday.SelectedIndex = -1;
                    _comboToSunday.SelectedIndex = -1;
                    break;
            }
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

        private void OnSaveClick(object sender, EventArgs e)
        {
            PerformSave();
            CloseForm();
        }

        private void OnEnableEmailSettingsChecked(object sender, EventArgs e)
        {
            EnableEmailAlerting(_ckbEnableEmailAlerting.Checked);
        }

        private void OnFocusLeave(object sender, EventArgs e)
        {
            ValidateEmailAddress();
        }

        private void OnAllDayCheckChanged(object sender, EventArgs e)
        {
            ClearControlsBasedOnAllDayChecked(((CheckBox)sender).Checked, ((CheckBox)sender).Tag.ToString());
        }
    }
}
