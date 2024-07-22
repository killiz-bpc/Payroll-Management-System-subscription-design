using Payroll_Management_System.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.CompilerServices;

namespace Payroll_Management_System.Forms.Menu_Form.Employees
{
    public partial class frmEditEmployee : Form
    {
        public frmEditEmployee()
        {
            InitializeComponent();
        }

        public string connString = frmLogin.connString;

        public bool isUpdateImg = false;

        public string employee_id { get; set; }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        public void load_data()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT * FROM employee_information WHERE emp_id=@emp_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@emp_id", employee_id);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    if (reader["employee_img"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["employee_img"];
                        picEmployee.Image = ByteArrayToImage(imageData);
                    }
                    else
                    {
                        picEmployee.Image = Properties.Resources.user;
                    }
                    
                   
                    //basic info
                    string first_name = reader.GetString("first_name").ToString();
                    string middle_name = reader.GetString("middle_name").ToString();
                    string last_name = reader.GetString("last_name").ToString();
                    string mobile_number = reader.GetString("mobile_number").ToString();
                    string address = reader.GetString("address").ToString();
                    string civil_status = reader.GetString("civil_status").ToString();
                    string gender = reader.GetString("gender").ToString();
                    string personal_email = reader.GetString("personal_email").ToString();
                    string date_of_birth = reader.GetString("date_of_birth").ToString();
                    string emergency_person = reader.GetString("emergency_person").ToString();
                    string emergency_number = reader.GetString("emergency_number").ToString();
                    txtFirstName.Text = first_name;
                    txtMiddleName.Text = middle_name;
                    txtLastName.Text = last_name;
                    txtMobileNo.Text= mobile_number;
                    txtAddress.Text= address; 
                    txtCivilStatus.Text = civil_status;
                    txtGender.Text = gender;
                    txtPersonalEmail.Text=personal_email;
                    txtDateOfBirth.Text = date_of_birth;
                    txtEmergencyPerson.Text=emergency_person;
                    txtEmergencyNumber.Text = emergency_number;
                    

                    //work info
                    string emp_id = reader.GetInt32("emp_id").ToString();
                    string job_title = reader.GetString("job_title").ToString();
                    string salary = Convert.ToString(reader.GetInt32("salary"));
                    string employment_status = reader.GetString("employment_status").ToString();
                    string employee_type = reader.GetString("employee_type").ToString();
                    string employee_level = reader.GetString("employee_level").ToString();
                    string email_work = reader.GetString("email_work").ToString();
                    string assigned_branch = reader.GetString("assigned_branch").ToString();
                    string assigned_city = reader.GetString("assigned_city").ToString();
                    string department = reader.GetString("department").ToString();
                    string schedule = reader.GetString("schedule").ToString();
                    string hired_date = reader.GetString("hired_date").ToString();
                    string third_date = reader.GetString("third_date").ToString();
                    string fifth_date = reader.GetString("fifth_date").ToString();
                    string regularization_date = reader.GetString("regularization_date").ToString();
                    txtEmployeeID.Text = emp_id;
                    txtJobTitle.Text = job_title;
                    txtSalary.Text = salary;
                    txtEmpStatus.Text= employment_status;
                    txtEmpType.Text= employee_type;
                    txtEmpLevel.Text= employee_level;
                    txtWorkEmail.Text= email_work;
                    txtBranch.Text= assigned_branch;
                    txtCity.Text= assigned_city;
                    txtDepartment.Text= department;
                    txtSchedule.Text= schedule;
                    txtHireDate.Text= hired_date;
                    txtThirdDate.Text= third_date;
                    txtFifthDate.Text= fifth_date;
                    txtRegularizationDate.Text= regularization_date;

                    //other info
                    string sss_no = reader.GetString("sss_no").ToString();
                    string tin_no = reader.GetString("tin_no").ToString();
                    string hdmf_no = reader.GetString("hdmf_no").ToString();
                    string philhealth_no = reader.GetString("philhealth_no").ToString();
                    string active_status = reader.GetString("active_status").ToString();
                    string access_rights = reader.GetString("access_rights").ToString();
                    string password = reader.GetString("password").ToString();
                    string separation_cause = reader.GetString("separation_cause").ToString();
                    string separation_date = reader.GetString("separation_date").ToString();
                    string separation_type = reader.GetString("separation_type").ToString();
                    string eligibility = reader.GetString("eligibility").ToString();
                    string clearance = reader.GetString("clearance").ToString();

                    txtSSSNo.Text= sss_no;
                    txtTINNo.Text= tin_no;
                    txtHDMFNo.Text= hdmf_no;
                    txtPHNo.Text= philhealth_no;
                    txtActiveStatus.Text= active_status;
                    txtAccessRights.Text= access_rights;
                    txtPassword.Text= password;

