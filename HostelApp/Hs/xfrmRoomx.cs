using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
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

namespace HostelApp.Hs
{
    public partial class xfrmRoomx : DevExpress.XtraEditors.XtraForm
    {
        public xfrmRoomx()
        {
            InitializeComponent();
        }
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
            idpkx = (int)gdvMain.GetFocusedRowCellValue("rmIDpk");
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

        private void GetInitialData(ComboBoxEdit textBox, string tableName, string primaryKey, string columnName, ref int selectedID)
        {
            //GetInitialData Remember to make into a function
            string selectedProperty = textBox.Text;
            int propertyID = GetID(selectedProperty, tableName, primaryKey, columnName);
            selectedID = propertyID;
        }


        private bool CheckIfDataExists(string rmRoomNo, string rmRoomName, int rmFloorIDfk, int rmBlockIDfk, int rmHostelIDfk, int rmRoomTypeIDfk, string rmRoomDescription, decimal rmRate, string rmOccupancyStatus, int rmPeopleIDfk)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM tblHsRooms WHERE rmRoomNo = @rmRoomNo AND rmRoomName = @rmRoomName AND rmFloorIDfk = @rmFloorIDfk AND rmBlockIDfk = @rmBlockIDfk AND rmHostelIDfk = @rmHostelIDfk AND rmRoomTypeIDfk = @rmRoomTypeIDfk AND rmRoomDescription = @rmRoomDescription AND rmRate = @rmRate AND rmOccupancyStatus = @rmOccupancyStatus AND rmPeopleIDfk = @rmPeopleIDfk";

                ConnectionStringParameters.CloseConnection();
                ConnectionStringParameters.OpenConnection();

                SqlCommand command = new SqlCommand(sql, ConnectionStringParameters.connStrx);
                command.Parameters.AddWithValue("@rmRoomNo", rmRoomNo);
                command.Parameters.AddWithValue("@rmRoomName", rmRoomName);
                command.Parameters.AddWithValue("@rmFloorIDfk", rmFloorIDfk);
                command.Parameters.AddWithValue("@rmBlockIDfk", rmBlockIDfk);
                command.Parameters.AddWithValue("@rmHostelIDfk", rmHostelIDfk);
                command.Parameters.AddWithValue("@rmRoomTypeIDfk", rmRoomTypeIDfk);
                command.Parameters.AddWithValue("@rmRoomDescription", rmRoomDescription);
                command.Parameters.AddWithValue("@rmRate", rmRate);
                command.Parameters.AddWithValue("@rmOccupancyStatus", rmOccupancyStatus);
     
                command.Parameters.AddWithValue("@rmPeopleIDfk", rmPeopleIDfk);

                int count = (int)command.ExecuteScalar();

