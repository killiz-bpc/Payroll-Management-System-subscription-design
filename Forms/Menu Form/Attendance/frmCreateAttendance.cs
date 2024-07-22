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
using System.Collections;
using Microsoft.Office.Interop.Excel;
using System.Configuration;

namespace Payroll_Management_System.Forms.Menu_Form.Attendance
{
    public partial class frmCreateAttendance : Form
    {
        public frmCreateAttendance()
        {
            InitializeComponent();
        }

        public string connString = frmLogin.connString;

        public string attendance_batch_no { get;set; }
        public string date_from {  get;set; }
        public string date_to {  get;set; }
        public string status {  get;set; }
        


        bool isNewAttendance = true;


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

        public void load_data()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT department, emp_id, employee_name, absences, lates, under_time, night_premium, over_time, restday_duty, vacation_leave, sick_leave, legal_holiday, special_holiday, maternity_leave, paternity_leave, bereavement_leave, emergency_leave, magnacarta_leave, remarks FROM attendance_monitoring WHERE attendance_batch_no=@attendance_batch_no";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@attendance_batch_no",attendance_batch_no.ToString());
                cmd.ExecuteNonQuery();
                System.Data.DataTable dt = new System.Data.DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                dgvAttendance.Refresh();
                dgvAttendance.DataSource=dt;
                dgvAttendance.CurrentCell=null;

