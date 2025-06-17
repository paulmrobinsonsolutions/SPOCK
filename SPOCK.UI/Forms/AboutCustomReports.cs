using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPOCK
{
    public partial class AboutCustomReports : Form
    {
        public AboutCustomReports()
        {
            InitializeComponent();
        }

        private void OnOpenCustomReportsFolderClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LocalService.OpenCustomReportsFolder();
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