                ConnectionStringParameters.CloseConnection();

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
                throw;
            }
        }


        private void UpdateData()
        {
            try
            {
                // Check if the data already exists in the database
                string rmRoomNo = txtRoomNumber.Text;
                string rmRoomName = txtRoomName.Text;
                int rmFloorIDfk = selectedFloorID;
                int rmBlockIDfk = selectedBlockID;
                int rmHostelIDfk = selectedHostelID;
                int rmRoomTypeIDfk = selectedRoomTypeID;
                string rmRoomDescription = txtDescription.Text;
                decimal rmRate = Convert.ToDecimal(cbxRoomRate.Text);
                string rmOccupancyStatus = ckeStatus.Checked ? "1" : "0";
                int rmPeopleIDfk = selectedOccupantID;

                
                bool dataExists = CheckIfDataExists(rmRoomNo, rmRoomName, rmFloorIDfk, rmBlockIDfk, rmHostelIDfk, rmRoomTypeIDfk, rmRoomDescription, rmRate, rmOccupancyStatus, rmPeopleIDfk);

                if (dataExists)
                {
                    // Display a message to the user indicating that the data already exists
                    MessageBox.Show("Data already exists in the database.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Get the ID of the selected row
                    int roomId = (int)gdvMain.GetFocusedRowCellValue("rmIDpk");

                    // Prepare the SQL query to update the data
                    string query = @"UPDATE tblHsRooms SET
                                    rmRoomNo = @RoomNumber,
                           
                                    rmRoomName = @RoomName,
                                    rmRoomDescription = @RoomDescription, rmPeopleIDfk = @rmPeopleIDfk,
                                    
                                   rmFloorIDfk = @FloorID,
                                   rmBlockIDfk = @BlockID,
                                   rmHostelIDfk = @HostelID,
                                    rmRate = @RoomRate,
                                    rmRoomTypeIDfk = @RoomTypeID, rmOccupancyStatus = @rmOccupancyStatus
                                    
                                WHERE rmIDpk = @RoomID";

                    // Create a new SqlCommand
                    SqlCommand command = new SqlCommand(query, ConnectionStringParameters.connStrx);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@RoomNumber", txtRoomNumber.Text);

                    command.Parameters.AddWithValue("@RoomName", txtRoomName.Text);
                    command.Parameters.AddWithValue("@RoomDescription", txtDescription.Text);
                    command.Parameters.AddWithValue("@FloorID", selectedFloorID);
                    command.Parameters.AddWithValue("@BlockID", selectedBlockID);
                    command.Parameters.AddWithValue("@HostelID", selectedHostelID);
                    command.Parameters.AddWithValue("@rmPeopleIDfk", selectedOccupantID);
                    command.Parameters.AddWithValue("@RoomRate", cbxRoomRate.Text);
                    command.Parameters.AddWithValue("@RoomTypeID", selectedRoomTypeID);
                    command.Parameters.AddWithValue("@rmOccupancyStatus",rmOccupancyStatus);
                    command.Parameters.AddWithValue("@RoomID", roomId);

                    // Open the connection
                    ConnectionStringParameters.CloseConnection();
                    ConnectionStringParameters.OpenConnection();

                    // Execute the update command
                    command.ExecuteNonQuery();

                    // Close the connection
                    ConnectionStringParameters.CloseConnection(); GetData();
                    DisplayData();
                    SelectIDpkRow();

                    MessageBox.Show("Data updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }

        private void SaveData()
        {
            try
            {
                string rmRoomNo = txtRoomNumber.Text;
                string rmRoomName = txtRoomName.Text;
                int rmFloorIDfk = selectedFloorID;
                int rmBlockIDfk = selectedBlockID;
                int rmHostelIDfk = selectedHostelID;
                int rmRoomTypeIDfk = selectedRoomTypeID;
                string rmRoomDescription = txtDescription.Text;
                decimal rmRate = Convert.ToDecimal(cbxRoomRate.Text);
                string rmOccupancyStatus = ckeStatus.Checked ? "1" : "0";
                int rmPeopleIDfk = selectedOccupantID;

                // Check if the data already exists in the database
                bool dataExists = CheckIfDataExists(rmRoomNo, rmRoomName, rmFloorIDfk, rmBlockIDfk, rmHostelIDfk, rmRoomTypeIDfk, rmRoomDescription, rmRate, rmOccupancyStatus, rmPeopleIDfk);

                if (dataExists)
                {
                    // Display a message to the user indicating that the data already exists
                    MessageBox.Show("Data already exists in the database.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Save the data to the database
                    string sql = "INSERT INTO tblHsRooms (rmRoomNo, rmRoomName, rmFloorIDfk, rmBlockIDfk, rmHostelIDfk, rmRoomTypeIDfk, rmRoomDescription, rmRate, rmOccupancyStatus,  rmPeopleIDfk) " +
                                 "VALUES (@rmRoomNo, @rmRoomName, @rmFloorIDfk, @rmBlockIDfk, @rmHostelIDfk, @rmRoomTypeIDfk, @rmRoomDescription, @rmRate, @rmOccupancyStatus,  @rmPeopleIDfk)";

                    ConnectionStringParameters.CloseConnection();
                    ConnectionStringParameters.OpenConnection();

                    SqlCommand command = new SqlCommand(sql, ConnectionStringParameters.connStrx);

                    command.Parameters.AddWithValue("@rmRoomNo", rmRoomNo);
                            command.Parameters.AddWithValue("@rmRoomName", rmRoomName);
                            command.Parameters.AddWithValue("@rmFloorIDfk", rmFloorIDfk);
                            command.Parameters.AddWithValue("@rmBlockIDfk", rmBlockIDfk);
                            command.Parameters.AddWithValue("@rmHostelIDfk", rmHostelIDfk);
                            command.Parameters.AddWithValue("@rmRoomTypeIDfk", rmRoomTypeIDfk);
                            command.Parameters.AddWithValue("@rmRoomDescription", rmRoomDescription);
                            command.Parameters.AddWithValue("@rmRate", rmRate);
                            command.Parameters.AddWithValue("@rmOccupancyStatus", rmOccupancyStatus);
                            command.Parameters.AddWithValue("@rmPeopleIDfk", rmPeopleIDfk);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                        GetData();
                        DisplayData();
                        SelectIDpkRow();
                        MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to save data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteData()
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Clear the  data?", "Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string sql = "Delete From tblHsRooms where rmIDpk = " + gdvMain.GetFocusedRowCellValue("rmIDpk");
                    ConnectionStringParameters.CloseConnection();
                    ConnectionStringParameters.OpenConnection();
                    SqlCommand comdx = new SqlCommand(sql, ConnectionStringParameters.connStrx);
                    comdx.ExecuteNonQuery();
                    GetData();
                    DisplayData();
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
                ckeStatus.Checked = Convert.ToBoolean(gdvMain.GetFocusedRowCellValue("rmOccupancyStatus"));
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }

        private void xfrmRoomx_Load(object sender, EventArgs e)
        {
            irud = 'r';
            DisableControls();
            GetData();
            DisplayData();
            //PopComboBox("hstName", cbxHostel, "tblHsHostels");
            //PopComboBox("blcBlockName", cbxBlock, "tblHsBlocks");
            //PopComboBox("flrFloorName", cbxFloor, "tblHsFloors");
            //PopComboBox("pplName", cbxOccupant, "vwHrPeoples");
            //PopComboBox("gndName", cbxGender, "tblGenGenders");
            //PopComboBox("rmtRoomTypeName", cbxRoomType, "tblHsRoomTypes");
            //GetInitialData(cbxHostel, "tblHsHostels", "hstIDpk", "hstName", ref selectedHostelID);
            //GetInitialData(cbxBlock, "tblHsBlocks", "blcBlockIDpk", "blcBlockName", ref selectedBlockID);
            //GetInitialData(cbxFloor, "tblHsFloors", "flrFloorIDpk", "flrFloorName", ref selectedFloorID);
            //GetInitialData(cbxOccupant, "vwHrPeoples", "pplIDpk", "pplName",ref selectedOccupantID);
            //GetInitialData(cbxGender, "tblGenGenders", "gndIDpk", "gndName", ref selectedGenderID);
            //GetInitialData(cbxRoomType, "tblHsRoomTypes", "rmtIDpk", "rmtRoomTypeName", ref selectedRoomTypeID);
        }

        private void btnNew_Click_1(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (irud == 'u')
                {
                    EnableControls(this);
                    UpdateData();
                    btnNew.Enabled = false;
                    btnNew2.Enabled = false;
                }
                else if (irud == 'i')
                {
                    if (MessageBox.Show("Are you sure you want to save?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        SaveData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
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

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            string selectedGender = comboBox.SelectedItem.ToString();

            int gndID = GetID(selectedGender, "tblGenGenders", "gndIDpk", "gndName");

            selectedGenderID = gndID;
        }

        private void gdvMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DisplayData();
        }
    }
}