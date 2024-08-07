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
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;


namespace Payroll_Management_System.Forms.Menu_Form.Payroll
{
    public partial class frmPrintPayslip : Form
    {
        public string connString = frmLogin.connString;

        public int emp_id { get; set; }
        public string attendance_batch_no { get; set; } 

        public frmPrintPayslip()
        {
            InitializeComponent();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent =100;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void frmPrintPayslip_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = @"
                                    SELECT DISTINCT
                                        payroll_process_tb.*, 
                                        employee_information.job_title, 
                                        employee_information.sss_no, 
                                        employee_information.tin_no, 
                                        employee_information.HDMF_no, 
                                        employee_information.philhealth_no, 
                                        attendance_monitoring.date_from, 
                                        attendance_monitoring.date_to
                                    FROM 
                                        employee_information
                                    INNER JOIN 
                                        payroll_process_tb ON employee_information.emp_id = payroll_process_tb.emp_id
                                    INNER JOIN 
                                        attendance_monitoring ON attendance_monitoring.attendance_batch_no = payroll_process_tb.attendance_batch_no
                                    WHERE 
                                        payroll_process_tb.emp_id=@emp_id AND payroll_process_tb.attendance_batch_no=@attendance_batch_no";

                    
                        
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                   
                    cmd.Parameters.AddWithValue("@emp_id", emp_id);
                    cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no);

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }

                    
                }

                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSetPayroll", dt);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Payroll.rdlc");
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex, "Message Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
