using Payroll_Management_System.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms.Menu_Form.Attendance
{
    public partial class frmSaveAttendance : Form
    {
        public frmSaveAttendance()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void load_default()
        {
            txtDateFrom.Clear();
            txtDateTo.Clear();

            txtPreparedBy.Text = GetData.GetEmployeeName(frmLogin.lastName, frmLogin.firstName, "");

            txtPeriod.Enabled = false;
        }
        private void frmSaveAttendance_Load(object sender, EventArgs e)
        {
            load_default();
        }

        private void isNewBatch_CheckedChanged(object sender, EventArgs e)
        {
            load_default();
            if (isNewBatch.Checked == true)
            {
                
                txtAttendanceBatch.SelectedItem = null;
                txtAttendanceBatch.Enabled = false;

                txtPeriod.Enabled=true;
                txtPeriod.Focus();
            }
            else
            {
                txtAttendanceBatch.Enabled = true;

                txtPeriod.SelectedItem = null;
                txtPeriod.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateCreated.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void txtPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtPeriod.SelectedIndex == 0)
            {

                // 11 to 26th 
                DateTime date_from = DateTime.Now.AddMonths(-1);
                date_from = new DateTime(date_from.Year, date_from.Month, 26);
                txtDateFrom.Text = date_from.ToString("yyyy-MM-dd");

                DateTime date_to = DateTime.Now;
                date_to = new DateTime(date_to.Year, date_to.Month, 10);
                txtDateTo.Text = date_to.ToString("yyyy-MM-dd");

            }
            else
            {
                DateTime date_from = DateTime.Now;
                date_from = new DateTime(date_from.Year, date_from.Month, 11);
                txtDateFrom.Text = date_from.ToString("yyyy-MM-dd");

                DateTime date_to = DateTime.Now;
                date_to = new DateTime(date_to.Year, date_to.Month, 25);
                txtDateTo.Text = date_to.ToString("yyyy-MM-dd");
            }
        }
    }
}
