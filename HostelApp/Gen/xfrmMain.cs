using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using HostelApp.HR;
using HostelApp.Hs;
using HostelApp.Hs.Notifications;

namespace HostelApp.Gen
{
    public partial class xfrmMain : DevExpress.XtraEditors.XtraForm
    {
        public static bool IsInternetAvailable()
        {
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send("8.8.8.8", 2000); // Ping Google's DNS server (8.8.8.8) with a timeout of 2000ms
                    return reply?.Status == IPStatus.Success; // Check if the ping was successful
                }
            }
            catch (PingException)
            {
                return false; // An exception occurred, indicating no internet connection
            }
        }

        public xfrmMain()
        {
            InitializeComponent();
        }

        private void aceHostelApplication_Click(object sender, EventArgs e)
        {
            xfrmHrHostelApplication newForm = new xfrmHrHostelApplication();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void aceEmps_Click(object sender, EventArgs e)
        {
            xfrmEmployeeRegistrationfrm newForm = new xfrmEmployeeRegistrationfrm();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            xfrmTelephoneDirectoryx newForm = new xfrmTelephoneDirectoryx();
            newForm.MdiParent = this;
            newForm.Show();
            
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            xfrmHostel newForm = new xfrmHostel();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            xfrmRoomx newForm = new xfrmRoomx();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void xfrmMain_Load(object sender, EventArgs e)
        {
            while (!IsInternetAvailable())
            {
                var result = MessageBox.Show("No internet connection. Retry?", "Check Internet Connection", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    this.Close(); // Close the application if the user chooses to cancel
                    return;
                }
            }

            // Internet connection is available
            try
            {
                ConnectionStringParameters.OpenConnection(); // Open the database connection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the database: " + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the application if there's an error connecting to the database
            }
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
           xfrmNotify newForm = new xfrmNotify();
            newForm.MdiParent = this;
            newForm.Show();

        }
    }
}