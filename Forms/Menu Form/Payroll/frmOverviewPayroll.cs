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
using Payroll_Management_System.Connections;
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

        public string cutoff_period { get; set; }


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
            panelSlip.Visible=false;
            btnLoad.Enabled=false;
            load_attendance_batch_no();
        }

        public void load_department()
        {
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT department, cutoff_period FROM attendance_monitoring where attendance_batch_no=@attendance_batch_no AND status='Approved'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@attendance_batch_no",txtAttendanceBatch.Text);

                    MySqlDataReader sdr = cmd.ExecuteReader();

                    txtDepartment.Items.Clear();
                    while (sdr.Read())
                    {

                        string department = sdr.GetString("department");
                        txtDepartment.Items.Add(department);

                        string cutoff_period = sdr.GetString("cutoff_period");
                        this.cutoff_period = cutoff_period;
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
            panelSlip.Visible=false;
            btnLoad.Enabled = false;
            load_department();
        }


        public void load_data()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT emp_id, employee_name FROM attendance_monitoring where attendance_batch_no=@attendance_batch_no AND department=@department AND status='Approved'";
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
            btnLoad.PerformClick();
            panelSlip.Visible=true;
            btnLoad.Enabled=true;
        }

        public void check_payroll_tb()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM payroll_process_tb WHERE emp_id=@emp_id AND attendance_batch_no=@attendance_batch_no";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@emp_id", GetPayslipDetails.emp_id);
                    cmd.Parameters.AddWithValue("@attendance_batch_no", txtAttendanceBatch.Text);
                    int count= Convert.ToInt32(cmd.ExecuteScalar());
                    
                    if(count>0) //match data
                    {
                        GetPayslipDetails.isSaved =true;
                    }
                    else
                    {
                        GetPayslipDetails.isSaved=false;
                    }



                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ex, "Message Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvPayslip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPayslip.Columns["view_more"].Index && e.RowIndex >= 0)
            {
                dgvPayslip.CurrentCell = dgvPayslip.Rows[e.RowIndex].Cells[e.ColumnIndex];

                int emp_id = Convert.ToInt32(dgvPayslip.CurrentRow.Cells["emp_id"].Value.ToString());


                frmViewPayslip frmViewPayslip = new frmViewPayslip();

                GetPayslipDetails.emp_id = emp_id;
                GetPayslipDetails.attendance_batch_no= txtAttendanceBatch.Text;
                GetPayslipDetails.cutoff_period =cutoff_period;

                check_payroll_tb();

               
                frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

                if (frmHome.mainPanel != null)
                {
                    frmHome.DisplayForm(frmViewPayslip, frmHome.mainPanel);
                }


            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load_data();
            panelSlip.Visible=true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();
            frmGeneratePayroll frmGeneratePayroll = new frmGeneratePayroll();

            if (frmHome.mainPanel != null)
            {
                frmHome.DisplayForm(frmGeneratePayroll, frmHome.mainPanel);
            }
        }
    }
}
