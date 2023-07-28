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
using System.Windows.Forms;
using static HostelApp.SystemChecks;

namespace HostelApp.Gen
{
    public partial class xfrmGenLogin : DevExpress.XtraEditors.XtraForm
    {
        private static string  userName;
        private int iter;

        public xfrmGenLogin()
        {
            InitializeComponent();
        }

        private void xfrmGenLogin_Load(object sender, EventArgs e)
        {

            userName = txtUsername.Text;
            iter = 0;
            CheckInternetConn();
            while (!CheckInternetConn())
            {
                var result = MessageBox.Show("No internet connection. Retry?", "Check Internet Connection", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    CloseApplication();
                    return;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                if (CheckData())
                {
                    if (isAccountLocked())
                    {
                        ShowAccountLockedMessage();
                        return;
                    }
                    else
                    {
                        ShowLoginSuccessMessage();
                        OpenMainForm();
                        return;
                    }
                }
                else if (iter == 3)
                {
                    if (isUserNamePresent())
                    {
                        LockAccount();
                        ShowAccountLockedMessage();
                    }
                    else
                    {
                        ShowTooManyAttemptsMessage();
                    }
                    CloseApplication();
                    return;
                }
                else if (!CheckData())
                {
                    var result = ShowInvalidCredentialsMessage();
                    if (result == DialogResult.Cancel)
                    {
                        CloseApplication();
                        return;
                    }
                    else if (result == DialogResult.Retry)
                    {
                        iter += 1;
                        ResetCredentials();
                    }
                }
            
        }


       //Functions
        private bool CheckData()
        {
            try
            {
                ConnectionStringParameters.OpenConnection();
                string query = "SELECT COUNT(*) FROM tblHrUsers WHERE usrUsername = @Username  AND usrPassword = @Password ";
                SqlCommand comdx = new SqlCommand(query, ConnectionStringParameters.connStrx);
                comdx.Parameters.AddWithValue("@Username", txtUsername.Text);
                comdx.Parameters.AddWithValue("@Password", txtPassword.Text);
                int count = (int)comdx.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
               return false;    
            }
            finally
            {
                ConnectionStringParameters.CloseConnection();
            }
        }

        private static bool isUserNamePresent()
        {
            ConnectionStringParameters.OpenConnection();
            string querry = "SELECT COUNT(*) FROM tblHrUsers where usrUserName = @userName";
            SqlCommand comdx = new SqlCommand(querry, ConnectionStringParameters.connStrx);
            comdx.Parameters.AddWithValue("@userName", userName);
            int count = (int)comdx.ExecuteScalar();
            return count > 0;
        }
        private  bool isAccountLocked()
        {
            ConnectionStringParameters.OpenConnection();
            string querry = "SELECT usrLocked FROM tblHrUsers where usrUserName = @userName and usrPassword = @Password";
            SqlCommand comdx = new SqlCommand(querry, ConnectionStringParameters.connStrx);
            comdx.Parameters.AddWithValue("@Username", txtUsername.Text); 
            comdx.Parameters.AddWithValue("@Password", txtPassword.Text);
            bool count = (bool)comdx.ExecuteScalar();
            return count;
        }

        private void LockAccount()
        {
            try
            {
                ConnectionStringParameters.OpenConnection();
                string query = "UPDATE tblHrUsers SET usrLocked = 1 WHERE Username = @Username";
                SqlCommand comdx = new SqlCommand(query, ConnectionStringParameters.connStrx);
                comdx.Parameters.AddWithValue("@Username", txtUsername.Text);
                comdx.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
                throw;
            }
        }

        private void ShowLoginSuccessMessage()
        {
            MessageBox.Show("Login Successful", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenMainForm()
        {
            Hide();
            xfrmMain Form = new xfrmMain();
            Form.Show();
        }

        private void ShowAccountLockedMessage()
        {
            MessageBox.Show("Account Locked. Contact Administrator", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowTooManyAttemptsMessage()
        {
            MessageBox.Show("Too many attempts. Please restart the app and try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DialogResult ShowInvalidCredentialsMessage()
        {
            return MessageBox.Show("Invalid Username or Password. Retry?", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void ResetCredentials()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void CloseApplication()
        {
            Close();
        }

        private void RememberMe()
        {
            if (ckeRememberMe.Checked)
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}