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
    public partial class frmOverviewAttendance : Form
    {
        public frmOverviewAttendance()
        {
            InitializeComponent();
        }

        string connString = frmLogin.connString;

        private void btnCreateAttendance_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if(frmHome.mainPanel != null)
            {
                frmCreateAttendance frmCreateAttendance = new frmCreateAttendance();
                frmHome.DisplayForm(frmCreateAttendance,frmHome.mainPanel);
            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void load_data()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM attendance_monitoring";


                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                dgvAttendance.Refresh();
                dgvAttendance.DataSource=dt;
                dgvAttendance.CurrentCell=null;

                conn.Dispose();
            }
        }

        private void frmOverviewAttendance_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
