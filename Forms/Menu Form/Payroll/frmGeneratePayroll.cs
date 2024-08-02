using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms.Menu_Form.Payroll
{
    public partial class frmGeneratePayroll : Form
    {
        public frmGeneratePayroll()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();
            frmOverviewPayroll frmOverviewPayroll = new frmOverviewPayroll();

            if (frmHome.mainPanel != null)
            {
                frmHome.DisplayForm(frmOverviewPayroll, frmHome.mainPanel);
            }
        }
    }
}
