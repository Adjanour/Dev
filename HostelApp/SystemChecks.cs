using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelApp
{
    internal class SystemChecks
    {

        public static bool CheckInternetConn()
        {
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send("8.8.8.8", 2000); // Ping Google's DNS server (8.8.8.8) with a timeout of 2000ms
                    return reply?.Status == IPStatus.Success; // Check if the ping was successful
                }
            }
            catch (PingException ex)
            {
                MessageBox.Show(ex.Message);
                return false; // An exception occurred, indicating no internet connection
            }

        }
    }
}
