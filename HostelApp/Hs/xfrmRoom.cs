using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HostelApp.Hs
{
    public partial class xfrmRoom : DevExpress.XtraEditors.XtraForm
    {
        private char irud;
        private int idpkx;
        private int selectedOccupantID;
        private int selectedRoomTypeID;
        private int selectedFloorID;
        private int selectedBlockID;
        private int selectedHostelID;
        private int selectedGenderID;

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
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }


        private void DisableControls()
        {
            txtRoomNumber.Enabled = false;
            cbxRoomCapacity.Enabled = false;
            txtRoomName.Enabled = false;
            txtDescription.Enabled = false;
            cbxGender.Enabled = false;
            ckeStatus.Enabled = false;
            cbxFloor.Enabled = false;
            cbxBlock.Enabled = false;
            cbxHostel.Enabled = false;
            cbxOccupant.Enabled = false;
            cbxRoomRate.Enabled = false;
            cbxRoomType.Enabled = false;
            txtMobileNo.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = false;


        }


        private void EmptyTextFields()
        {
            txtRoomNumber.Text = string.Empty;
            cbxRoomCapacity.Text = string.Empty;
            txtRoomName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cbxGender.Text = string.Empty;
            ckeStatus.Checked = false;
            cbxFloor.Text = string.Empty;
            cbxBlock.Text = string.Empty;
            cbxHostel.Text = string.Empty;
            cbxOccupant.Text = string.Empty;
            cbxRoomType.Text = string.Empty;
            cbxRoomRate.Text = string.Empty;
            txtMobileNo.Text = string.Empty;

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
            int idpkx = (int)gdvMain.GetFocusedRowCellValue("rmIDpk");
            int rowHandle;

            for (rowHandle = 0; rowHandle < gdvMain.DataRowCount; rowHandle++)
            {
                object cellValue = gdvMain.GetRowCellValue(rowHandle, "rmIDpk");
                if (cellValue != null && cellValue.Equals(idpkx))
                {
                    gdvMain.ClearSelection();
                    gdvMain.SelectRow(rowHandle);
                    gdvMain.MoveBy(rowHandle);

                }
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


        //private bool CheckIfDataExists(string pplLastName, string pplOtherName, string pplFirstName, DateTime pplDoB, string pplIDNo, string pplMobileNo, string pplEmail, string pplParentDetails, string pplParentContact, string pplEmergencyContact, string pplRmks)
        //{
        //    try
        //    {
        //        string sql = "SELECT COUNT(*) FROM tblHrPeople WHERE  pplLastName = @pplLastName AND pplOtherName = @pplOtherName AND pplFirstName = @pplFirstName AND pplDoB = @pplDoB AND pplIDNo = @pplIDNo AND pplIDTypefk = @pplIdt AND pplMobileNo = @pplMobileNo AND pplEmail = @pplEmail AND pplParentDetails = @pplParentDetails AND pplParentContact = @pplParentContact AND pplEmergencyContact = @pplEmergencyContact AND pplRmks = @pplRmks AND pplOcupationIDpk = @ocpIDpk AND pplGenderIDfk = @pplGenderIDfk AND pplTitleIDfk = @pplTitleIDfk";
        //        ConnectionStringParameters.CloseConnection();
        //        ConnectionStringParameters.OpenConnection();
        //        SqlCommand comdx = new SqlCommand(sql, ConnectionStringParameters.connStrx);
        //        comdx.Parameters.AddWithValue("@pplLastName", pplLastName);
        //        comdx.Parameters.AddWithValue("@pplOtherName", pplOtherName);
        //        comdx.Parameters.AddWithValue("@pplFirstName", pplFirstName);
        //        comdx.Parameters.AddWithValue("@pplDoB", pplDoB);
        //        comdx.Parameters.AddWithValue("@pplIDNo", pplIDNo);
        //        comdx.Parameters.AddWithValue("@pplMobileNo", pplMobileNo);
        //        comdx.Parameters.AddWithValue("@pplEmail", pplEmail);
        //        comdx.Parameters.AddWithValue("@pplParentDetails", pplParentDetails);
        //        comdx.Parameters.AddWithValue("@pplParentContact", pplParentContact);
        //        comdx.Parameters.AddWithValue("@pplEmergencyContact", pplEmergencyContact);
        //        comdx.Parameters.AddWithValue("@pplRmks", pplRmks);
        //        comdx.Parameters.AddWithValue("@ocpIDpk", selectedOccupationID);
        //        comdx.Parameters.AddWithValue("@pplIdt", selectedIDTypeID);
        //        comdx.Parameters.AddWithValue("@pplGenderIDfk", selectedGenderID);
        //        comdx.Parameters.AddWithValue("@pplTitleIDfk", selectedTitleID);
        //        // Execute the command and retrieve the count value
        //        int count = (int)comdx.ExecuteScalar();
        //        ConnectionStringParameters.CloseConnection();
        //        // Return true if a matching record is found (count > 0), false otherwise

        //        return count > 0;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"{ex.GetType()} says {ex.Message}");
        //        throw;
        //    }

        //}

        //private void UpdateData()
        //{
        //    try
        //    {
        //        if (MessageBox.Show("Are you sure you want to Update the  data?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        //        {
        //            ConnectionStringParameters.CloseConnection();
        //            ConnectionStringParameters.OpenConnection();
        //            int idpkx = (int)gdvMain.GetFocusedRowCellValue("pplIDpk");
        //            SqlCommand comdx = new SqlCommand("UPDATE tblHrPeople SET pplLastName = @pplLastName , pplOtherName = @pplOtherName , pplFirstName = @pplFirstName , pplDoB = @pplDoB , pplIDNo = @pplIDNo , pplIDTypefk = @pplIdt , pplMobileNo = @pplMobileNo , pplEmail = @pplEmail , pplParentDetails = @pplParentDetails , pplParentContact = @pplParentContact , pplEmergencyContact = @pplEmergencyContact , pplRmks = @pplRmks , pplOcupationIDpk = @ocpIDpk , pplGenderIDfk = @pplGenderIDfk, pplTitleIDfk = @pplTitleIDfk WHERE pplIDpk = @idpkx", ConnectionStringParameters.connStrx);
        //            comdx.Parameters.AddWithValue("@pplLastName", txtLastName.Text);
        //            comdx.Parameters.AddWithValue("@pplOtherName", txtOtherName.Text);
        //            comdx.Parameters.AddWithValue("@pplFirstName", txtFirstName.Text);
        //            comdx.Parameters.AddWithValue("@pplRmks", txtRmks.Text);
        //            comdx.Parameters.AddWithValue("@pplMobileNo", txtMobileNo.Text);
        //            comdx.Parameters.AddWithValue("@pplEmail", txtEmail.Text);
        //            comdx.Parameters.AddWithValue("@pplGenderIDfk", selectedGenderID);
        //            comdx.Parameters.AddWithValue("@pplDoB", dteDoB.DateTime);
        //            comdx.Parameters.AddWithValue("@pplIDNo", txtIDNo.Text);
        //            comdx.Parameters.AddWithValue("@pplIdt", selectedIDTypeID);
        //            comdx.Parameters.AddWithValue("@pplParentDetails", txtParentDetails.Text);
        //            comdx.Parameters.AddWithValue("@pplParentContact", txtParentContact.Text);
        //            comdx.Parameters.AddWithValue("@pplEmergencyContact", txtEmergencyContact.Text);
        //            comdx.Parameters.AddWithValue("@ocpIDpk", selectedOccupationID);
        //            comdx.Parameters.AddWithValue("@pplTitleIDfk", selectedTitleID);
        //            comdx.Parameters.AddWithValue("@idpkx", idpkx);
        //            comdx.ExecuteNonQuery();
        //            GetData();
        //            DisplayData();
        //            SelectIDpkRow();
        //            MessageBox.Show("Updated Successfully", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            ConnectionStringParameters.CloseConnection();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"{ex.GetType()} says {ex.Message}");
        //    }
        //}

        //private void CheckData()
        //{
        //    try
        //    {

        //        // Retrieve the data from the UI inputs
        //        string pplLastName = txtLastName.Text;
        //        string pplFirstName = txtFirstName.Text;
        //        string pplGender = cbxGender.Text;
        //        string pplRmks = txtRmks.Text;
        //        string pplOtherName = txtOtherName.Text;
        //        string pplEmail = txtEmail.Text;
        //        string pplMobileNo = txtMobileNo.Text;
        //        DateTime pplDoB = dteDoB.DateTime;
        //        string pplIDNo = txtIDNo.Text;
        //        string pplIDType = cbxIDType.Text;
        //        string pplParentDetails = txtParentDetails.Text;
        //        int pplIDTypepk = selectedIDTypeID;
        //        int pplOccupationIDpk = selectedOccupationID;
        //        string pplParentContact = txtParentContact.Text;
        //        string pplEmergencyContact = txtEmergencyContact.Text;

        //        // Query the database to check if the data already exists
        //        bool dataExists = CheckIfDataExists(pplLastName, pplOtherName, pplFirstName, pplDoB, pplIDNo, pplMobileNo, pplEmail, pplParentDetails, pplParentContact, pplEmergencyContact, pplRmks);

        //        if (dataExists)
        //        {
        //            // Display a message to the user indicating that the data already exists
        //            MessageBox.Show("Data already exists in the database.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            // Proceed with updating the data in the database
        //            UpdateData();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"{ex.GetType()} says {ex.Message}");
        //    }
        //}

        private void GetData()
        {
            try
            {
                SqlCommand comdx = new SqlCommand("select * from vwHsRooms", ConnectionStringParameters.connStrx);
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
                txtRoomNumber.Text = gdvMain.GetFocusedRowCellValue("rmRoomNo").ToString();
                txtDescription.Text = gdvMain.GetFocusedRowCellValue("rmRoomDescription").ToString();
                cbxHostel.Text = gdvMain.GetFocusedRowCellValue("hstName").ToString();
                cbxBlock.Text = gdvMain.GetFocusedRowCellValue("blcBlockName").ToString();
                cbxFloor.Text = gdvMain.GetFocusedRowCellValue("flrFloorName").ToString();
                cbxOccupant.Text = gdvMain.GetFocusedRowCellValue("pplName").ToString();
                cbxGender.Text = gdvMain.GetFocusedRowCellValue("gndName").ToString();
                txtMobileNo.Text = gdvMain.GetFocusedRowCellValue("pplMobileNo").ToString();
                cbxRoomRate.Text = gdvMain.GetFocusedRowCellValue("rmRate").ToString();
                cbxRoomType.Text = gdvMain.GetFocusedRowCellValue("rmtRoomTypeName").ToString();
                txtRoomName.Text = gdvMain.GetFocusedRowCellValue("rmRoomName").ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }


        public xfrmRoom()
        {
            InitializeComponent();
        }



        private void xfrmRoom_Load(object sender, EventArgs e)
        {
            irud = 'r';
            GetData();
            DisplayData();
            PopComboBox("hstName", cbxHostel, "tblHsHostels");
            PopComboBox("blcBlockName", cbxBlock, "tblHsBlocks");
            PopComboBox("flrFloorName", cbxFloor, "tblHsFloors");
            PopComboBox("pplName", cbxOccupant, "vwHrPeoples");
            PopComboBox("gndNamex", cbxGender, "vwHrPeoples");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
                    txtRoomNumber.Focus();

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
                txtRoomNumber.Focus();
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

        private void btnNew2_Click(object sender, EventArgs e)
        {

        }


        private void cbxBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedBlock = comboBox.SelectedItem.ToString();

            // Retrieve the corresponding Block ID from the database
            int blcID = GetID(selectedBlock, "tblHsBlocks", "blcBlockIDpk", "blcBlockName");

            // Store the Block ID
            selectedBlockID = blcID;

        }

        private void cbxFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedFloor = comboBox.SelectedItem.ToString();

            // Retrieve the corresponding Floor ID from the database
            int flrID = GetID(selectedFloor, "tblHsFloors", "flrFloorIDpk", "flrFloorName");

            //Store the Floor ID
            selectedFloorID = flrID;
        }

        private void cbxCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxOccupant_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedOccupant = comboBox.SelectedItem.ToString();

            // Retrive the corresponding person ID from the database
            int pplID = GetID(selectedOccupant, "vwHrPeoples", "pplIDpk", "pplName");

            // Store the person ID
            selectedOccupantID = pplID;
        }

        private void cbxHostel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedHostel = comboBox.SelectedItem.ToString();

            // Retrieve the corresponding Hostel ID from the database
            int hstID = GetID(selectedHostel, "tblHsHostels", "hstIDpk", "hstName");

            // Store the Hostel ID
            selectedHostelID = hstID;

        }


        private void gdvMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DisplayData();
        }

        private void cbxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedRoomType = comboBox.SelectedItem.ToString();

            // Retrieve the corresponding Room Type ID from the database
            int rmtID = GetID(selectedRoomType, "tblHsRoomTypes", "rmtIDpk", "rmtRoomTypeName");

            // Store the Room Type ID
            selectedRoomTypeID = rmtID;

        }

        private void cbxRoomRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedGender = comboBox.SelectedItem.ToString();

            int gndID = GetID(selectedGender, "tblGenGenders", "gndIDpk", "gndName");

            selectedGenderID = gndID;
        }

    }
}