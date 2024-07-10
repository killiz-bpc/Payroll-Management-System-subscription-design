using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms.Menu_Form.Attendance
{
    public partial class frmOverviewAttendance : Form
    {
        public frmOverviewAttendance()
        {
            InitializeComponent();
        }

        private void btnCreateAttendance_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if(frmHome.mainPanel != null)
            {
                frmCreateAttendance frmCreateAttendance = new frmCreateAttendance();
                frmHome.DisplayForm(frmCreateAttendance,frmHome.mainPanel);
            }
        }
    }
}
