using System;
using System.Web;
using System.Windows.Forms;

namespace SPOCK
{
    public partial class WebViewer : Form
    {
        public WebViewer()
        {
            InitializeComponent();
            LoadWebPage();
        }

        private void LoadWebPage()
        {
            /// RSS feeds reference: https://www.c-sharpcorner.com/article/read-rss-feed-using-mvc/

            string rssData = RssFeedService.GetUrlResponseText(Constants.WEB_HISTORY_RSS);
            /// Remove when testing is over!!
            //string rssData = File.ReadAllText(@"C:\Users\robinpm\OneDrive - National Grid\Documents\Visual Studio Projects\SPOCK\SPOCK\XMLFile.xml");
            string data = HttpUtility.HtmlDecode(rssData);

            // Begin stripping away text since XML is a struggle
            data = data.Replace(Environment.NewLine, string.Empty);
            data = data.Substring(data.IndexOf("item") + 5);
            data = data.Substring(0, data.IndexOf(@"</description") + 13);
            data = data.Substring(data.IndexOf("<a"));
            data = data.Replace("h4", "strong");
            data = data.Replace("<p", "<div style='padding-top: 8px;'");
            data = data.Replace("</p>", "</div>");

            // Remove "more" links. No need to brought down a rabbit a hole while one should be working...
            data = RemoveLinkText(data, "more historical");
            data = RemoveLinkText(data, "more famous birthdays");
            data = RemoveLinkText(data, "more famous deaths");

            // Wrap it in better style
            data = string.Format(@"<div style='font-size: smaller; font-family: tahoma; background-color: whitesmoke';>{0}</div>", data);

            _webBrowser.DocumentText = data;
        }

        private string RemoveLinkText(string data, string findText)
        {
            int startIdx = data.ToLower().IndexOf(findText.ToLower());
            int endIdx = 0;
            if (startIdx > 1)
            {
                startIdx = data.IndexOf("<a", startIdx - 100);
                endIdx = data.IndexOf("</div>", startIdx);

                if (endIdx > 0)
                {
                    string textToReplace = data.Substring(startIdx, (endIdx - startIdx) + 6);
                    data = data.Replace(textToReplace, "</br>");
                }
            }

            return data;
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
