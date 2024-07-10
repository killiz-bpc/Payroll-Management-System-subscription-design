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
                    string emp_id = reader.GetString("emp_id").ToString();
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
                    txtSSSNo.Text= sss_no;
                    txtTINNo.Text= tin_no;
                    txtHDMFNo.Text= hdmf_no;
                    txtPHNo.Text= philhealth_no;
                    txtActiveStatus.Text= active_status;
                    txtAccessRights.Text= access_rights;
                    txtPassword.Text=password;

                }
                conn.Dispose();
            }
        }



        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            load_data();
        }


        public void update_data()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query;
                query = "UPDATE employee_information SET " +
                        "first_name=@first_name, middle_name=@middle_name, last_name=@last_name, salary=@salary, civil_status=@civil_status";
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
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@middle_name", txtMiddleName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@civil_status", txtCivilStatus.Text);

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
    }
}
