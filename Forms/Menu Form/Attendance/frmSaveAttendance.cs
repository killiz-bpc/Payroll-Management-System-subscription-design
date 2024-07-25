using MySql.Data.MySqlClient;
using Payroll_Management_System.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Configuration;

namespace Payroll_Management_System.Forms.Menu_Form.Attendance
{
    public partial class frmSaveAttendance : Form
    {
        string connString = frmLogin.connString;

        public DataGridView _dgvAttendance;
        public frmSaveAttendance(DataGridView dgvAttendance)
        {
            InitializeComponent();
            _dgvAttendance = dgvAttendance;
            timer1.Start();
        }

        public void load_default()
        {
            txtPreparedBy.Text = GetData.GetEmployeeName(frmLogin.lastName, frmLogin.firstName, "");
        }

        
        private void frmSaveAttendance_Load(object sender, EventArgs e)
        {
            series_number();
            load_default();
        }

        private void isNewBatch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateCreated.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }


        public void series_number()
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);

                string query = "SELECT count(attendance_batch_no) from batch_number_tb";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();

                string ID = "BPC-ATB-0";

                int i = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();
                i++;
                txtSeries.Text = ID + i.ToString();


                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        public void update_series()
        {
            string series = txtSeries.Text;
            MySqlConnection conn = new MySqlConnection(connString);
            string query = "INSERT INTO batch_number_tb (attendance_batch_no, cutoff_period, date_created, prepared_by) VALUES (@attendance_batch_no, @cutoff_period, @date_created, @prepared_by)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@attendance_batch_no", series);
            cmd.Parameters.AddWithValue("@cutoff_period", txtPeriod.Text);
            cmd.Parameters.AddWithValue("@date_created", txtDateCreated.Text);
            cmd.Parameters.AddWithValue("@prepared_by", txtPreparedBy.Text);

            cmd.ExecuteNonQuery();
        }




        private void txtPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPeriod.Text))
            {
                MessageBox.Show("Please provide period of the month", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                series_number();

                string query;

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in _dgvAttendance.Rows)
                    {
                        query= "INSERT INTO attendance_monitoring (attendance_batch_no, cutoff_period, date_from, date_to, status,  department, emp_id, employee_name, absences, lates, under_time, night_premium, over_time, restday_duty, vacation_leave, sick_leave, legal_holiday, special_holiday, maternity_leave, paternity_leave, bereavement_leave, emergency_leave, magnacarta_leave, remarks) VALUES(@attendance_batch_no, @cutoff_period, @date_from, @date_to, 'Prepared',  @department, @emp_id, @employee_name, @absences, @lates, @under_time, @night_premium, @over_time, @restday_duty, @vacation_leave, @sick_leave, @legal_holiday, @special_holiday, @maternity_leave, @paternity_leave, @bereavement_leave, @emergency_leave, @magnacarta_leave, @remarks)";


                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@attendance_batch_no", txtSeries.Text);
                        cmd.Parameters.AddWithValue("@cutoff_period", txtPeriod.Text);
                        cmd.Parameters.AddWithValue("@date_from", txtDateFrom.Text);
                        cmd.Parameters.AddWithValue("@date_to", txtDateTo.Text);

                        cmd.Parameters.AddWithValue("@department", row.Cells["department"].Value.ToString());
                        cmd.Parameters.AddWithValue("@employee_name", row.Cells["employee_name"].Value.ToString());
                        cmd.Parameters.AddWithValue("@emp_id", row.Cells["emp_id"].Value.ToString());
                        cmd.Parameters.AddWithValue("@absences", row.Cells["absences"].Value.ToString());
                        cmd.Parameters.AddWithValue("@lates", row.Cells["lates"].Value.ToString());
                        cmd.Parameters.AddWithValue("@under_time", row.Cells["under_time"].Value.ToString());
                        cmd.Parameters.AddWithValue("@over_time", row.Cells["over_time"].Value.ToString());
                        cmd.Parameters.AddWithValue("@night_premium", row.Cells["night_premium"].Value.ToString());
                        cmd.Parameters.AddWithValue("@restday_duty", row.Cells["restday_duty"].Value.ToString());
                        cmd.Parameters.AddWithValue("@vacation_leave", row.Cells["vacation_leave"].Value.ToString());
                        cmd.Parameters.AddWithValue("@sick_leave", row.Cells["sick_leave"].Value.ToString());
                        cmd.Parameters.AddWithValue("@legal_holiday", row.Cells["legal_holiday"].Value.ToString());
                        cmd.Parameters.AddWithValue("@special_holiday", row.Cells["special_holiday"].Value.ToString());
                        cmd.Parameters.AddWithValue("@maternity_leave", row.Cells["maternity_leave"].Value.ToString());
                        cmd.Parameters.AddWithValue("@paternity_leave", row.Cells["paternity_leave"].Value.ToString());

                        cmd.Parameters.AddWithValue("@bereavement_leave", row.Cells["bereavement_leave"].Value.ToString());
                        cmd.Parameters.AddWithValue("@emergency_leave", row.Cells["emergency_leave"].Value.ToString());
                        cmd.Parameters.AddWithValue("@magnacarta_leave", row.Cells["magnacarta_leave"].Value.ToString());
                        cmd.Parameters.AddWithValue("@remarks", row.Cells["remarks"].Value.ToString());

                        cmd.ExecuteNonQuery();
                    }


                    update_series();
                    MessageBox.Show("Data has been saved successfully", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

                    if (frmHome.mainPanel != null)
                    {
                        frmOverviewAttendance frmOverviewAttendance = new frmOverviewAttendance();
                        frmHome.DisplayForm(frmOverviewAttendance, frmHome.mainPanel);
                    }

                    conn.Dispose();
                }




            }


        }

        private void txtAttendanceBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT date_from,date_to from attendance_monitoring";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader sdr;

                sdr=cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string date_from = sdr.GetString("date_from").ToString();
                    txtDateFrom.Text = date_from;

                    string date_to = sdr.GetString("date_to").ToString();
                    txtDateTo.Text = date_to;
                }

                conn.Dispose();
            }
        }

        private void txtSeries_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
