using MySql.Data.MySqlClient;
using Payroll_Management_System.Connections;
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

        string connString = frmLogin.connString;
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();
            frmOverviewPayroll frmOverviewPayroll = new frmOverviewPayroll();

            if (frmHome.mainPanel != null)
            {
                frmHome.DisplayForm(frmOverviewPayroll, frmHome.mainPanel);
            }
        }

        public void load_attendance_batch_no()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT attendance_batch_no FROM attendance_monitoring where status='For Payroll'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        string attendance_batch_no = sdr.GetString("attendance_batch_no");
                        txtAttendanceBatch.Items.Add(attendance_batch_no);
                    }

                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message"+ex);
            }
        }

        private void frmGeneratePayroll_Load(object sender, EventArgs e)
        {
            load_attendance_batch_no();
            panelEmployeeDetails.Visible=false; 
        }


        public void load_department()
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT department FROM attendance_monitoring where attendance_batch_no=@attendance_batch_no AND status='For Payroll'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@attendance_batch_no", txtAttendanceBatch.Text);

                    MySqlDataReader sdr = cmd.ExecuteReader();

                    txtDepartment.Items.Clear();
                    while (sdr.Read())
                    {
                        string department = sdr.GetString("department");
                        txtDepartment.Items.Add(department);
                    }
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message"+ex);
            }
        }

        private void txtAttendanceBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = false;
            txtDepartment.Items.Clear();
            load_department();
            
        }

        public void load_data()
        {
            try
            {
                panelEmployeeDetails.Visible=true ;
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT payroll_process_tb.emp_id, employee_information.employee_name, employee_information.job_title, payroll_process_tb.basic_salary, payroll_process_tb.gross_salary, payroll_process_tb.total_deductions, payroll_process_tb.net_salary FROM payroll_process_tb INNER JOIN employee_information ON employee_information.emp_id = payroll_process_tb.emp_id WHERE payroll_process_tb.attendance_batch_no=@attendance_batch_no AND payroll_process_tb.department=@department";
                    //string query = "SELECT emp_id, employee_name, basic_salary, gross_salary, total_deductions, net_salary FROM payroll_process_tb where attendance_batch_no=@attendance_batch_no AND department=@department";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@attendance_batch_no", txtAttendanceBatch.Text);
                    cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }

                    dgvPayroll.DataSource = dt;

                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex, "Message Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            load_data();

        }

        private void txtDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoad.PerformClick();
        }

        private void dgvPayroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPayroll.Columns["view_more"].Index && e.RowIndex >= 0)
            {
                dgvPayroll.CurrentCell = dgvPayroll.Rows[e.RowIndex].Cells[e.ColumnIndex];

                int emp_id = Convert.ToInt32(dgvPayroll.CurrentRow.Cells["emp_id"].Value.ToString());
                frmPrintPayslip frmPrintPayslip = new frmPrintPayslip();
                frmPrintPayslip.emp_id = emp_id;
                frmPrintPayslip.attendance_batch_no = txtAttendanceBatch.Text;
                frmPrintPayslip.ShowDialog();

            }
        }
    }
}
