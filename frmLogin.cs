using Payroll_Management_System.Forms.Menu_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Payroll_Management_System
{
    public partial class frmLogin : Form
    {
        public string connString;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }



        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            
        }



        private void guna2PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void delete_text()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please input username", "Message Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                delete_text();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text)) 
            {
                MessageBox.Show("Please input password", "Message Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                delete_text();
                return;
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT username, password FROM employee_information where username=@username AND password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    }
                }
            }
        }
    }
}
