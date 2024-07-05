using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms.Menu_Form.Attendance
{
    public partial class frmAttendance : Form
    {
        public frmAttendance()
        {
            InitializeComponent();
        }

        string connString = frmLogin.connString;

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportAttendance frmImportAttendance = new frmImportAttendance();
            frmImportAttendance.ShowDialog();
        }

        public void filter_data()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT emp_code, employee_name, weekday, date_day, time_in, time_out FROM import_attendance_logs WHERE date_day BETWEEN @dateFrom AND @dateTo";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dateFrom", txtDateFrom.Text);
                    cmd.Parameters.AddWithValue("@dateTo", txtDateTo.Text);

                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable(); 
                    sda.Fill(dt);

                    dgvAttendance.Refresh();
                    dgvAttendance.DataSource = dt;


                }
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            filter_data();
        }

        private void dgvAttendance_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the right mouse button was clicked
            if (e.Button == MouseButtons.Right)
            {
                // Get the current mouse position relative to the DataGridView
                var hti = dgvAttendance.HitTest(e.X, e.Y);

                // Only show the context menu if a cell was clicked
                if (hti.RowIndex >= 0 && hti.ColumnIndex >= 0)
                {
                    // Select the row where the right-click occurred
                    dgvAttendance.ClearSelection();
                    dgvAttendance.Rows[hti.RowIndex].Selected = true;

                    // Show the context menu at the mouse position
                    guna2ContextMenuStrip1.Show(dgvAttendance, e.Location);
                }
            }
        }
    }
}
