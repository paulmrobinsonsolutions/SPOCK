using System.IO;
using System.Net;
using System.Text;

namespace SPOCK
{
    public class RssFeedService
    {
        internal static string GetUrlResponseText(string url)
        {
            string resultData = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (string.IsNullOrEmpty(response.CharacterSet))
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                resultData = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }

            return resultData;
        }
    }
}
