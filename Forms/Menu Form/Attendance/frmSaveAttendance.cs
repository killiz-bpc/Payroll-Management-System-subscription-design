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
        public frmSaveAttendance()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void load_default()
        {

            txtDateFrom.Clear();
            txtDateTo.Clear();
            txtPreparedBy.Text = GetData.GetEmployeeName(frmLogin.lastName, frmLogin.firstName, "");
            txtPeriod.Enabled = false;
        }

        public void load_attendance_batch_no()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                txtAttendanceBatch.Items.Clear();
                conn.Open();
                string query = "SELECT attendance_batch_no from attendance_monitoring";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader sdr;

                sdr=cmd.ExecuteReader();
                while (sdr.Read())
                {
                   
                    string attendance_batch_no = sdr.GetString("attendance_batch_no");
                    txtAttendanceBatch.Items.Add(attendance_batch_no);
                }

                conn.Dispose();
            }
        }
        private void frmSaveAttendance_Load(object sender, EventArgs e)
        {
            load_default();

            load_attendance_batch_no();
        }

        private void isNewBatch_CheckedChanged(object sender, EventArgs e)
        {
            load_default();
            if (isNewBatch.Checked == true)
            {
                
                txtAttendanceBatch.SelectedItem = null;
                txtAttendanceBatch.Enabled = false;

                txtPeriod.Enabled=true;
                txtPeriod.Focus();
            }
            else
            {
                txtAttendanceBatch.Enabled = true;

                txtPeriod.SelectedItem = null;
                txtPeriod.Enabled = false;
            }
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

            string query = "INSERT INTO batch_number_tb (attendance_batch_no) VALUES (@attendance_batch_no)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@attendance_batch_no", series);
            cmd.ExecuteNonQuery();

        }




        private void txtPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtPeriod.SelectedIndex == 0)
            {

                // 11 to 26th 
                DateTime date_from = DateTime.Now.AddMonths(-1);
                date_from = new DateTime(date_from.Year, date_from.Month, 26);
                txtDateFrom.Text = date_from.ToString("yyyy-MM-dd");

                DateTime date_to = DateTime.Now;
                date_to = new DateTime(date_to.Year, date_to.Month, 10);
                txtDateTo.Text = date_to.ToString("yyyy-MM-dd");

            }
            else
            {
                DateTime date_from = DateTime.Now;
                date_from = new DateTime(date_from.Year, date_from.Month, 11);
                txtDateFrom.Text = date_from.ToString("yyyy-MM-dd");

                DateTime date_to = DateTime.Now;
                date_to = new DateTime(date_to.Year, date_to.Month, 25);
                txtDateTo.Text = date_to.ToString("yyyy-MM-dd");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            series_number();

            string query;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                query= "INSERT INTO attendance_monitoring (attendance_batch_no, date_from, date_to, status) VALUES (@attendance_batch_no, @date_from, @date_to, 'Prepared')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@attendance_batch_no", txtSeries.Text);
                cmd.Parameters.AddWithValue("@date_from", txtDateFrom.Text);
                cmd.Parameters.AddWithValue("@date_to", txtDateTo.Text);
                cmd.ExecuteNonQuery();


                update_series();
                MessageBox.Show("Data has been saved successfully","Message Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();

                frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();
                
                if (frmHome.mainPanel != null)
                {
                    frmOverviewAttendance frmOverviewAttendance = new frmOverviewAttendance();
                    frmHome.DisplayForm(frmOverviewAttendance, frmHome.mainPanel);
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
    }
}
