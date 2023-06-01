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
using HostelApp.HR;
using HostelApp.Hs;

namespace HostelApp.Gen
{
    public partial class xfrmMain : DevExpress.XtraEditors.XtraForm
    {
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
    }
}