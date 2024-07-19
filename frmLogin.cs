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
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Payroll_Management_System
{
    public partial class frmLogin : Form
    {
       
        public frmLogin()
        {
            InitializeComponent();
        }

        public static string connString;

        public static string lastName = null;
        public static string firstName = null;
        public static string position = null;
        public static string accessRights = null;



        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            GetConnectionString();
            txtUsername.Focus();
        }


        

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            

        }
        public static bool useConnection = true;

        public static string GetConnectionString()
        {
            if(useConnection)
            {
                return connString = ConfigurationManager.ConnectionStrings["mainConnection"].ConnectionString;  
            }
            else
            {
                return connString = ConfigurationManager.ConnectionStrings["outsideConnection"].ConnectionString;
            }

           
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
                txtUsername.Clear();
                txtUsername.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input password", "Message Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM employee_information where email_work=@email_work COLLATE utf8mb4_bin AND password=@password";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@email_work", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                firstName = reader.GetString("first_name");
                                lastName = reader.GetString("last_name");
                                position = reader.GetString("job_title");
                                accessRights = reader.GetString("access_rights");

                                frmLoading frmLoading = new frmLoading();
                                frmLoading.ShowDialog();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username and Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                delete_text();
                                txtUsername.Focus();
                            }
                        }


                    }
                    catch (MySqlException ex)
                    {
                        DialogResult result = MessageBox.Show("Connection Error. Do you want to connect as outside?", "Message Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            useConnection = false;
                            GetConnectionString();
                            MessageBox.Show("Connection successful. Please input username and password.", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            delete_text();
                            txtUsername.Focus();
                        }
                        else
                        {
                            return;
                        }
                    }

                }
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
