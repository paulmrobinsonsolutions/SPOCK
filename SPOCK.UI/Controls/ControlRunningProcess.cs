using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPOCK
{
    public partial class ControlRunningProcess : UserControl
    {
        public ControlRunningProcess()
        {
            InitializeComponent();
        }

        public void SetControlValues(string processDesc, string timeRemaining, string estEndTime, int textboxLength)
        {
            _lblProcessDescription.Text = processDesc;
            _lblTimeRemaining.Text = timeRemaining;
            _lblEstEndTime.Text = estEndTime;
            _txtTimeSpan.Width = textboxLength;
        }
    }
}