                    txtSeparationCause.Text=separation_cause;
                    txtSeparationDate.Text=separation_date;
                    txtSeparationType.Text=separation_type;
                    txtEligibility.Text=eligibility;
                    txtClearance.Text=clearance;






                }
                conn.Dispose();
            }
        }

        public void inactive_status()
        {
            if (txtActiveStatus.Text == "Active")
            {
                txtSeparationCause.SelectedIndex = -1;
                txtSeparationType.SelectedIndex = -1;
                txtEligibility.SelectedIndex = -1;
                txtClearance.SelectedIndex = -1;

                txtSeparationCause.Enabled = false;
                txtSeparationDate.Enabled = false;
                txtSeparationType.Enabled = false;
                txtEligibility.Enabled =false;
                txtClearance.Enabled = false;
            }
            else
            {
                txtSeparationCause.Enabled = true;
                txtSeparationDate.Enabled = true;
                txtSeparationType.Enabled = true;
                txtEligibility.Enabled =true;
                txtClearance.Enabled = true;
            }

           
        }


        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            List<string> departments = GetData.GetDepartments();
            foreach (string department in departments)
            {
                txtDepartment.Items.Add(department);
            }

            List<string> schedules = GetData.GetSchedule();
            foreach (string schedule in schedules)
            {
                txtSchedule.Items.Add(schedule);
            }
            load_data();


            if (txtActiveStatus.Text == "Active")
            {
                inactive_status();
            }
        }


        public void update_data()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query;
                query = "UPDATE employee_information SET " +
                        "employee_name=@employee_name, first_name=@first_name, middle_name=@middle_name, last_name=@last_name, mobile_number=@mobile_number, address=@address, civil_status=@civil_status, gender=@gender, personal_email=@personal_email, date_of_birth=@date_of_birth, emergency_person=@emergency_person, emergency_number=@emergency_number, job_title=@job_title, salary=@salary, employment_status=@employment_status, employee_type=@employee_type, employee_level=@employee_level, email_work=@email_work, assigned_branch=@assigned_branch, assigned_city=@assigned_city, department=@department, schedule=@schedule, hired_date=@hired_date, third_date=@third_date, fifth_date=@fifth_date, regularization_date=@regularization_date, sss_no=@sss_no, tin_no=@tin_no, hdmf_no=@hdmf_no, philhealth_no=@philhealth_no, active_status=@active_status, access_rights=@access_rights, password=@password, basic_salary=@basic_salary, daily_rate=@daily_rate, hourly_rate=@hourly_rate, minute_rate=@minute_rate, separation_cause=@separation_cause, separation_date=@separation_date, separation_type=@separation_type, eligibility=@eligibility, clearance=@clearance";

                if (isUpdateImg)
                {
                    query += ", employee_img=@employee_img";
                }

                query += " WHERE emp_id=@emp_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (isUpdateImg)
                {
                    MemoryStream stream = new MemoryStream();
                    picEmployee.Image.Save(stream, picEmployee.Image.RawFormat);
                    cmd.Parameters.AddWithValue("@employee_img", stream.ToArray()); //employee image
                }

                cmd.Parameters.AddWithValue("@emp_id", employee_id);


                //rate of employee
                int salary = Convert.ToInt32(txtSalary.Text);
                var result = GetData.GetSalary(salary);
                double basic_salary = result.basic_salary;
                double daily_rate = result.daily_rate;
                double hourly_rate = result.hourly_rate;
                double minute_rate = result.minute_rate;
                cmd.Parameters.AddWithValue("@basic_salary", basic_salary);
                cmd.Parameters.AddWithValue("@daily_rate", daily_rate);
                cmd.Parameters.AddWithValue("@hourly_rate", hourly_rate);
                cmd.Parameters.AddWithValue("@minute_rate", minute_rate);

                string employee_name = GetData.GetEmployeeName(txtLastName.Text.Trim(), txtFirstName.Text.Trim(), txtMiddleName.Text.Trim());


                //basic info
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

                cmd.Parameters.AddWithValue("@separation_cause", txtSeparationCause.Text);
                cmd.Parameters.AddWithValue("@separation_date", txtSeparationDate.Text);
                cmd.Parameters.AddWithValue("@separation_type", txtSeparationType.Text);
                cmd.Parameters.AddWithValue("@eligibility", txtEligibility.Text);
                cmd.Parameters.AddWithValue("@clearance", txtClearance.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Information has been updated successfully","Message Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.Close();
                conn.Dispose();
            }
        }


        

        private void btnSave_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you want to save?", "Message Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(DialogResult.Yes == result)
            {
                update_data();
            }
            else
            {
                return;
            }
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

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            isUpdateImg = true;

            if (isUpdateImg)
            {
                openFD.Filter = "Select image(*.JpG; *.png; *.GiF)| *.JpG; *.png; *.Gif";
                if (openFD.ShowDialog() == DialogResult.OK)
                {
                    picEmployee.Image = Image.FromFile(openFD.FileName);
                }
                else
                {
                    isUpdateImg = false;
                }
            }
           


        }

        private void txtAccessRights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtActiveStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            inactive_status();
        }
    }
}
