using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Export.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace HostelApp.HR
{
    public partial class xfrmHrHostelApplication : DevExpress.XtraEditors.XtraForm
    {
        public xfrmHrHostelApplication()
        {
            InitializeComponent();
        }
        private char irud;
        private int idpkx;
        private int selectedGenderID;
        private int selectedOccupationID;
        private int selectedIDTypeID;
        private int selectedTitleID;
        private int selectedRowHandle; 

        private void PopComboBox(string columnName, ComboBoxEdit controlName, string tableName)
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
            catch
            {
                throw;
            }
        }


        private void DisableControls()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtOtherName.Enabled = false;
            cbxGender.Enabled = false;
            txtRmks.Enabled = false;
            txtMobileNo.Enabled = false;
            txtEmail.Enabled = false;
            txtAddress.Enabled = false;
            dteDoB.Enabled = false;
            txtIDNo.Enabled = false;
            cbxIDType.Enabled = false;
            txtParentDetails.Enabled = false;
            txtParentContact.Enabled = false;
            txtEmergencyContact.Enabled = false;
            cbxOccupation.Enabled = false;
            cbxTitle.Enabled = false;
        }

        private void EmptyTextFields()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtOtherName.Text = string.Empty;
            cbxGender.Text = string.Empty;
            txtRmks.Text = string.Empty;
            txtMobileNo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dteDoB.Text = string.Empty;
            txtIDNo.Text = string.Empty;
            cbxIDType.Text = string.Empty;
            txtParentDetails.Text = string.Empty;
            txtParentContact.Text = string.Empty;
            txtEmergencyContact.Text = string.Empty;
            cbxOccupation.Text = string.Empty;
            cbxTitle.Text = string.Empty;
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
            int rowHandle;
            
            for (rowHandle = 0; rowHandle < gdvMain.DataRowCount; rowHandle++)
            {
                object cellValue = gdvMain.GetRowCellValue(rowHandle, "pplIDpk");
                if (cellValue != null && cellValue.Equals(idpkx))
                {
                    gdvMain.ClearSelection();
                    gdvMain.SelectRow(rowHandle);
                    gdvMain.MoveBy(rowHandle);

                }
            }
        }

        private void SelectIDpkRowX(int idpk)
        {
            selectedRowHandle = -1;

            int rowHandle = -1;
            for (int i = 0; i < gdvMain.DataRowCount; i++)
            {
                object cellValue = gdvMain.GetRowCellValue(i, "pplIDpk");
                if (cellValue != null && cellValue.Equals(idpk))
                {
                    rowHandle = i;
                    break;
                }
            }

            if (rowHandle >= 0)
            {
                gdvMain.ClearSelection();
                gdvMain.SelectRow(rowHandle);
                gdvMain.MoveBy(rowHandle);
                DisplayDataX(rowHandle);
                selectedRowHandle = rowHandle;
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

        private bool CheckIfDataExists(string pplLastName, string pplOtherName, string pplFirstName, DateTime pplDoB, string pplIDNo,  string pplMobileNo, string pplEmail, string pplParentDetails, string pplParentContact, string pplEmergencyContact, string pplRmks)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM tblHrPeople WHERE  pplLastName = @pplLastName AND pplOtherName = @pplOtherName AND pplFirstName = @pplFirstName AND pplDoB = @pplDoB AND pplIDNo = @pplIDNo AND pplIDTypefk = @pplIdt AND pplMobileNo = @pplMobileNo AND pplEmail = @pplEmail AND pplParentDetails = @pplParentDetails AND pplParentContact = @pplParentContact AND pplEmergencyContact = @pplEmergencyContact AND pplRmks = @pplRmks AND pplOcupationIDpk = @ocpIDpk AND pplGenderIDfk = @pplGenderIDfk AND pplTitleIDfk = @pplTitleIDfk";
                ConnectionStringParameters.CloseConnection();
                ConnectionStringParameters.OpenConnection();
                SqlCommand comdx = new SqlCommand(sql, ConnectionStringParameters.connStrx);
                comdx.Parameters.AddWithValue("@pplLastName", pplLastName);
                comdx.Parameters.AddWithValue("@pplOtherName", pplOtherName);
                comdx.Parameters.AddWithValue("@pplFirstName", pplFirstName);
                comdx.Parameters.AddWithValue("@pplDoB", pplDoB);
                comdx.Parameters.AddWithValue("@pplIDNo", pplIDNo);
                comdx.Parameters.AddWithValue("@pplMobileNo", pplMobileNo);
                comdx.Parameters.AddWithValue("@pplEmail", pplEmail);
                comdx.Parameters.AddWithValue("@pplParentDetails", pplParentDetails);
                comdx.Parameters.AddWithValue("@pplParentContact", pplParentContact);
                comdx.Parameters.AddWithValue("@pplEmergencyContact", pplEmergencyContact);
                comdx.Parameters.AddWithValue("@pplRmks", pplRmks);
                comdx.Parameters.AddWithValue("@ocpIDpk", selectedOccupationID);
                comdx.Parameters.AddWithValue("@pplIdt", selectedIDTypeID);
                comdx.Parameters.AddWithValue("@pplGenderIDfk", selectedGenderID);
                comdx.Parameters.AddWithValue("@pplTitleIDfk", selectedTitleID);
                // Execute the command and retrieve the count value
                int count = (int)comdx.ExecuteScalar();
                ConnectionStringParameters.CloseConnection();
                // Return true if a matching record is found (count > 0), false otherwise
                
                return count > 0;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
                throw;
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
                    SqlCommand comdx = new SqlCommand("UpdateRecordProcedure", ConnectionStringParameters.connStrx);

                    comdx.CommandType = CommandType.StoredProcedure;

                    comdx.Parameters.AddWithValue("@pplLastName", txtLastName.Text);
                    comdx.Parameters.AddWithValue("@pplOtherName", txtOtherName.Text);
                    comdx.Parameters.AddWithValue("@pplFirstName", txtFirstName.Text);
                    comdx.Parameters.AddWithValue("@pplRmks", txtRmks.Text);
                    comdx.Parameters.AddWithValue("@pplMobileNo", txtMobileNo.Text);
                    comdx.Parameters.AddWithValue("@pplEmail", txtEmail.Text);
                    comdx.Parameters.AddWithValue("@pplGenderIDfk", selectedGenderID);
                    comdx.Parameters.AddWithValue("@pplDoB", dteDoB.DateTime);
                    comdx.Parameters.AddWithValue("@pplIDNo", txtIDNo.Text);
                    comdx.Parameters.AddWithValue("@pplIdt", selectedIDTypeID);
                    comdx.Parameters.AddWithValue("@pplParentDetails", txtParentDetails.Text);
                    comdx.Parameters.AddWithValue("@pplParentContact", txtParentContact.Text);
                    comdx.Parameters.AddWithValue("@pplEmergencyContact", txtEmergencyContact.Text);
                    comdx.Parameters.AddWithValue("@ocpIDpk", selectedOccupationID);
                    comdx.Parameters.AddWithValue("@pplTitleIDfk", selectedTitleID);
                    comdx.Parameters.AddWithValue("@idpkx", idpkx);
                    comdx.ExecuteNonQuery();
                    GetData();
                    SelectIDpkRowX(idpkx);
                    MessageBox.Show("Updated Successfully", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConnectionStringParameters.CloseConnection();
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
                
                // Retrieve the data from the UI inputs
                string pplLastName = txtLastName.Text;
                string pplFirstName = txtFirstName.Text;
                string pplGender = cbxGender.Text;
                string pplRmks = txtRmks.Text;
                string pplOtherName = txtOtherName.Text;
                string pplEmail = txtEmail.Text;
                string pplMobileNo = txtMobileNo.Text;
                DateTime pplDoB = dteDoB.DateTime;
                string pplIDNo = txtIDNo.Text;
                string pplIDType = cbxIDType.Text;
                string pplParentDetails = txtParentDetails.Text;
                int pplIDTypepk = selectedIDTypeID;
                int pplOccupationIDpk = selectedOccupationID;
                string pplParentContact = txtParentContact.Text;
                string pplEmergencyContact = txtEmergencyContact.Text;
               
                // Query the database to check if the data already exists
                bool dataExists = CheckIfDataExists(pplLastName, pplOtherName, pplFirstName, pplDoB, pplIDNo, pplMobileNo, pplEmail, pplParentDetails, pplParentContact, pplEmergencyContact, pplRmks);

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
            catch(Exception ex) 
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
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
                txtFirstName.Text = gdvMain.GetFocusedRowCellValue("pplFirstName").ToString();
                txtLastName.Text = gdvMain.GetFocusedRowCellValue("pplLastName").ToString();
                txtOtherName.Text = gdvMain.GetFocusedRowCellValue("pplOtherName").ToString();
                cbxGender.Text = gdvMain.GetFocusedRowCellValue("gndNamex").ToString();
                cbxIDType.Text = gdvMain.GetFocusedRowCellValue("idtName").ToString();
                cbxOccupation.Text = gdvMain.GetFocusedRowCellValue("ocpName").ToString();
                cbxTitle.Text = gdvMain.GetFocusedRowCellValue("tltShtName").ToString();
                dteDoB.Text = gdvMain.GetFocusedRowCellValue("pplDoB").ToString();
                txtEmergencyContact.Text = gdvMain.GetFocusedRowCellValue("pplEmergencyContact").ToString();
                txtParentContact.Text= gdvMain.GetFocusedRowCellValue("pplParentContact").ToString();
                txtParentDetails.Text= gdvMain.GetFocusedRowCellValue("pplParentDetails").ToString();
                txtRmks.Text = gdvMain.GetFocusedRowCellValue("pplRmks").ToString();
                txtMobileNo.Text = gdvMain.GetFocusedRowCellValue("pplMobileNo").ToString();
                txtEmail.Text = gdvMain.GetFocusedRowCellValue("pplEmail").ToString();
                txtIDNo.Text = gdvMain.GetFocusedRowCellValue("pplIDNo").ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }


        private void DisplayDataX(int rowHandle)
        {
            if (rowHandle >= 0 && rowHandle < gdvMain.DataRowCount)
            {
                gdvMain.FocusedRowHandle = rowHandle;
                try
                {
                    txtFirstName.Text = gdvMain.GetFocusedRowCellValue("pplFirstName").ToString();
                    txtLastName.Text = gdvMain.GetFocusedRowCellValue("pplLastName").ToString();
                    txtOtherName.Text = gdvMain.GetFocusedRowCellValue("pplOtherName").ToString();
                    cbxGender.Text = gdvMain.GetFocusedRowCellValue("gndNamex").ToString();
                    cbxIDType.Text = gdvMain.GetFocusedRowCellValue("idtName").ToString();
                    cbxOccupation.Text = gdvMain.GetFocusedRowCellValue("ocpName").ToString();
                    cbxTitle.Text = gdvMain.GetFocusedRowCellValue("tltShtName").ToString();
                    dteDoB.Text = gdvMain.GetFocusedRowCellValue("pplDoB").ToString();
                    txtEmergencyContact.Text = gdvMain.GetFocusedRowCellValue("pplEmergencyContact").ToString();
                    txtParentContact.Text = gdvMain.GetFocusedRowCellValue("pplParentContact").ToString();
                    txtParentDetails.Text = gdvMain.GetFocusedRowCellValue("pplParentDetails").ToString();
                    txtRmks.Text = gdvMain.GetFocusedRowCellValue("pplRmks").ToString();
                    txtMobileNo.Text = gdvMain.GetFocusedRowCellValue("pplMobileNo").ToString();
                    txtEmail.Text = gdvMain.GetFocusedRowCellValue("pplEmail").ToString();
                    txtIDNo.Text = gdvMain.GetFocusedRowCellValue("pplIDNo").ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.GetType()} says {ex.Message}");
                }
                idpkx = (int)gdvMain.GetFocusedRowCellValue("pplIDpk");
            }
        }

        private void SearchGetData()
        {
            try
            {
                string sql = $"select * from vwHrPeoples where [pplLastName]like '%{txtSearch.Text}%'or [pplOtherName] like '%{txtSearch.Text}%'or[pplFirstName]like '%{txtSearch.Text}%'or [pplDoB]like '%{txtSearch.Text}%'or[pplIDNo] like '%{txtSearch.Text}%'or [pplIDType] like '%{txtSearch.Text}%'or [pplMobileNo] like '%{txtSearch.Text}%'or [pplEmail] like '%{txtSearch.Text}%'or [pplParentContact] like '%{txtSearch.Text}%'or[pplEmergencyContact] like '%{txtSearch.Text}%'or tltShtName like '%{txtSearch.Text}%'or [pplRmks] like '%{txtSearch.Text}%'or gndName like '%{txtSearch.Text}%' or ocpName like '%{txtSearch.Text}%' ";
                SqlCommand comdx = new SqlCommand(sql, ConnectionStringParameters.connStrx);
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

        private void xfrmHrHostelApplicationfrm_Load(object sender, EventArgs e)
        {
            irud = 'r';
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtOtherName.Enabled = false;
            cbxGender.Enabled = false;
            txtRmks.Enabled = false;
            txtMobileNo.Enabled = false;
            txtEmail.Enabled = false;
            txtAddress.Enabled = false;
            dteDoB.Enabled = false;
            txtIDNo.Enabled = false;
            cbxIDType.Enabled = false;
            txtParentDetails.Enabled = false;
            txtParentContact.Enabled = false;
            txtEmergencyContact.Enabled = false;
            cbxOccupation.Enabled = false;
            cbxTitle.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            GetData();
            DisplayData();
            PopComboBox("gndName", cbxGender, "tblGenGenders");
            ////PopComboBox("ocpName", cbxOccupation, "tblGenOccupation");
            PopComboBox("idtName", cbxIDType, "tblGenIDType");
            PopComboBox("tltShtName", cbxTitle, "tblGenTitles");

            //GetInitialData Remember to make into a function
            GetInitialData(cbxGender, "tblGenGenders", "gndIDpk", "gndName", selectedGenderID);
            string selectedGender = cbxGender.Text;
            int genderID = GetID(selectedGender, "tblGenGenders", "gndIDpk", "gndName");
            selectedGenderID = genderID;
            //string selectedOccupation = cbxOccupation.Text;
            //int occupationID = GetID(selectedOccupation, "tblGenOccupation", "ocpIDpk", "ocpName");
            //selectedOccupationID = occupationID;

            string selectedIDType = cbxIDType.Text;
            int IDTypeID = GetID(selectedIDType, "tblGenIDType", "idtIDpk", "idtName");
            selectedIDTypeID = IDTypeID;

            string selectedTitle = cbxTitle.Text;
            int titleID = GetID(selectedTitle, "tblGenTitles", "tltIDpk", "tltShtName");
            selectedTitleID = titleID;

        }

        private void GetInitialData(ComboBoxEdit textBox , string tableName ,string primaryKey , string columnName , int selectedID)
        {
            //GetInitialData Remember to make into a function
            string selectedProperty = textBox.Text;
            int propertyID = GetID(selectedProperty,tableName, primaryKey, columnName);
            selectedID = propertyID;
            int ID = selectedID;
        }
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedGender = comboBox.SelectedItem.ToString();

            // Retrieve the corresponding gender ID from the database
            int genderID = GetID(selectedGender, "tblGenGenders", "gndIDpk", "gndName");

            // Store the gender ID
            selectedGenderID = genderID;
        }

        private void cbxOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedOccupation = comboBox.SelectedItem.ToString();

            // Retrieve the corresponding gender ID from the database
            int occupationID = GetID(selectedOccupation, "tblGenOccupation", "ocpIDpk", "ocpName");

            // Store the gender ID
            selectedOccupationID = occupationID;
        }

        private void cbxIDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedIDType = comboBox.SelectedItem.ToString();

            // Retrieve the corresponding gender ID from the database
            int idtID = GetID(selectedIDType, "tblGenIDType", "idtIDpk", "idtName");

            // Store the gender ID
            selectedIDTypeID = idtID;
        }

        private void cbxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedTitle = comboBox.SelectedItem.ToString();

            // Retrieve the corresponding gender ID from the database
            int titleID = GetID(selectedTitle, "tblGenTitles", "tltIDpk", "tltShtName");

            // Store the gender ID
            selectedTitleID = titleID;
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
                    btnEdit.Enabled = false;
                    btnNew.Text = "Cancel";
                    btnNew.Image = HostelApp.Properties.Resources.delete_16x16;
                    btnNew2.Text = "Cancel";
                    btnNew2.Image = HostelApp.Properties.Resources.delete_16x16;
                    EmptyTextFields();
                    txtFirstName.Focus();

                }
                else if (irud == 'i')
                {
                    irud = 'r';
                    GetData();
                    DisplayData();
                    DisableControls();
                    btnSave.Enabled = false;
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    btnNew.Text = "New";
                    btnNew.Image = HostelApp.Properties.Resources.newemployee_16x16;
                    btnNew2.Text = "New";
                    btnNew2.Image = HostelApp.Properties.Resources.newemployee_16x16;
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"{ex.GetType()} says {ex.Message}"); 
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
            catch(Exception ex) 
            { 
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
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
                        SqlCommand comdx = new SqlCommand("INSERT INTO tblHrPeople (pplLastName, pplOtherName, pplFirstName, pplDoB, pplIDNo, pplMobileNo, pplEmail, pplParentDetails, pplParentContact, pplEmergencyContact, pplRmks, pplGenderIDfk, pplOcupationIDpk, pplIDtypefk,pplTitleIDfk) VALUES (@pplLastName, @pplOtherName, @pplFirstName, @pplDoB, @pplIDNo, @pplMobileNo, @pplEmail, @pplParentDetails, @pplParentContact, @pplEmergencyContact, @pplRmks, @pplGenderIDfk, @pplOcupationIDpk, @pplIDtypefk,@pplTitleIDfk)", ConnectionStringParameters.connStrx);
                        comdx.Parameters.AddWithValue("@pplLastName", txtLastName.Text);
                        comdx.Parameters.AddWithValue("@pplOtherName", txtOtherName.Text);
                        comdx.Parameters.AddWithValue("@pplFirstName", txtFirstName.Text);
                        comdx.Parameters.AddWithValue("@pplRmks", txtRmks.Text);
                        comdx.Parameters.AddWithValue("@pplMobileNo", txtMobileNo.Text);
                        comdx.Parameters.AddWithValue("@pplEmail", txtEmail.Text);
                        comdx.Parameters.AddWithValue("@pplGenderIDfk", selectedGenderID);
                        comdx.Parameters.AddWithValue("@pplOcupationIDpk", selectedOccupationID);
                        comdx.Parameters.AddWithValue("@pplIDtypefk", selectedIDTypeID);
                        comdx.Parameters.AddWithValue("@pplDoB", dteDoB.Text);
                        comdx.Parameters.AddWithValue("@pplIDNo", txtIDNo.Text);
                        comdx.Parameters.AddWithValue("@pplParentDetails", txtParentDetails.Text);
                        comdx.Parameters.AddWithValue("@pplParentContact", txtParentContact.Text);
                        comdx.Parameters.AddWithValue("@pplEmergencyContact", txtEmergencyContact.Text);
                        comdx.Parameters.AddWithValue("@pplTitleIDfk", selectedTitleID);
                        comdx.ExecuteNonQuery();
                        GetData();
                        SelectIDpkRowX(idpkx);
                        //DisplayDataX(gdvMain.FocusedRowHandle);
                        MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
                throw;

            }
        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            try
            {
                if (irud == 'r')
                {
                    irud = 'i';
                    EnableControls(this);
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
                    btnNew.Text = "Cancel";
                    btnNew.Image = HostelApp.Properties.Resources.delete_16x16;
                    btnNew2.Text = "Cancel";
                    btnNew2.Image = HostelApp.Properties.Resources.delete_16x16;
                    EmptyTextFields();
                    txtFirstName.Focus();
                }
                else if (irud == 'i')
                {
                    irud = 'r';
                    GetData();
                    DisplayData();
                    DisableControls();
                    btnSave.Enabled = false;
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    btnNew.Text = "New";
                    btnNew.Image = HostelApp.Properties.Resources.newemployee_16x16;
                    btnNew2.Text = "New";
                    btnNew2.Image = HostelApp.Properties.Resources.newemployee_16x16;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
                throw;
            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
            SelectIDpkRow();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (irud == 'r')
            {
                irud = 'u';
                EnableControls(this);
                btnSave.Enabled = true;
                btnNew.Enabled = false;
                btnNew2.Enabled = false;
                btnSave.Text = "Update";
                btnEdit.Text = "Cancel";
                btnEdit.Image = HostelApp.Properties.Resources.delete_16x16;
                txtFirstName.Focus();
            }
            else if (irud == 'u')
            {
                irud = 'r';
                DisableControls();
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                btnNew2.Enabled = true;
                btnSave.Text = "Save";
                btnEdit.Text = "Edit";
                btnEdit.Image = HostelApp.Properties.Resources.edit_16x16;
            }
        }

        private void gdvMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowHandle = gdvMain.FocusedRowHandle;
            DisplayDataX(rowHandle);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchGetData();
        }
    }
}