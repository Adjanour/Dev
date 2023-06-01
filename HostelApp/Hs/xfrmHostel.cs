using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HostelApp.Hs
{
    public partial class xfrmHostel : DevExpress.XtraEditors.XtraForm
    {

        public xfrmHostel()
        {
            InitializeComponent();
        }
        private char irud;
        private void DisableControls(Control control)
        {
            control.Enabled = false;

            // Recursively enable controls within container controls
            foreach (Control childControl in control.Controls)
            {
                DisableControls(childControl);
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
        private void GetData()
        {
            try
            {
                string sql = $"select * from tblHsHostels where hstName Like '%{txtSearch.Text}%' ";
                SqlCommand comdx = new SqlCommand(sql, ConnectionStringParameters.connStrx);
                SqlDataAdapter dx = new SqlDataAdapter(comdx);
                DataTable dt = new DataTable();
                dx.Fill(dt);
                gdcMain.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SelectIDpkRow()
        {
            int idpkx = (int)gdvMain.GetFocusedRowCellValue("hstIDpk");
            int rowHandle = 0;
            object cellValue = gdvMain.GetRowCellValue(rowHandle, "hstIDpk");
            for (  rowHandle = 0 ; rowHandle < gdvMain.DataRowCount; rowHandle++)
            {
                
                if (cellValue != null && cellValue.Equals(idpkx))
                {
                    gdvMain.ClearSelection();
                    gdvMain.SelectRow(rowHandle);
                    gdvMain.MoveBy(rowHandle);
                    
                }
            }
        }

        private void DisplayData()
        {
            if (gdvMain.RowCount > 0 )
            {
                try
                {
                    txtHostelNo.Text = gdvMain.GetFocusedRowCellValue("hstNumber").ToString();
                    txtHostelName.Text = gdvMain.GetFocusedRowCellValue("hstName").ToString();
                    txtHostelCapacity.Text = gdvMain.GetFocusedRowCellValue("hstCapacity").ToString();
                    txtHostelDescription.Text = gdvMain.GetFocusedRowCellValue("hstDescription").ToString();
                    txtRemarks.Text = gdvMain.GetFocusedRowCellValue("hstRmks").ToString();
                    txtHostelLocation.Text = gdvMain.GetFocusedRowCellValue("hstLocation").ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private bool CheckIfDataExists(string HstName, string HstCapacity, string HstDescription, string HstLocation, string HstRemarks, string HstNumber)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM tblHsHostels WHERE hstName = @HstName and hstNumber = @HstNumber and hstDescription = @HstDescription and hstCapacity = @HstCapacity and hstLocation = @HstLocation and hstRmks = @HstRemarks";
                ConnectionStringParameters.CloseConnection();
                ConnectionStringParameters.OpenConnection();
                SqlCommand comdx = new SqlCommand(sql, ConnectionStringParameters.connStrx);
                comdx.Parameters.AddWithValue("@HstName", HstName);
                comdx.Parameters.AddWithValue("@HstNumber", HstNumber);
                comdx.Parameters.AddWithValue("@HstDescription", HstDescription);
                comdx.Parameters.AddWithValue("@HstCapacity", HstCapacity);
                comdx.Parameters.AddWithValue("@HstLocation", HstLocation);
                comdx.Parameters.AddWithValue("@HstRemarks", HstRemarks);
                // Execute the command and retrieve the count value
                int count = (int)comdx.ExecuteScalar();
                // Return true if a matching record is found (count > 0), false otherwise
                return count > 0;
            }
            catch
            {
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
                    int idpkx = (int)gdvMain.GetFocusedRowCellValue("hstIDpk");
                    SqlCommand comdx = new SqlCommand("UPDATE tblHsHostels SET hstName = @hstName, hstDescription = @hstDescription, hstLocation = @hstLocation, hstRmks = @hstRmks, hstNumber = @hstNumber, hstCapacity = @hstCapacity WHERE hstIDpk = @idpkx", ConnectionStringParameters.connStrx);
                    comdx.Parameters.AddWithValue("@hstName", txtHostelName.Text);
                    comdx.Parameters.AddWithValue("@hstDescription", txtHostelDescription.Text);
                    comdx.Parameters.AddWithValue("@hstLocation", txtHostelLocation.Text);
                    comdx.Parameters.AddWithValue("@hstRmks", txtRemarks.Text);
                    comdx.Parameters.AddWithValue("@hstNumber", txtHostelNo.Text);
                    comdx.Parameters.AddWithValue("@hstCapacity", txtHostelCapacity.Text);
                    comdx.Parameters.AddWithValue("@idpkx", idpkx);
                    comdx.ExecuteNonQuery();
                    GetData();
                    DisplayData();
                    SelectIDpkRow();
                    MessageBox.Show("Updated Successfully", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CheckData()
        {
            try
            {
                //System.Windows.Forms.TextBox activeTextBox = this.ActiveControl as System.Windows.Forms.TextBox;
                // Retrieve the data from the UI inputs
                //string newData = activeTextBox.Text;
                string hstName = txtHostelName.Text;
                string hstDescription = txtHostelDescription.Text;
                string hstLocation = txtHostelLocation.Text;
                string hstRemarks = txtRemarks.Text;
                string hstNumber = txtHostelNo.Text;
                string hstCapacity = txtHostelCapacity.Text;

                // Query the database to check if the data already exists
                bool dataExists = CheckIfDataExists(hstName, hstCapacity, hstDescription, hstLocation, hstRemarks, hstNumber);

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
            catch
            {
                throw;
            }
        }

        private void xfrmHostel_Load(object sender, EventArgs e)
        {
            GetData();
            irud = 'r';
            btnSave.Enabled = false;
            txtHostelNo.Enabled = false;
            txtHostelCapacity.Enabled = false;
            txtRemarks.ReadOnly = true;
            txtHostelLocation.Enabled = false;
            txtHostelName.Enabled = false;
            txtHostelDescription.Enabled = false;

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
                if (irud == 'i')
                {
                    if (MessageBox.Show("Are you sure you want to save?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        ConnectionStringParameters.CloseConnection();
                        ConnectionStringParameters.OpenConnection();
                        SqlCommand comdx = new SqlCommand("Insert into tblHsHostels ( hstName, hstDescription, hstLocation, hstRmks,  hstNumber, hstCapacity) values ( @hstName, @hstDescription, @hstLocation, @hstRmks, @hstNumber, @hstCapacity)  ", ConnectionStringParameters.connStrx);
                        comdx.Parameters.AddWithValue("@hstName", txtHostelName.Text);
                        comdx.Parameters.AddWithValue("@hstDescription", txtHostelDescription.Text);
                        comdx.Parameters.AddWithValue("@hstLocation", txtHostelLocation.Text);
                        comdx.Parameters.AddWithValue("@hstRmks", txtRemarks.Text);
                        comdx.Parameters.AddWithValue("@hstNumber", txtHostelNo.Text);
                        comdx.Parameters.AddWithValue("@hstCapacity", txtHostelCapacity.Text);
                        comdx.ExecuteNonQuery();
                        GetData();
                        DisplayData();
                        SelectIDpkRow();
                        MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                
            }
            catch (Exception)
            {
                throw;
            }

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
                    btnNew.Text = "Cancel";
                    btnNew.Image = HostelApp.Properties.Resources.delete_16x16;
                    btnNew2.Text = "Cancel";
                    btnNew2.Image = HostelApp.Properties.Resources.delete_16x16;
                    txtHostelName.Text = string.Empty;
                    txtHostelDescription.Text = string.Empty;
                    txtHostelLocation.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
                    txtHostelNo.Text = string.Empty;
                    txtHostelCapacity.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
                    btnEdit.Enabled = false;
                }
                else if (irud == 'i')
                {
                    irud = 'r';
                    GetData();
                    DisplayData();
                    btnSave.Enabled = false;
                    txtHostelNo.Enabled = false;
                    txtHostelCapacity.Enabled = false;
                    txtRemarks.ReadOnly = true;
                    txtHostelLocation.Enabled = false;
                    txtHostelName.Enabled = false;
                    txtHostelDescription.Enabled = false;
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    btnNew.Text = "New";
                    btnNew.Image = HostelApp.Properties.Resources.newemployee_16x16;
                    btnNew2.Text = "New";
                    btnNew2.Image = HostelApp.Properties.Resources.newemployee_16x16;

                }


            }
            catch (Exception)
            {
            throw;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Clear the  data?", "Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string sql = "Delete From tblHsHostels where hstIDpk = " + gdvMain.GetFocusedRowCellValue("hstIDpk");
                    ConnectionStringParameters.CloseConnection();
                    ConnectionStringParameters.OpenConnection();
                    SqlCommand comdx = new SqlCommand("Delete From tblHsHostels where hstIDpk = " + gdvMain.GetFocusedRowCellValue("hstIDpk"), ConnectionStringParameters.connStrx);
                    comdx.ExecuteNonQuery();
                    GetData();
                    DisplayData();
                    SelectIDpkRow();
                }

            }
            catch
            {
                throw;
            }
        }

        private void gdvMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            DisplayData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetData();

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
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
                btnSave.Text = "Update";
                btnEdit.Text = "Cancel";
                btnEdit.Image = HostelApp.Properties.Resources.delete_16x16;
               
            }
          else if (irud == 'u')
            {
                irud = 'r';
                btnSave.Enabled = false;
                txtHostelNo.Enabled = false;
                txtHostelCapacity.Enabled = false;
                txtRemarks.ReadOnly = true;
                txtHostelLocation.Enabled = false;
                txtHostelName.Enabled = false;
                txtHostelDescription.Enabled = false;
                btnNew.Enabled = true;
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
                    btnNew.Text = "Cancel";
                    btnNew.Image = HostelApp.Properties.Resources.delete_16x16;
                    btnNew2.Text = "Cancel";
                    btnNew2.Image = HostelApp.Properties.Resources.delete_16x16;
                    txtHostelName.Text = string.Empty;
                    txtHostelDescription.Text = string.Empty;
                    txtHostelLocation.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
                    txtHostelNo.Text = string.Empty;
                    txtHostelCapacity.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
                    btnEdit.Enabled = false;
                }
                else if (irud == 'i')
                {
                    irud = 'r';
                    GetData();
                    DisplayData();
                    btnSave.Enabled = false;
                    txtHostelNo.Enabled = false;
                    txtHostelCapacity.Enabled = false;
                    txtRemarks.ReadOnly = true;
                    txtHostelLocation.Enabled = false;
                    txtHostelName.Enabled = false;
                    txtHostelDescription.Enabled = false;
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    btnNew.Text = "New";
                    btnNew.Image = HostelApp.Properties.Resources.newemployee_16x16;
                    btnNew2.Text = "New";
                    btnNew2.Image = HostelApp.Properties.Resources.newemployee_16x16;

                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void gdvMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DisplayData();
        }
    }
}