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
                    string query = "SELECT emp_id, employee_name, basic_salary, gross_salary, total_deductions, net_salary FROM payroll_process_tb WHERE emp_id=@emp_id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@emp_id", emp_id);
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
