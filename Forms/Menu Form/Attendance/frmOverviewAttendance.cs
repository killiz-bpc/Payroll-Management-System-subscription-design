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
                string query = "SELECT DISTINCT attendance_batch_no, cutoff_period, date_from, date_to, status FROM attendance_monitoring";


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
            dgvAttendance.CurrentCell = dgvAttendance.Rows[e.RowIndex].Cells[e.ColumnIndex];

            string attendance_batch_no = dgvAttendance.CurrentRow.Cells["attendance_batch_no"].Value.ToString();
            string cutoff_period = dgvAttendance.CurrentRow.Cells["cutoff_period"].Value.ToString();
            string date_from = dgvAttendance.CurrentRow.Cells["date_from"].Value.ToString();
            string date_to = dgvAttendance.CurrentRow.Cells["date_to"].Value.ToString();
            string status = dgvAttendance.CurrentRow.Cells["status"].Value.ToString();

            if (e.ColumnIndex == dgvAttendance.Columns["edit_batch"].Index && e.RowIndex >= 0)
            {
                if (status != "Prepared")
                {

                    MessageBox.Show("Selected batch has been already approved. It cannot be edited.","Message Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    frmCreateAttendance frmCreateAttendance = new frmCreateAttendance();
                    frmCreateAttendance.attendance_batch_no = attendance_batch_no;
                    frmCreateAttendance.cutoff_period = cutoff_period;
                    frmCreateAttendance.date_from = date_from;
                    frmCreateAttendance.date_to = date_to;

                    frmCreateAttendance.status = status;


                    frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

                    if (frmHome.mainPanel != null)
                    {
                        frmHome.DisplayForm(frmCreateAttendance, frmHome.mainPanel);
                    }
                }
            }

            if (e.ColumnIndex == dgvAttendance.Columns["view_more"].Index && e.RowIndex >= 0)
            {
                frmSummaryAttendance frmSummaryAttendance = new frmSummaryAttendance();
                frmSummaryAttendance.attendance_batch_no = attendance_batch_no;
                frmSummaryAttendance.status = status;
                frmSummaryAttendance.ShowDialog();
            }
        }

        private void dgvAttendance_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }
    }
}
