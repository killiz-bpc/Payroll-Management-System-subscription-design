using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace Payroll_Management_System.Forms.Menu_Form
{
    public partial class frmImportAttendance : Form
    {
        public frmImportAttendance()
        {
            InitializeComponent();
        }

        string connString = frmLogin.connString;

        public void import_attendance()
        {
            
                Microsoft.Office.Interop.Excel.Application xlApp;
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
                Microsoft.Office.Interop.Excel.Range xlRange;

                int xlRow;
                string strFileName;

                openFileDialog1.Filter = "Excel Office |*.xls; *xlsx";
                //openFileDialog1.ShowDialog();
                

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFileName = openFileDialog1.FileName;
                if (strFileName != "")
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(strFileName);
                    xlWorksheet = xlWorkbook.Worksheets["Final"];
                    xlRange = xlWorksheet.UsedRange;

                    int i = 0;



                    for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                    {
                        i++;
                        dgvImportAttendance.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text);
                    }
                    xlWorkbook.Close();
                    xlApp.Quit();
                }
            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (dgvImportAttendance.Rows.Count>0)
            {
                DialogResult result = MessageBox.Show("Datagrid has been added already. Are you sure you want to import another?", "Message Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    dgvImportAttendance.Rows.Clear();
                    import_attendance();
                }

            }
            else
            {
                import_attendance();
            }
        }

        public string GetEmpCode(string last_name, string first_name)
        {
            string query = "SELECT emp_code from list_of_employees WHERE last_name LIKE @last_name OR first_name LIKE @first_name";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@last_name", "%"+ last_name+"%");
                cmd.Parameters.AddWithValue("@first_name", "%"+ first_name+"%");

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
                else
                {
                    // Handle the case when no result is found
                    return "No Code"; // or return a default value or handle accordingly
                }


            }


                

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dgvImportAttendance.Rows.Count > 0)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    foreach(DataGridViewRow row in dgvImportAttendance.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string emp_name = Convert.ToString(row.Cells["employee_name"].Value);

                            string[]names = emp_name.Split(',');

                            string last_name = names[0];
                            string full_first_name = names[1];

                            string[]first_names = full_first_name.Split(' ');

                            string first_name = first_names[1];

                            string emp_code = GetEmpCode(last_name, first_name);

                            string query = "INSERT INTO import_attendance_logs (emp_code, employee_name, weekday, date_day, time_in, time_out) VALUES (@emp_code, @employee_name, @weekday, @date_day, @time_in, @time_out)";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@emp_code", emp_code);
                                cmd.Parameters.AddWithValue("@employee_name", Convert.ToString(row.Cells["employee_name"].Value));
                                cmd.Parameters.AddWithValue("@weekday", Convert.ToString(row.Cells["weekday"].Value));
                                cmd.Parameters.AddWithValue("@date_day", Convert.ToString(row.Cells["date_day"].Value));
                                cmd.Parameters.AddWithValue("@time_in", Convert.ToString(row.Cells["time_in"].Value));
                                cmd.Parameters.AddWithValue("@time_out", Convert.ToString(row.Cells["time_out"].Value));

                                cmd.ExecuteNonQuery();
                                
                            }
                        }
                       
                    }
                    MessageBox.Show("save");

                    this.Close();

                    conn.Dispose();
                }
               
            }
        }
    }
}
