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
using Excel = Microsoft.Office.Interop.Excel;

namespace Payroll_Management_System.Forms.Menu_Form.Attendance
{
    public partial class frmSummaryAttendance : Form
    {
        public frmSummaryAttendance()
        {
            InitializeComponent();
        }

        string connString = frmLogin.connString;

        public string attendance_batch_no { get; set; }

        public void load_data()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT department, emp_id, employee_name, absences, lates, under_time, night_premium, over_time, restday_duty, vacation_leave, sick_leave, legal_holiday, special_holiday, maternity_leave, paternity_leave, bereavement_leave, emergency_leave, magnacarta_leave, remarks FROM attendance_monitoring WHERE attendance_batch_no=@attendance_batch_no";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no.ToString());
                cmd.ExecuteNonQuery();
                System.Data.DataTable dt = new System.Data.DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                dgvAttendance.Refresh();
                dgvAttendance.DataSource=dt;
                dgvAttendance.CurrentCell=null;

                conn.Dispose();
            }
        }
        private void frmSummaryAttendance_Load(object sender, EventArgs e)
        {
            load_data();
            progressBar.Visible=false;
        }

        private void ExportToExcel(DataGridView dataGridView)
        {
            try
            {
                // Set up the progress bar
                progressBar.Visible = true;
                progressBar.Minimum = 0;
                progressBar.Value = 0;

                // Calculate the total number of cells to export
                int totalCells = dataGridView.Rows.Count * dataGridView.Columns.Cast<DataGridViewColumn>().Count(col => col.Visible);
                progressBar.Maximum = totalCells;

                Excel.Application excelApp = new Excel.Application();
              

                // Create a new Excel workbook
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                // Create a new Excel worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                // Export headers
                int excelColumnIndex = 1;
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    // Check if the column is visible before exporting
                    if (dataGridView.Columns[i].Visible)
                    {
                        worksheet.Cells[1, excelColumnIndex] = dataGridView.Columns[i].HeaderText;
                        excelColumnIndex++;
                        progressBar.Value++;
                    }
                }

                // Export data
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    excelColumnIndex = 1;
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        // Check if the column is visible before exporting
                        if (dataGridView.Columns[j].Visible)
                        {
                            object cellValue = dataGridView.Rows[i].Cells[j].Value;

                            // Check if the cell value is null before converting to string
                            if (cellValue != null)
                            {
                                // Check if the value is DBNull.Value
                                if (cellValue != DBNull.Value)
                                {
                                    worksheet.Cells[i + 2, excelColumnIndex].Value = cellValue.ToString();
                                }
                                // If it is DBNull.Value, you may want to handle it differently or skip adding to Excel
                                // For example, you can leave the cell blank or add a default value
                                else
                                {
                                    worksheet.Cells[i + 2, excelColumnIndex].Value = "N/A";
                                }
                            }
                            // If the cell value is null, skip adding it to Excel
                            excelColumnIndex++;
                            progressBar.Value++;
                        }
                    }
                }

                // Hide the progress bar after completion
                progressBar.Visible = false;
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                // Hide the progress bar if there is an error
                progressBar.Visible = false;
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvAttendance != null)
            {
                ExportToExcel(dgvAttendance);
            }
            else
            {
                MessageBox.Show("DataGridView is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