                conn.Dispose();
            }
        }
        private void frmCreateAttendance_Load(object sender, EventArgs e)
        {



            if (attendance_batch_no != null)
            {
                isNewAttendance = false;
                labelAttendance.Text = "Edit Attendance";
                string label_string = attendance_batch_no;
                labelAttendanceDetails.Text = "Attendance Details: "+label_string;
                load_data();

                btnSave.Text = "Approve Batch";
            }

            // load department
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
                string query = "SELECT emp_id, employee_name FROM employee_information where department=@department";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string employee_name = reader.GetString("employee_name");
                    txtEmployeeName.Items.Add(employee_name);
                    
                }
                conn.Dispose();


            }
        }

        public void default_textboxes()
        {
            isAbsences.Checked = false;
            isLate.Checked = false;
            isUndertime.Checked = false;
            isOvertime.Checked = false;
            isNightPrem.Checked = false;
            isRestDay.Checked = false;
            isVacation.Checked = false;
            isSick.Checked = false;
            isLegal.Checked = false;
            isSpecial.Checked = false;
            isMaternity.Checked = false;
            isPaternity.Checked = false;
            isBereavement.Checked = false;
            isEmergency.Checked = false;
            isMagnacarta.Checked=false;
            isRemarks.Checked=false;    


            txtEmployeeName.SelectedItem=null;
            txtEmpID.Clear();
            txtAbsences.Clear();
            txtLates.Clear();
            txtUndertime.Clear();
            txtOvertime.Clear();
            txtNightprem.Clear();
            txtRestDay.Clear();
            txtVacationL.Clear();
            txtSickL.Clear();
            txtLegalHoli.Clear();
            txtSpecialHoli.Clear();
            txtMaternityL.Clear();
            txtPaternityL.Clear();
            txtBereavementL.Clear();
            txtEmergencyL.Clear();
            txtMagnaL.Clear();
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

            txtMaternityL.Enabled=false;
            txtPaternityL.Enabled=false;
            txtBereavementL.Enabled=false;
            txtEmergencyL.Enabled=false;
            txtMagnaL.Enabled=false;


            dgvAttendance.CurrentCell=null;
        }


        private void txtDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_employee();
        }

        public void add_existing_data()
        {
            add_employee_id();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query;
                conn.Open();
                query= "INSERT INTO attendance_monitoring (attendance_batch_no, date_from, date_to, status,  department, emp_id, employee_name, absences, lates, under_time, night_premium, over_time, restday_duty, vacation_leave, sick_leave, legal_holiday, special_holiday, maternity_leave, paternity_leave, bereavement_leave, emergency_leave, magnacarta_leave, remarks) VALUES(@attendance_batch_no, @date_from, @date_to, 'Prepared',  @department, @emp_id, @employee_name, @absences, @lates, @under_time, @night_premium, @over_time, @restday_duty, @vacation_leave, @sick_leave, @legal_holiday, @special_holiday, @maternity_leave, @paternity_leave, @bereavement_leave, @emergency_leave, @magnacarta_leave, @remarks)"; 
                
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no);
                cmd.Parameters.AddWithValue("@date_from", date_from);
                cmd.Parameters.AddWithValue("@date_to", date_to);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@employee_name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@emp_id", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@absences", txtAbsences.Text);
                cmd.Parameters.AddWithValue("@lates", txtLates.Text);
                cmd.Parameters.AddWithValue("@under_time", txtUndertime.Text);
                cmd.Parameters.AddWithValue("@over_time", txtOvertime.Text);
                cmd.Parameters.AddWithValue("@night_premium", txtNightprem.Text);
                cmd.Parameters.AddWithValue("@restday_duty", txtRestDay.Text);
                cmd.Parameters.AddWithValue("@vacation_leave", txtVacationL.Text);
                cmd.Parameters.AddWithValue("@sick_leave", txtSickL.Text);
                cmd.Parameters.AddWithValue("@legal_holiday", txtLegalHoli.Text);
                cmd.Parameters.AddWithValue("@special_holiday", txtSpecialHoli.Text);
                cmd.Parameters.AddWithValue("@maternity_leave", txtMaternityL.Text);
                cmd.Parameters.AddWithValue("@paternity_leave", txtPaternityL.Text);

                cmd.Parameters.AddWithValue("@bereavement_leave", txtBereavementL.Text);
                cmd.Parameters.AddWithValue("@emergency_leave", txtEmergencyL.Text);
                cmd.Parameters.AddWithValue("@magnacarta_leave", txtMagnaL.Text);
                cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("added");
                conn.Dispose();




                load_data();
            }

        }

        public void add_employee_id()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT emp_id FROM employee_information where department=@department AND employee_name=@employee_name";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@employee_name", txtEmployeeName.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtEmpID.Text= reader.GetInt32("emp_id").ToString();  //insert employee ID
                }
                conn.Dispose();
            }

        }

        public void attendance_computation()
        {

            //Deductions
            double undertime = string.IsNullOrEmpty(txtUndertime.Text) ? 0.0 : Convert.ToDouble(txtUndertime.Text);
            double absent = string.IsNullOrEmpty(txtAbsences.Text) ? 0.0 : Convert.ToDouble(txtAbsences.Text);
            double late = string.IsNullOrEmpty(txtLates.Text) ? 0.0 : Convert.ToDouble(txtLates.Text);

            var (deduct_late, deduct_absent) = GetData.GetDeduction(Convert.ToInt32(txtEmpID.Text), undertime, absent, late);
            //Addition
            double over_time = string.IsNullOrEmpty(txtOvertime.Text) ? 0.0 : Convert.ToDouble(txtOvertime.Text);
            double night_premium = string.IsNullOrEmpty(txtNightprem.Text) ? 0.0 : Convert.ToDouble(txtNightprem.Text);
            double restday_duty = string.IsNullOrEmpty(txtRestDay.Text) ? 0.0 : Convert.ToDouble(txtRestDay.Text);
            double legal_holiday = string.IsNullOrEmpty(txtLegalHoli.Text) ? 0.0 : Convert.ToDouble(txtLegalHoli.Text);
            double special_holiday = string.IsNullOrEmpty(txtSpecialHoli.Text) ? 0.0 : Convert.ToDouble(txtSpecialHoli.Text);


            var (addition_overtime, addition_nightpremium, addition_restdayduty, addition_legalholiday, addition_specialholiday) = GetData.GetAddition(Convert.ToInt32(txtEmpID.Text), over_time, night_premium, restday_duty, legal_holiday, special_holiday);



        }
        public void add_new_data()
        {
            add_employee_id();
            
            MessageBox.Show("Employee has been added successfully", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvAttendance.Rows.Add(txtDepartment.Text, txtEmpID.Text, txtEmployeeName.Text, txtAbsences.Text, txtLates.Text, txtUndertime.Text, txtOvertime.Text, txtNightprem.Text, txtRestDay.Text, txtVacationL.Text, txtSickL.Text, txtLegalHoli.Text, txtSpecialHoli.Text, txtMaternityL.Text, txtPaternityL.Text, txtBereavementL.Text,  txtEmergencyL.Text, txtMagnaL.Text, txtRemarks.Text);

            attendance_computation();

            default_textboxes();

        }

        private void CheckAllCheckBoxStates(Panel infoPanel)
        {
            // Iterate through all controls in the container
            foreach (Control control in infoPanel.Controls)
            {
                // If the control is a CheckBox
                if (control is System.Windows.Forms.CheckBox checkBox)
                {
                    // Process the Checked property
                    if (!checkBox.Checked)
                    {
                        // Do something if the CheckBox is checked
                        MessageBox.Show($"{checkBox.Name} is checked.");
                    }
                    else
                    {
                        // Do something if the CheckBox is not checked
                        MessageBox.Show($"{checkBox.Name} is not checked.");
                    }
                }

            }
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
                    
                    if (!isNewAttendance)
                    {
                        add_existing_data();  // existing batch no
                    }
                    else
                    {
                        add_new_data();     // new batch no
                    }
                  
                }

              
      

                default_textboxes();
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

            isMaternity.Checked = !string.IsNullOrEmpty(txtMaternityL.Text);
            isPaternity.Checked = !string.IsNullOrEmpty(txtPaternityL.Text);
            isBereavement.Checked = !string.IsNullOrEmpty(txtBereavementL.Text);
            isEmergency.Checked = !string.IsNullOrEmpty(txtEmergencyL.Text);
            isMagnacarta.Checked = !string.IsNullOrEmpty(txtMagnaL.Text);


        }

        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAttendance.Rows.Count>0)
            {

                txtDepartment.Text = dgvAttendance.CurrentRow.Cells["department"].Value.ToString();
                txtEmpID.Text = dgvAttendance.CurrentRow.Cells["emp_id"].Value.ToString();
                txtEmployeeName.Text = dgvAttendance.CurrentRow.Cells["employee_name"].Value.ToString();
                txtOvertime.Text = dgvAttendance.CurrentRow.Cells["over_time"].Value.ToString();
                txtNightprem.Text = dgvAttendance.CurrentRow.Cells["night_premium"].Value.ToString();
                txtSpecialHoli.Text = dgvAttendance.CurrentRow.Cells["special_holiday"].Value.ToString();
                txtLegalHoli.Text = dgvAttendance.CurrentRow.Cells["legal_holiday"].Value.ToString();
                txtRestDay.Text = dgvAttendance.CurrentRow.Cells["restday_duty"].Value.ToString();
                txtVacationL.Text = dgvAttendance.CurrentRow.Cells["vacation_leave"].Value.ToString();
                txtSickL.Text = dgvAttendance.CurrentRow.Cells["sick_leave"].Value.ToString();
                txtAbsences.Text = dgvAttendance.CurrentRow.Cells["absences"].Value.ToString();
                txtLates.Text = dgvAttendance.CurrentRow.Cells["lates"].Value.ToString();
                txtUndertime.Text = dgvAttendance.CurrentRow.Cells["under_time"].Value.ToString();
                txtRemarks.Text = dgvAttendance.CurrentRow.Cells["remarks"].Value.ToString();

                txtMaternityL.Text = dgvAttendance.CurrentRow.Cells["maternity_leave"].Value.ToString();
                txtPaternityL.Text = dgvAttendance.CurrentRow.Cells["paternity_leave"].Value.ToString();
                txtBereavementL.Text = dgvAttendance.CurrentRow.Cells["bereavement_leave"].Value.ToString();
                txtEmergencyL.Text = dgvAttendance.CurrentRow.Cells["emergency_leave"].Value.ToString();
                txtMagnaL.Text = dgvAttendance.CurrentRow.Cells["magnacarta_leave"].Value.ToString();


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
            frmHome frmHome = System.Windows.Forms.Application.OpenForms.OfType<frmHome>().FirstOrDefault();

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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_employee_id();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            default_textboxes();
            txtDepartment.SelectedItem = null;
        }

        public void delete_existing_data()
        {
            if (dgvAttendance.SelectedRows.Count > 0)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {

                    conn.Open();
                    string query = "DELETE FROM attendance_monitoring WHERE emp_id=@emp_id AND attendance_batch_no=@attendance_batch_no";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no);
                    cmd.Parameters.AddWithValue("@emp_id", txtEmpID.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("deleted");
                    conn.Dispose();

                    load_data();
                }
            }
            
        }

        public void delete_new_data()
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
                    
                }
                return;

            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isNewAttendance)
            {
                delete_existing_data();  // existing batch no
            }
            else
            {
                delete_new_data();     // new batch no

            }


            default_textboxes();

        }

        public void update_new_data()
        {
            if (dgvAttendance.SelectedRows.Count>0)
            {
                DataGridViewRow selectedRow = dgvAttendance.SelectedRows[0];

                selectedRow.Cells["over_time"].Value = txtOvertime.Text;
                selectedRow.Cells["night_premium"].Value = txtNightprem.Text;
                selectedRow.Cells["special_holiday"].Value = txtSpecialHoli.Text;
                selectedRow.Cells["legal_holiday"].Value = txtLegalHoli.Text;
                selectedRow.Cells["restday_duty"].Value = txtRestDay.Text;
                selectedRow.Cells["vacation_leave"].Value = txtVacationL.Text;
                selectedRow.Cells["sick_leave"].Value = txtSickL.Text;
                selectedRow.Cells["absences"].Value = txtAbsences.Text;
                selectedRow.Cells["lates"].Value = txtLates.Text;
                selectedRow.Cells["under_time"].Value = txtUndertime.Text;
                selectedRow.Cells["remarks"].Value = txtRemarks.Text;

                selectedRow.Cells["maternity_leave"].Value = txtMaternityL.Text;
                selectedRow.Cells["paternity_leave"].Value = txtPaternityL.Text;
                selectedRow.Cells["bereavement_leave"].Value = txtBereavementL.Text;
                selectedRow.Cells["emergency_leave"].Value = txtEmergencyL.Text;
                selectedRow.Cells["magnacarta_leave"].Value = txtMagnaL.Text;


                attendance_computation();
                MessageBox.Show("Data has been updated successfully", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                default_textboxes();
            }

           
            
        }


        public void update_existing_data()
        {
            if (dgvAttendance.SelectedRows.Count>0)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "UPDATE attendance_monitoring SET absences=@absences, lates=@lates, under_time=@under_time, night_premium=@night_premium, over_time=@over_time, restday_duty=@restday_duty, vacation_leave=@vacation_leave, sick_leave=@sick_leave, legal_holiday=@legal_holiday, special_holiday=@special_holiday, maternity_leave=@maternity_leave, paternity_leave=@paternity_leave, bereavement_leave=@bereavement_leave, emergency_leave=@emergency_leave, magnacarta_leave=@magnacarta_leave, remarks=@remarks WHERE emp_id=@emp_id AND attendance_batch_no=@attendance_batch_no";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@emp_id", txtEmpID.Text);
                    cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no);

                    cmd.Parameters.AddWithValue("@absences", txtAbsences.Text);
                    cmd.Parameters.AddWithValue("@lates", txtLates.Text);
                    cmd.Parameters.AddWithValue("@under_time", txtUndertime.Text);
                    cmd.Parameters.AddWithValue("@over_time", txtOvertime.Text);
                    cmd.Parameters.AddWithValue("@night_premium", txtNightprem.Text);
                    cmd.Parameters.AddWithValue("@restday_duty", txtRestDay.Text);
                    cmd.Parameters.AddWithValue("@vacation_leave", txtVacationL.Text);
                    cmd.Parameters.AddWithValue("@sick_leave", txtSickL.Text);
                    cmd.Parameters.AddWithValue("@legal_holiday", txtLegalHoli.Text);
                    cmd.Parameters.AddWithValue("@special_holiday", txtSpecialHoli.Text);

                    cmd.Parameters.AddWithValue("@maternity_leave", txtMaternityL.Text);
                    cmd.Parameters.AddWithValue("@paternity_leave", txtPaternityL.Text);
                    cmd.Parameters.AddWithValue("@bereavement_leave", txtBereavementL.Text);
                    cmd.Parameters.AddWithValue("@emergency_leave", txtEmergencyL.Text);
                    cmd.Parameters.AddWithValue("@magnacarta_leave", txtMagnaL.Text);
                    cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("updated");
                    conn.Dispose();

                    
                    load_data();
                    
                }
                attendance_computation();
            }
           
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isNewAttendance)
            {
                update_existing_data();  // existing batch no
            }
            else
            {
                update_new_data();     // new batch no

            }
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

        public void payroll_computation()
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (attendance_batch_no != null)  //approval
            {
                DialogResult result = MessageBox.Show("Approved changes cannot be undone. Are you sure you want to approve?", "Message Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connString))
                        {
                            conn.Open();
                            string query = "UPDATE attendance_monitoring SET status='Approved' where attendance_batch_no=@attendance_batch_no";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no);
                            cmd.ExecuteNonQuery();
                            conn.Dispose();
                        }

                        MessageBox.Show("Attendance Batch has been approved", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmHome frmHome = System.Windows.Forms.Application.OpenForms.OfType<frmHome>().FirstOrDefault();

                        if (frmHome.mainPanel != null)
                        {
                            frmOverviewAttendance frmOverviewAttendance = new frmOverviewAttendance();
                            frmHome.DisplayForm(frmOverviewAttendance, frmHome.mainPanel);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Message"+ex);
                    }
                    
                    
                }

            }
            else
            {
                frmSaveAttendance frmSaveAttendance = new frmSaveAttendance(dgvAttendance);
                frmSaveAttendance.ShowDialog();
            }
           

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void isMaternity_CheckedChanged(object sender, EventArgs e)
        {
            if (isMaternity.Checked == true)
            {
                txtMaternityL.Enabled = true;
                txtMaternityL.Focus();
            }
            else
            {
                txtMaternityL.Clear();
                txtMaternityL.Enabled = false;
            }
        }

        private void isPaternity_CheckedChanged(object sender, EventArgs e)
        {
            if (isPaternity.Checked == true)
            {
                txtPaternityL.Enabled = true;
                txtPaternityL.Focus();
            }
            else
            {
                txtPaternityL.Clear();
                txtPaternityL.Enabled = false;
            }
        }

        private void isBereavement_CheckedChanged(object sender, EventArgs e)
        {
            if (isBereavement.Checked == true)
            {
                txtBereavementL.Enabled = true;
                txtBereavementL.Focus();
            }
            else
            {
                txtBereavementL.Clear();
                txtBereavementL.Enabled = false;
            }
        }

        private void isEmergency_CheckedChanged(object sender, EventArgs e)
        {
            if (isEmergency.Checked == true)
            {
                txtEmergencyL.Enabled = true;
                txtEmergencyL.Focus();
            }
            else
            {
                txtEmergencyL.Clear();
                txtEmergencyL.Enabled = false;
            }
        }

        private void isMagnacarta_CheckedChanged(object sender, EventArgs e)
        {
            if (isMagnacarta.Checked == true)
            {
                txtMagnaL.Enabled = true;
                txtMagnaL.Focus();
            }
            else
            {
                txtMagnaL.Clear();
                txtMagnaL.Enabled = false;
            }
        }

        private void txtVacationL_Validating(object sender, CancelEventArgs e)
        {   
            using(MySqlConnection conn = new MySqlConnection(connString))
            {
                double emp_vacation_leave = 0;
                conn.Open();
                string query = "SELECT * FROM leave_monitoring WHERE emp_id=@emp_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@emp_id", txtEmpID.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    emp_vacation_leave = reader.GetDouble("vacation_leave"); 
                }

                double.TryParse(txtVacationL.Text, out double input);
                conn.Dispose();
                if (input > emp_vacation_leave)
                {
                    MessageBox.Show("Employee has "+ emp_vacation_leave +" vacation leave left","Message Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

            }

            
        }

        private void txtSickL_Validating(object sender, CancelEventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                double emp_sick_leave = 0;
                conn.Open();
                string query = "SELECT * FROM leave_monitoring WHERE emp_id=@emp_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@emp_id", txtEmpID.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    emp_sick_leave = reader.GetDouble("sick_leave");
                }

                double.TryParse(txtSickL.Text, out double input);
                conn.Dispose();
                if (input > emp_sick_leave)
                {
                    MessageBox.Show("Employee has "+ emp_sick_leave +" sick leave left", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }
    }
}
