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
using MySql.Data.MySqlClient;

namespace Payroll_Management_System.Forms.Menu_Form.Attendance
{
    public partial class frmEditAttendance : Form
    {
        public frmEditAttendance()
        {
            InitializeComponent();
        }

        public string attendance_batch_no { get; set; } 

        string connString = frmLogin.connString;


        public void load_attendance_batch_no()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT date_from, date_to, status FROM attendance_monitoring WHERE attendance_batch_no=@attendance_batch_no";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                dgvAttendance.Refresh();
                dgvAttendance.DataSource=dt;

                conn.Dispose();
            }
        }
        private void frmEditAttendance_Load(object sender, EventArgs e)
        {
            MessageBox.Show(""+attendance_batch_no);
            load_attendance_batch_no();

        }
    }
}
