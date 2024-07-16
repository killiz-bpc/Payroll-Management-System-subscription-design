using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Utilities;
using Payroll_Management_System.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms.Menu_Form.Employees
{
    public partial class frmAddEmployee : Form
    {
        public static string connString = frmLogin.connString;
        public frmAddEmployee()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO employee_information(employee_img, employee_name, first_name, middle_name, last_name, mobile_number, address, civil_status, gender, personal_email, date_of_birth, emergency_person, emergency_number, emp_id, job_title, salary, employment_status, employee_type, employee_level, email_work, assigned_branch, assigned_city, department, schedule, hired_date, third_date, fifth_date, regularization_date, sss_no, tin_no, hdmf_no, philhealth_no, active_status, access_rights, password, basic_salary, daily_rate, hourly_rate, minute_rate)" +
              "VALUES (@employee_img, @employee_name, @first_name, @middle_name, @last_name, @mobile_number, @address, @civil_status, @gender, @personal_email, @date_of_birth, @emergency_person, @emergency_number, @emp_id, @job_title, @salary, @employment_status, @employee_type, @employee_level, @email_work, @assigned_branch, @assigned_city, @department, @schedule, @hired_date, @third_date, @fifth_date, @regularization_date, @sss_no, @tin_no, @hdmf_no, @philhealth_no, @active_status, @access_rights, @password, @basic_salary, @daily_rate, @hourly_rate, @minute_rate)";

            MemoryStream stream = new MemoryStream();
            picEmployee.Image.Save(stream, picEmployee.Image.RawFormat);

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                string first_name = txtFirstName.Text.Trim();
                string last_name = txtLastName.Text.Trim();
                string middle_name = txtMiddleName.Text.Trim();

                string employee_name = GetData.GetEmployeeName(last_name, first_name, middle_name);

                int salary = Convert.ToInt32(txtSalary.Text);
                var result = GetData.GetSalary(salary);

                double basic_salary = result.basic_salary;
                double daily_rate = result.daily_rate;
                double hourly_rate = result.hourly_rate;
                double minute_rate = result.minute_rate;

                //rate of employee
                cmd.Parameters.AddWithValue("@basic_salary", basic_salary);
                cmd.Parameters.AddWithValue("@daily_rate", daily_rate);
                cmd.Parameters.AddWithValue("@hourly_rate", hourly_rate);
                cmd.Parameters.AddWithValue("@minute_rate", minute_rate);

                //basic info
                cmd.Parameters.AddWithValue("@employee_img", stream.ToArray());
                cmd.Parameters.AddWithValue("@employee_name", employee_name);
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@middle_name", txtMiddleName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                cmd.Parameters.AddWithValue("@mobile_number", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@civil_status", txtCivilStatus.Text);
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@personal_email", txtPersonalEmail.Text);
                cmd.Parameters.AddWithValue("@date_of_birth", txtDateOfBirth.Text);
                cmd.Parameters.AddWithValue("@emergency_person", txtEmergencyPerson.Text);
                cmd.Parameters.AddWithValue("@emergency_number", txtEmergencyNumber.Text);

                //work info
                cmd.Parameters.AddWithValue("@emp_id", txtEmployeeID.Text);
                cmd.Parameters.AddWithValue("@job_title", txtJobTitle.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@employment_status", txtEmpStatus.Text);
                cmd.Parameters.AddWithValue("@employee_type", txtEmpType.Text);
                cmd.Parameters.AddWithValue("@employee_level", txtEmpLevel.Text);
                cmd.Parameters.AddWithValue("@email_work", txtWorkEmail.Text);
                cmd.Parameters.AddWithValue("@assigned_branch", txtBranch.Text);
                cmd.Parameters.AddWithValue("@assigned_city", txtCity.Text);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@schedule", txtSchedule.Text);
                cmd.Parameters.AddWithValue("@hired_date", txtHireDate.Text);
                cmd.Parameters.AddWithValue("@third_date", txtThirdDate.Text);
                cmd.Parameters.AddWithValue("@fifth_date", txtFifthDate.Text);
                cmd.Parameters.AddWithValue("@regularization_date", txtRegularizationDate.Text);


                //other info
                cmd.Parameters.AddWithValue("@sss_no", txtSSSNo.Text);
                cmd.Parameters.AddWithValue("@tin_no", txtTINNo.Text);
                cmd.Parameters.AddWithValue("@hdmf_no", txtHDMFNo.Text);
                cmd.Parameters.AddWithValue("@philhealth_no", txtPHNo.Text);
                cmd.Parameters.AddWithValue("@active_status", txtActiveStatus.Text);
                cmd.Parameters.AddWithValue("@access_rights", txtAccessRights.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee has been added successfully", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                conn.Dispose();
            }

            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFD.Filter = "Select image(*.JpG; *.png; *.GiF)| *.JpG; *.png; *.Gif";
            if(openFD.ShowDialog() == DialogResult.OK )
            {
                picEmployee.Image = Image.FromFile(openFD.FileName);
            }
        }


        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT employee_img FROM employee_information where first_name=@first_name";

            using(MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    byte[] imageData = (byte[])reader["employee_img"];
                    pictureBox.Image = ByteArrayToImage(imageData);

                }

            }
        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            string query = "UPDATE employee_information SET employee_img=@employee_img where first_name=@first_name";

            MemoryStream stream = new MemoryStream();
            picEmployee.Image.Save(stream, picEmployee.Image.RawFormat);

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@employee_img", stream.ToArray());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");

            }

            
        }

        private void panelPersonal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmergencyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void load_data()
        {
            List<string> departments = GetData.GetDepartments(); //load department
            foreach (string department in departments)
            {
                txtDepartment.Items.Add(department);
            }

            List<string> schedule = GetData.GetSchedule(); //load schedules
            foreach(string shifts in schedule)
            {
                txtSchedule.Items.Add(shifts);
            }

        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            
            load_data();

            picEmployee.Image = Properties.Resources.user;


        }

        private void isSalary_CheckedChanged(object sender, EventArgs e)
        {
            if (isSalary.Checked)
            {
                txtSalary.PasswordChar = '\0';
            }
            else
            {
                txtSalary.PasswordChar = '●';
            }
        }
    }
}
