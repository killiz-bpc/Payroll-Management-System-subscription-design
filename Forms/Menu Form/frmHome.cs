using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Payroll_Management_System.Forms.Menu_Form.Attendance;
using Payroll_Management_System.Forms.Menu_Form.Payroll;

namespace Payroll_Management_System.Forms.Menu_Form
{
    public partial class frmHome : Form
    {
        string connString = frmLogin.connString;
        public frmHome()
        {
            InitializeComponent();
        }

        public Panel mainPanel
        {
            get { return panelMain; }
            set { panelMain = (Guna2GradientPanel)value; }
        }

        public void DisplayForm(Form form, Panel panelMain)
        {
            panelMain.Controls.Clear();
            form.TopLevel=false;
            form.Dock=DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();

        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void guna2GradientPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }



        private void frmHome_Load(object sender, EventArgs e)
        {
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)  //display ng version ng app
            {
                System.Deployment.Application.ApplicationDeployment ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                this.txtVersion.Text = "Payroll Management System v" + ad.CurrentVersion.ToString();
            }


            string firstName = frmLogin.firstName;
            string[] splitName = firstName.Split(' ');

            if (splitName.Length > 0)
            {
                string splitFirstName = splitName[0];
                lblName.Text = frmLogin.lastName + ", " + splitFirstName;
                lblPosition.Text = frmLogin.position;
            }

            string accessRights = frmLogin.accessRights;

            if (accessRights == "User" || accessRights == "user")
            {
                btnEmployees.Visible = false;
                btnAttendance.Visible = false;
                btnPayroll.Visible = false;
            }




        }


        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if(frmHome.mainPanel != null)
            {
                frmDashboard frmDashboard = new frmDashboard();
                frmHome.DisplayForm(frmDashboard,frmHome.mainPanel);
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmOverviewAttendance frmOverviewAttendance = new frmOverviewAttendance();
                frmHome.DisplayForm(frmOverviewAttendance, frmHome.mainPanel);
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmEmployees frmEmployees = new frmEmployees();
                frmHome.DisplayForm(frmEmployees, frmHome.mainPanel);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Message Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                
            }
            else
            {
                return;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnLogout.PerformClick();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {

                frmOverviewPayroll frmOverviewPayroll = new frmOverviewPayroll();
                frmHome.DisplayForm(frmOverviewPayroll, frmHome.mainPanel);
            }
        }

        private void frmHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                MessageBox.Show("alt f4");
            }

            if (e.Alt && e.KeyCode == Keys.S)
            {
                MessageBox.Show("alt s");
            }

            if (e.Alt && e.KeyCode == Keys.F6)
            {
                MessageBox.Show("alt f6");
            }
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
