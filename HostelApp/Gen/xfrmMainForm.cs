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

namespace HostelApp.Gen
{
    public partial class xfrmMainForm : DevExpress.XtraBars.TabForm
    {
        public xfrmMainForm()
        {
            InitializeComponent();
        }
        
        private void aceHostelApplication_Click_1(object sender, EventArgs e)
        {
            xfrmHrHostelApplicationfrm newForm = new xfrmHrHostelApplicationfrm();
            newForm.MdiParent = this;
            newForm.Show();
        }
    }
}