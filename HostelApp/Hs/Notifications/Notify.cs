using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Windows.Forms;
using System.Net.Http;

namespace HostelApp.Hs.Notifications
{
    public partial class xfrmNotify : DevExpress.XtraEditors.XtraForm
    {
      

        public xfrmNotify()
        {
            InitializeComponent();
        }

        private void Notify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHostelRoomAllocatorDataSet.vwHrPeoples' table. You can move, or remove it, as needed.
            //this.vwHrPeoplesTableAdapter.Fill(this.dbHostelRoomAllocatorDataSet.vwHrPeoples);
            GetData();
            DisplayData();
        }

        private void GetData()
        {
            try
            {
                int previousSelectedRowHandle = gdvMain.FocusedRowHandle; // Save the previously selected row
                SqlCommand comdx = new SqlCommand("select * from vwHrPeoples", ConnectionStringParameters.connStrx);
                SqlDataAdapter dx = new SqlDataAdapter(comdx);
                DataTable dt = new DataTable();
                dx.Fill(dt);
                gdcMain.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }

        }
        private void DisplayData()
        {
            try
            {
                txtName.Text = gdvMain.GetFocusedRowCellValue("pplFirstName").ToString();
                txtMessage.Text = gdvMain.GetFocusedRowCellValue("pplLastName").ToString();
                txtMobileNumber.Text = gdvMain.GetFocusedRowCellValue("pplMobileNo").ToString();
                txtEmail.Text = gdvMain.GetFocusedRowCellValue("pplEmail").ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }


        private static void notification (string messages , string fname)
            {

        var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
            }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Empty;
        }

        

        private void gdvMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DisplayData();
        }

        private void gdcMain_Click(object sender, EventArgs e)
        {

        }
   
        private static async Task SendHubtelNotificationAsync(string messages, string phoneNumber)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Replace the placeholders with your Hubtel API credentials and sender ID
                    string clientId = "kcaliqtv";
                    string clientSecret = "rmiumzxp";
                    string senderId = "SalemInc";

                    var content = new FormUrlEncodedContent(new[]
                    {
                new KeyValuePair<string, string>("From", senderId),
                new KeyValuePair<string, string>("To", phoneNumber),
                new KeyValuePair<string, string>("Content", messages)
            });

                    var response = await client.PostAsync("https://smsc.hubtel.com/v1/messages/send?clientsecret=rmiumzxp&clientid=kcaliqtv", content);
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Check the response content to see if the message was sent successfully
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Hubtel notification sent successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to send Hubtel notification: {responseContent}");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending Hubtel notification: {ex.Message}");
            }
        }

        //public static async Task Notification(string messages, string phoneNumber)
        //{
        //    string clientId = "kcaliqtv";
        //    string clientSecret = "rmiumzxp";
        //    string senderId = "SalemInc";

        //    using (var client = new HttpClient())
        //    {
        //        var request = await client.GetAsync($"https://devp-sms03726-api.hubtel.com/v1/messages/send?clientid=clientI&clientsecret=string&from={phoneNumber}&to=string&content={messages}");
        //        var response = await request.Content.ReadAsStringAsync();

        //        Console.WriteLine(response);
        //    }
        //}

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                await SendHubtelNotificationAsync(txtMessage.Text, txtMobileNumber.Text);
                MessageBox.Show("Message Sent Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }
    }
}
