using MySql.Data.MySqlClient;
using Payroll_Management_System.Connections;
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

        public int emp_id { get; set; }
        public string attendance_batch_no { get; set; }
        public string cutoff_period { get; set; }

        string connString = frmLogin.connString;

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmOverviewPayroll frmOverviewPayroll = new frmOverviewPayroll();
                frmHome.DisplayForm(frmOverviewPayroll, frmHome.mainPanel);
            }
        }


        bool isSaved = false;
        public void load_data()
        {
            // header 
            var (employee_name, department, job_title) = GetPayslip.GetEmployeeInfo(emp_id);
            txtEmpName.Text = employee_name;
            txtDeptTitle.Text = department + " | " + job_title;

            // reference (attendance batch no. and cutoff period
            txtAttendanceBatchNo.Text = "Attendance Batch No. : "+attendance_batch_no;
            txtPeriod.Text = "Period: "+cutoff_period;
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

        private void frmViewPayslip_Load(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                load_data();
            }
            else
            {
                MessageBox.Show("saved na data kaya iba na dapat makikita");
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to approve this payslip?", "Message Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        string query = "UPDATE attendance_monitoring SET status = 'For Payroll' WHERE attendance_batch_no=@attendance_batch_no AND emp_id=@emp_id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no);
                        cmd.Parameters.AddWithValue("@emp_id", emp_id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Payslip has been approved.", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

                        if (frmHome.mainPanel != null)
                        {

                            frmOverviewPayroll frmOverviewPayroll = new frmOverviewPayroll();
                            frmHome.DisplayForm(frmOverviewPayroll, frmHome.mainPanel);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error"+ex);
                }
                
            }
            else
            {
                return;
            }
        }
    }
}
