using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Export.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelApp.HR
{
    public partial class xfrmTelephoneDirectoryx : DevExpress.XtraEditors.XtraForm
    {
        public xfrmTelephoneDirectoryx()
        {
            InitializeComponent();
        }
        private char irud;
        private int selectedGenderID;

        private void PopComboBox(string columnName, ComboBoxEdit controlName,string tableName)
        {
            try
            {
                ConnectionStringParameters.CloseConnection();
                ConnectionStringParameters.OpenConnection();
                string query = $"SELECT {columnName} FROM  {tableName}";
                SqlCommand comdx = new SqlCommand(query, ConnectionStringParameters.connStrx);
                comdx.Parameters.AddWithValue("@columnName", columnName);
                SqlDataReader reader = comdx.ExecuteReader();
                while (reader.Read())
                {
                    string value = reader[columnName].ToString();
                    controlName.Properties.Items.Add(value);
                }
                reader.Close();
                ConnectionStringParameters.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }

        private void EnableControls(Control control)
        {
            control.Enabled = true;

            // Recursively enable controls within container controls
            foreach (Control childControl in control.Controls)
            {
                EnableControls(childControl);
            }
        }

        private void SelectIDpkRow()
        {
            int idpkx = (int)gdvMain.GetFocusedRowCellValue("pplIDpk");
            int rowHandle = 0;
            object cellValue = gdvMain.GetRowCellValue(rowHandle, "pplIDpk");
            for (rowHandle = 0; rowHandle < gdvMain.DataRowCount; rowHandle++)
            {

                if (cellValue != null && cellValue.Equals(idpkx))
                {
                    gdvMain.ClearSelection();
                    gdvMain.SelectRow(rowHandle);
                    gdvMain.MoveBy(rowHandle);

                }
            }
        }

        private bool CheckIfDataExists(string pplFirstName, string pplLastName, string pplOtherName, string pplEmail, string pplMobileNo, string pplRemarks )
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM tblHrPeople WHERE pplFirstName = @pplFirstName and pplLastName = @pplLastName and pplOtherName = @pplOtherName and pplEmail = @pplEmail and pplMobileNo = @pplMobileNo and pplRmks = @pplRemarks ";
                ConnectionStringParameters.CloseConnection();
                ConnectionStringParameters.OpenConnection();
                SqlCommand comdx = new SqlCommand(sql, ConnectionStringParameters.connStrx);
                comdx.Parameters.AddWithValue("@pplLastName", pplLastName);
                comdx.Parameters.AddWithValue("@pplOtherName", pplOtherName);
                comdx.Parameters.AddWithValue("@pplFirstName", pplFirstName);
                comdx.Parameters.AddWithValue("@pplRemarks", pplRemarks);
                comdx.Parameters.AddWithValue("@pplMobileNo", pplMobileNo);
                comdx.Parameters.AddWithValue("@pplEmail", pplEmail);
                // Execute the command and retrieve the count value
                int count = (int)comdx.ExecuteScalar();
                // Return true if a matching record is found (count > 0), false otherwise
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
                return false;
            }
        }

        private void UpdateData()
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Update the  data?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ConnectionStringParameters.CloseConnection();
                    ConnectionStringParameters.OpenConnection();
                    int idpkx = (int)gdvMain.GetFocusedRowCellValue("pplIDpk");
                    SqlCommand comdx = new SqlCommand("UPDATE tblHrPeople SET pplFirstName = @pplFirstName , pplLastName = @pplLastName , pplOtherName = @pplOtherName , pplEmail = @pplEmail , pplMobileNo = @pplMobileNo , pplRmks = @pplRemarks , pplGenderIDfk = @pplGenderIDfk WHERE pplIDpk = @idpkx", ConnectionStringParameters.connStrx);
                   comdx.Parameters.AddWithValue("@pplLastName", txtLastName.Text);
                    comdx.Parameters.AddWithValue("@pplOtherName", txtOtherName.Text);
                    comdx.Parameters.AddWithValue("@pplFirstName", txtFirstName.Text);
                    comdx.Parameters.AddWithValue("@pplRemarks", txtRemarks.Text);
                    comdx.Parameters.AddWithValue("@pplMobileNo", txtMobileNo.Text);
                    comdx.Parameters.AddWithValue("@pplEmail", txtEmail.Text);
                    comdx.Parameters.AddWithValue("@pplGenderIDfk", selectedGenderID);
                    comdx.Parameters.AddWithValue("@idpkx", idpkx);
                    comdx.ExecuteNonQuery();
                    GetData();
                    DisplayData();
                    SelectIDpkRow();
                    MessageBox.Show("Updated Successfully", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }

        private void CheckData()
        {
            try
            {
                //System.Windows.Forms.TextBox activeTextBox = this.ActiveControl as System.Windows.Forms.TextBox;
                // Retrieve the data from the UI inputs
                //string newData = activeTextBox.Text;
                string pplLastName = txtLastName.Text;
                string pplFirstName = txtFirstName.Text;
                string pplGender = cbxGender.Text;
                string pplRemarks = txtRemarks.Text;
                string pplOtherName = txtOtherName.Text;
                string pplEmail = txtEmail.Text;
                string pplMobileNo = txtMobileNo.Text;


                // Query the database to check if the data already exists
                bool dataExists = CheckIfDataExists(pplFirstName, pplLastName, pplOtherName, pplEmail, pplMobileNo, pplRemarks);

                if (dataExists)
                {
                    // Display a message to the user indicating that the data already exists
                    MessageBox.Show("Data already exists in the database.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Proceed with updating the data in the database
                    UpdateData();

                }
            }
            catch (Exception ex)
                {
                    MessageBox.Show($"{ex.GetType()} says {ex.Message}");
                }
        }

        private void GetData()
        {
            try
            {
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
                txtFirstName.Text = gdvMain.GetFocusedRowCellValue("pplFirstName").ToString();
                txtLastName.Text = gdvMain.GetFocusedRowCellValue("pplLastName").ToString();
                txtOtherName.Text = gdvMain.GetFocusedRowCellValue("pplOtherName").ToString();
                cbxGender.Text = gdvMain.GetFocusedRowCellValue("gndName").ToString();
                txtRemarks.Text = gdvMain.GetFocusedRowCellValue("pplRmks").ToString();
                txtMobileNo.Text = gdvMain.GetFocusedRowCellValue("pplMobileNo").ToString();
                txtEmail.Text = gdvMain.GetFocusedRowCellValue("pplEmail").ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }

        private int GetID(string name, string tableName, string columnName, string dataColumnName)
        {
            int id = 0;

            // TODO: Query the database to retrieve the ID based on the name
            // Implement your database query here and assign the retrieved ID to id variable
            ConnectionStringParameters.CloseConnection();
            ConnectionStringParameters.OpenConnection();
            string query = $"SELECT {columnName} FROM {tableName} WHERE {dataColumnName} = @name";
            SqlCommand comdx = new SqlCommand(query, ConnectionStringParameters.connStrx);
            comdx.Parameters.AddWithValue("@name", name);
            SqlDataReader reader = comdx.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader[columnName]);
            }
            reader.Close();
            ConnectionStringParameters.CloseConnection();

            return id;
        }

        private void xfrmTelephoneDirectoryx_Load(object sender, EventArgs e)
        {
            irud = 'r';
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtOtherName.Enabled = false;
            cbxGender.Enabled = false;
            txtRemarks.Enabled = false;
            txtMobileNo.Enabled = false;
            txtEmail.Enabled = false;
            btnSave.Enabled = false;
            GetData();
            DisplayData();
            PopComboBox("gndName", cbxGender, "tblGenGenders");
            string selectedGender = cbxGender.Text;
            // Retrieve the corresponding gender ID from the database
            int genderID = GetID(selectedGender, "tblGenGenders", "gndIDpk", "gndName");

            // Store the gender ID
            selectedGenderID = genderID;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Are you sure you want to Clear the  data?", "Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string sql = "Delete From tblHrPeople where pplIDpk = " + gdvMain.GetFocusedRowCellValue("pplIDpk");
                    ConnectionStringParameters.CloseConnection();
                    ConnectionStringParameters.OpenConnection();
                    SqlCommand comdx = new SqlCommand("Delete From tblHrPeople where pplIDpk = " + gdvMain.GetFocusedRowCellValue("pplIDpk"), ConnectionStringParameters.connStrx);
                    comdx.ExecuteNonQuery();
                    GetData();
                }

            }
            catch
            {
                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (irud == 'u')
                {
                    EnableControls(this);
                    CheckData();
                }
                else if (irud == 'i')
                {
                    if (MessageBox.Show("Are you sure you want to save?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        ConnectionStringParameters.CloseConnection();
                        ConnectionStringParameters.OpenConnection();
                        SqlCommand comdx = new SqlCommand("Insert into tblHrPeople  (pplLastName,pplOtherName,pplFirstName,pplMobileNo,pplEmail,pplGenderIDfk,pplRmks) values ( @pplLastName,@pplOtherName,@pplFirstName,@pplMobileNo,@pplEmail,@pplGenderIDfk,@pplRmks)", ConnectionStringParameters.connStrx);
                        comdx.Parameters.AddWithValue("@pplLastName", txtLastName.Text);
                        comdx.Parameters.AddWithValue("@pplOtherName", txtOtherName.Text);
                        comdx.Parameters.AddWithValue("@pplFirstName", txtFirstName.Text);
                        comdx.Parameters.AddWithValue("@pplRmks", txtRemarks.Text);
                        comdx.Parameters.AddWithValue("@pplMobileNo", txtMobileNo.Text);
                        comdx.Parameters.AddWithValue("@pplEmail", txtEmail.Text);
                        comdx.Parameters.AddWithValue("@pplGenderIDfk", selectedGenderID);
                        comdx.ExecuteNonQuery();
                        GetData();
                        DisplayData();
                        SelectIDpkRow();
                        MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }

        private void gdcMain_Click(object sender, EventArgs e)
        {

        }

        private void gdvMain_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DisplayData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (irud == 'r')
                {
                    irud = 'i';
                    EnableControls(this);
                    btnSave.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnNew.Text = "Cancel";
                    btnNew.Image = HostelApp.Properties.Resources.delete_16x16;
                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    txtOtherName.Text = string.Empty;
                    cbxGender.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
                    txtMobileNo.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
                }
                else if (irud == 'i')
                {
                    irud = 'r';
                    GetData();
                    DisplayData();
                    btnSave.Enabled = false;
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnNew.Text = "New";
                    btnNew.Image = HostelApp.Properties.Resources.newemployee_16x16;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (irud == 'r')
            {
                irud = 'u';
                EnableControls(this);
                btnSave.Enabled = true;
                btnNew.Enabled = false;
                btnSave.Text = "Update";
                btnUpdate.Text = "Cancel";
                btnUpdate.Image = HostelApp.Properties.Resources.delete_16x16;

            }
            else if (irud == 'u')
            {
                irud = 'r';
                btnSave.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtOtherName.Enabled = false;
                cbxGender.Enabled = false;
                txtRemarks.Enabled = false;
                txtMobileNo.Enabled = false;
                txtEmail.Enabled = false;
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                btnSave.Text = "Save";
                btnUpdate.Text = "Edit";
                btnUpdate.Image = HostelApp.Properties.Resources.edit_16x16;


            }
        }
        
        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedGender = comboBox.SelectedItem.ToString();

            // Retrieve the corresponding gender ID from the database
            int genderID = GetID(selectedGender, "tblGenGenders", "gndIDpk","gndName");

            // Store the gender ID
            selectedGenderID = genderID;
        }


    }
}