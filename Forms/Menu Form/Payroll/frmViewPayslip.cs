using Payroll_Management_System.Forms.Menu_Form.Attendance;
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
    public partial class frmViewPayslip : Form
    {
        public frmViewPayslip()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmOverviewPayroll frmOverviewPayroll = new frmOverviewPayroll();
                frmHome.DisplayForm(frmOverviewPayroll, frmHome.mainPanel);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmEditPayslip frmEditPayslip = new frmEditPayslip();

            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmHome.DisplayForm(frmEditPayslip, frmHome.mainPanel);
            }
        }
    }
}
