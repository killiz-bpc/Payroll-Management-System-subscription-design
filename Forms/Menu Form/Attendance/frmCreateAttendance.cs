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
using MySql.Data.MySqlClient;

namespace Payroll_Management_System.Forms.Menu_Form.Attendance
{
    public partial class frmCreateAttendance : Form
    {
        public frmCreateAttendance()
        {
            InitializeComponent();
        }

        public string connString = frmLogin.connString;

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void isOvertime_CheckedChanged(object sender, EventArgs e)
        {
            if (isOvertime.Checked == true)
            {
                txtOvertime.Enabled = true;
                txtOvertime.Focus();
            }
            else
            {
                txtOvertime.Clear();
                txtOvertime.Enabled = false;
            }
        }

        private void frmCreateAttendance_Load(object sender, EventArgs e)
        {
            txtOvertime.Enabled = false;

            List<string> department = GetData.GetDepartments();

            foreach(string departments in department)
            {
                txtDepartment.Items.Add(departments);
            }

            default_textboxes();

        }

        public void load_employee()
        {
            txtEmployeeName.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT emp_id, last_name, first_name FROM employee_information where department=@department";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string first_name = reader.GetString("first_name");
                    string last_name = reader.GetString("last_name");

                    string full_name = last_name+", "+first_name;
                    txtEmployeeName.Items.Add(full_name);
                    
                }
                conn.Dispose();


            }
        }

        public void default_textboxes()
        {
            txtOvertime.Enabled=false;
            txtNightprem.Enabled=false;
            txtSpecialHoli.Enabled=false;
            txtLegalHoli.Enabled=false;
            txtSpecialHoli.Enabled=false;
            txtRestDay.Enabled=false;
            txtVacationL.Enabled=false;
            txtSickL.Enabled=false;
            txtAbsences.Enabled=false;
            txtLates.Enabled=false;
            txtUndertime.Enabled=false;
        }

        private void txtDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_employee();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dgvAttendance.Rows.Add(txtDepartment.Text,txtEmployeeName.Text,txtOvertime.Text,txtNightprem.Text);

        }

        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAttendance.Rows.Count>0)
            {
                txtEmployeeName.Text = dgvAttendance.CurrentRow.Cells["employee_name"].Value.ToString();
            }
        }
    }
}
