using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Payroll_Management_System.Forms.Menu_Form.Attendance;

namespace Payroll_Management_System.Forms.Menu_Form.Payroll
{
    public partial class frmOverviewPayroll : Form
    {
        public frmOverviewPayroll()
        {
            InitializeComponent();
        }

        string connString = frmLogin.GetConnectionString();




        public void load_attendance_batch_no()
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT attendance_batch_no FROM attendance_monitoring where status='Approved'";
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

        private void frmOverviewPayroll_Load(object sender, EventArgs e)
        {
            load_attendance_batch_no();
        }

        public void load_department()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT department FROM payroll_process_tb where attendance_batch_no=@attendance_batch_no";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@attendance_batch_no",txtAttendanceBatch.Text);

                    MySqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        txtDepartment.Items.Clear();
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
            load_department();
        }


        public void load_data()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT emp_id, employee_name FROM payroll_process_tb where attendance_batch_no=@attendance_batch_no AND department=@department";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@attendance_batch_no", txtAttendanceBatch.Text);
                    cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                     
                    dgvPayslip.DataSource = dt;

                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message"+ex);
            }
        }

        private void txtDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void dgvPayslip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPayslip.Columns["view_more"].Index && e.RowIndex >= 0)
            {
                dgvPayslip.CurrentCell = dgvPayslip.Rows[e.RowIndex].Cells[e.ColumnIndex];

                string employee_id = dgvPayslip.CurrentRow.Cells["emp_id"].Value.ToString();
                frmEditPayslip frmEditPayslip = new frmEditPayslip();

                frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

                if (frmHome.mainPanel != null)
                {
                    frmHome.DisplayForm(frmEditPayslip, frmHome.mainPanel);
                }


            }
        }
    }
}
