using MySql.Data.MySqlClient;
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
            string query = "INSERT INTO employee_information(first_name, employee_img)VALUES(@first_name, @employee_img)";

            MemoryStream stream = new MemoryStream();
            picEmployee.Image.Save(stream, picEmployee.Image.RawFormat);
            
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@employee_img", stream.ToArray());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");

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
    }
}
