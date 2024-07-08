using MySql.Data.MySqlClient;
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

            string query = "INSERT INTO employee_information(first_name, middle_name, last_name, mobile_number, address, civil_status, gender, personal_email, date_of_birth, emergency_person, emergency_number, emp_id, job_title, department)" +
                            "VALUES (@first_name, @middle_name, @last_name, @mobile_number, @address, @civil_status, @gender, @personal_email, @date_of_birth, @emergency_person, @emergency_number, @emp_id, @job_title, @department)";

            //MemoryStream stream = new MemoryStream();
            //picEmployee.Image.Save(stream, picEmployee.Image.RawFormat);

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //cmd.Parameters.AddWithValue("@employee_img", stream.ToArray());
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
                cmd.Parameters.AddWithValue("@emp_id", txtEmployeeID.Text);
                cmd.Parameters.AddWithValue("@job_title", txtJobTitle.Text);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);


                cmd.ExecuteNonQuery();


                MessageBox.Show("Employee has been added succefully","Message Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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


        private Image ByteArrayToImage(byte[] byteArray)
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


        }
    }
}
