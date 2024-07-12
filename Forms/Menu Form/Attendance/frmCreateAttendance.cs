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
            isOvertime.Checked = false;
            isNightPrem.Checked = false;
            isSpecial.Checked = false;
            isLegal.Checked = false;
            isRestDay.Checked = false;
            isVacation.Checked = false;
            isSick.Checked = false;
            isAbsences.Checked = false;
            isLate.Checked = false;
            isUndertime.Checked = false;
            isRemarks.Checked=false;    


            txtEmployeeName.SelectedItem=null;
            txtOvertime.Clear();
            txtNightprem.Clear();
            txtSpecialHoli.Clear();
            txtLegalHoli.Clear();
            txtSpecialHoli.Clear();
            txtRestDay.Clear();
            txtVacationL.Clear();
            txtSickL.Clear();
            txtAbsences.Clear();
            txtLates.Clear();
            txtUndertime.Clear();
            txtRemarks.Clear();

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
            txtRemarks.Enabled=false;   

            dgvAttendance.CurrentCell=null;
        }

        private void txtDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_employee();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool isDuplicate = false;

            if (string.IsNullOrEmpty(txtDepartment.Text))
            {
                MessageBox.Show("Please provide a department", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtEmployeeName.Text))
            {
                MessageBox.Show("Please provide an employee name", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgvAttendance.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvAttendance.Rows)
                    {
                        if (txtEmployeeName.Text == row.Cells["employee_name"].Value.ToString())
                        {
                            MessageBox.Show("Duplicate Entry. Please check your Employee Name", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isDuplicate = true;
                            break;
                        }
                    }
                }
                if (!isDuplicate)
                {
                    MessageBox.Show("Employee has been added successfully", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAttendance.Rows.Add(txtDepartment.Text, txtEmployeeName.Text, txtOvertime.Text, txtNightprem.Text, txtSpecialHoli.Text, txtLegalHoli.Text, txtRestDay.Text, txtVacationL.Text, txtSickL.Text, txtAbsences.Text, txtLates.Text, txtUndertime.Text,txtRemarks.Text);
                    default_textboxes();
                }
            }
        }
            
        public void check_tickboxes() // check kung may laman yung text field
        {
            isOvertime.Checked = !string.IsNullOrEmpty(txtOvertime.Text);
            isNightPrem.Checked = !string.IsNullOrEmpty(txtNightprem.Text);
            isSpecial.Checked = !string.IsNullOrEmpty(txtSpecialHoli.Text);
            isLegal.Checked = !string.IsNullOrEmpty(txtLegalHoli.Text);
            isRestDay.Checked = !string.IsNullOrEmpty(txtRestDay.Text);
            isSpecial.Checked = !string.IsNullOrEmpty(txtSpecialHoli.Text);
            isVacation.Checked = !string.IsNullOrEmpty(txtVacationL.Text);
            isSick.Checked = !string.IsNullOrEmpty(txtSickL.Text);
            isAbsences.Checked = !string.IsNullOrEmpty(txtAbsences.Text);
            isLate.Checked = !string.IsNullOrEmpty(txtLates.Text);
            isUndertime.Checked = !string.IsNullOrEmpty(txtUndertime.Text);
            isRemarks.Checked = !string.IsNullOrEmpty(txtRemarks.Text);
        }

        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAttendance.Rows.Count>0)
            {
                txtDepartment.Text = dgvAttendance.CurrentRow.Cells["department"].Value.ToString();
                txtEmployeeName.Text = dgvAttendance.CurrentRow.Cells["employee_name"].Value.ToString();
                txtOvertime.Text = dgvAttendance.CurrentRow.Cells["overtime"].Value.ToString();
                txtNightprem.Text = dgvAttendance.CurrentRow.Cells["night_premium"].Value.ToString();
                txtSpecialHoli.Text = dgvAttendance.CurrentRow.Cells["special_holiday"].Value.ToString();
                txtLegalHoli.Text = dgvAttendance.CurrentRow.Cells["legal_holiday"].Value.ToString();
                txtRestDay.Text = dgvAttendance.CurrentRow.Cells["rest_day"].Value.ToString();
                txtVacationL.Text = dgvAttendance.CurrentRow.Cells["vacation_leave"].Value.ToString();
                txtSickL.Text = dgvAttendance.CurrentRow.Cells["sick_leave"].Value.ToString();
                txtAbsences.Text = dgvAttendance.CurrentRow.Cells["absences"].Value.ToString();
                txtLates.Text = dgvAttendance.CurrentRow.Cells["lates"].Value.ToString();
                txtUndertime.Text = dgvAttendance.CurrentRow.Cells["under_time"].Value.ToString();
                txtRemarks.Text = dgvAttendance.CurrentRow.Cells["remarks"].Value.ToString();
            }

            check_tickboxes();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void isNightPrem_CheckedChanged(object sender, EventArgs e)
        {
            if (isNightPrem.Checked == true)
            {
                txtNightprem.Enabled = true;
                txtNightprem.Focus();
            }
            else
            {
                txtNightprem.Clear();
                txtNightprem.Enabled = false;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmOverviewAttendance frmOverviewAttendance = new frmOverviewAttendance();
                frmHome.DisplayForm(frmOverviewAttendance, frmHome.mainPanel);
            }
        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {

        }

        private void isSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (isSpecial.Checked == true)
            {
                txtSpecialHoli.Enabled = true;
                txtSpecialHoli.Focus();
            }
            else
            {
                txtSpecialHoli.Clear();
                txtSpecialHoli.Enabled = false;
            }
        }

        private void isLegal_CheckedChanged(object sender, EventArgs e)
        {
            if (isLegal.Checked == true)
            {
                txtLegalHoli.Enabled = true;
                txtLegalHoli.Focus();
            }
            else
            {
                txtLegalHoli.Clear();
                txtLegalHoli.Enabled = false;
            }
        }

        private void isRestDay_CheckedChanged(object sender, EventArgs e)
        {
            if (isRestDay.Checked == true)
            {
                txtRestDay.Enabled = true;
                txtRestDay.Focus();
            }
            else
            {
                txtRestDay.Clear();
                txtRestDay.Enabled = false;
            }
        }

        private void isVacation_CheckedChanged(object sender, EventArgs e)
        {
            if (isVacation.Checked == true)
            {
                txtVacationL.Enabled = true;
                txtVacationL.Focus();
            }
            else
            {
                txtVacationL.Clear();
                txtVacationL.Enabled = false;
            }
        }

        private void isSick_CheckedChanged(object sender, EventArgs e)
        {
            if (isSick.Checked == true)
            {
                txtSickL.Enabled = true;
                txtSickL.Focus();
            }
            else
            {
                txtSickL.Clear();
                txtSickL.Enabled = false;
            }
        }

        private void isAbsences_CheckedChanged(object sender, EventArgs e)
        {
            if (isAbsences.Checked == true)
            {
                txtAbsences.Enabled = true;
                txtAbsences.Focus();
            }
            else
            {
                txtAbsences.Clear();
                txtAbsences.Enabled = false;
            }
        }

        private void isLate_CheckedChanged(object sender, EventArgs e)
        {
            if (isLate.Checked == true)
            {
                txtLates.Enabled = true;
                txtLates.Focus();
            }
            else
            {
                txtLates.Clear();
                txtLates.Enabled = false;
            }
        }

        private void isUndertime_CheckedChanged(object sender, EventArgs e)
        {
            if (isUndertime.Checked == true)
            {
                txtUndertime.Enabled = true;
                txtUndertime.Focus();
            }
            else
            {
                txtUndertime.Clear();
                txtUndertime.Enabled = false;
            }
        }

        private void txtOvertime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clear");
            default_textboxes();
            txtDepartment.SelectedItem = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.Rows.Count>0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Message Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow rows in dgvAttendance.SelectedRows)
                    {
                        dgvAttendance.Rows.RemoveAt(rows.Index);
                    }
                    default_textboxes();
                }
                return;
                
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.SelectedRows.Count>0)
            {
                DataGridViewRow selectedRow = dgvAttendance.SelectedRows[0];

                selectedRow.Cells["overtime"].Value = txtOvertime.Text;
                selectedRow.Cells["night_premium"].Value = txtNightprem.Text;
                selectedRow.Cells["special_holiday"].Value = txtSpecialHoli.Text;
                selectedRow.Cells["legal_holiday"].Value = txtLegalHoli.Text;
                selectedRow.Cells["rest_day"].Value = txtRestDay.Text;
                selectedRow.Cells["vacation_leave"].Value = txtVacationL.Text;
                selectedRow.Cells["sick_leave"].Value = txtSickL.Text;
                selectedRow.Cells["absences"].Value = txtAbsences.Text;
                selectedRow.Cells["lates"].Value = txtLates.Text;
                selectedRow.Cells["under_time"].Value = txtUndertime.Text;
                selectedRow.Cells["remarks"].Value = txtRemarks.Text;
            }

            MessageBox.Show("Data has been updated successfully", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            default_textboxes();
        }

        private void isRemarks_CheckedChanged(object sender, EventArgs e)
        {
            if (isRemarks.Checked == true)
            {
                txtRemarks.Enabled = true;
                txtRemarks.Focus();
            }
            else
            {
                txtRemarks.Clear();
                txtRemarks.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmSaveAttendance frmSaveAttendance = new frmSaveAttendance();
            frmSaveAttendance.ShowDialog();

        }
    }
}
