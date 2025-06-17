using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPOCK
{
    public static class PingLatency
    {
        public static void PerformPing(string ipAddress)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(ipAddress, timeout, buffer, options);

            StringBuilder str = new StringBuilder();
            if (reply.Status == IPStatus.Success)
            {
                str.Append("Address: " + reply.Address.ToString() + Environment.NewLine);
                str.Append("RoundTrip time: " + reply.RoundtripTime + Environment.NewLine);
                str.Append("Time to live: " + reply.Options.Ttl + Environment.NewLine);
                str.Append("Don't fragment: " + reply.Options.DontFragment + Environment.NewLine);
                str.Append("Buffer size: " + reply.Buffer.Length);
            }

            // If no results then output some informational message
            if (string.IsNullOrEmpty(str.ToString()))
                str.Append("No reply message was received. This cannot be good...");

            MessageBox.Show(str.ToString(), "Ping Reply Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
