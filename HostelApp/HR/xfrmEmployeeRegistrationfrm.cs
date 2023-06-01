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
       

namespace HostelApp.Hs
{
    public partial class xfrmEmployeeRegistrationfrm : DevExpress.XtraEditors.XtraForm
    {
        public xfrmEmployeeRegistrationfrm()
        {
            InitializeComponent();
        }

        






        private void GetData()
        {
            try
            {
                SqlCommand comdx = new SqlCommand("select * from vwHrEmps", ConnectionStringParameters.connStrx);
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
        private void DisplayData()
        {
            try
            {
                txtStaffNo.Text = gdvMain.GetFocusedRowCellValue("empStaffNo").ToString();
                txtFirstName.Text = gdvMain.GetFocusedRowCellValue("empFirstName").ToString();
                txtLastName.Text = gdvMain.GetFocusedRowCellValue("empLastName").ToString();
                txtOtherNames.Text = gdvMain.GetFocusedRowCellValue("empOtherName").ToString();
              
                cbxJobTitle.Text = gdvMain.GetFocusedRowCellValue("jbtName").ToString();
                cbxGender.Text = gdvMain.GetFocusedRowCellValue("gndName").ToString();
                txtRemarks.Text = gdvMain.GetFocusedRowCellValue("empRmks").ToString();
                txtMobileNo.Text = gdvMain.GetFocusedRowCellValue("empMobileNo").ToString();
                dteDateOfBirth.Text = gdvMain.GetFocusedRowCellValue("empDoB").ToString();
                dteRecruitmentDate.Text = gdvMain.GetFocusedRowCellValue("empRecriutmentDate").ToString();
                txtEmail.Text = gdvMain.GetFocusedRowCellValue("empEmail").ToString();

            }
            catch (Exception)
            {
                throw;
            }
        }


        private void xfrmEmployeeRegistrationfrm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void gdcMain_Click(object sender, EventArgs e)
        {
            
            
        }

        private void gdvMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DisplayData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Are you sure you want to save?","Save?",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                ConnectionStringParameters.CloseConnection();
                ConnectionStringParameters.OpenConnection();
                SqlCommand comdx = new SqlCommand("Insert into tblHrEmployees (empStaffNo,empLastName,empOtherName,empFirstName) values (@empStaffNo,@empLastName,@empOtherName,@empFirstName)  ", ConnectionStringParameters.connStrx);

                comdx.Parameters.AddWithValue("@empStaffNo", txtStaffNo.Text);
                comdx.Parameters.AddWithValue("@empLastName", txtLastName.Text);
                comdx.Parameters.AddWithValue("@empOtherName", txtOtherNames.Text);
                comdx.Parameters.AddWithValue("@empFirstName", txtFirstName.Text);

                comdx.ExecuteNonQuery();
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to enter new data?", "Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    
                    
                        txtStaffNo.Text = string.Empty;
                        txtFirstName.Text = string.Empty;
                        txtLastName.Text = string.Empty;
                        txtOtherNames.Text = string.Empty;
                        txtRemarks.Text = string.Empty;
                        txtMobileNo.Text = string.Empty;
                        txtEmail.Text = string.Empty;
                        dteDateOfBirth.Text = string.Empty;
                        dteRecruitmentDate.Text = string.Empty;
                        cbxGender.Text = string.Empty;
                        cbxJobTitle.Text = string.Empty;
                        txtIDNo.Text = string.Empty;
                        cbxIDType.Text = string.Empty;
                        txtAddress.Text = string.Empty;

                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}