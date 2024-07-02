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

namespace Payroll_Management_System.Forms.Menu_Form
{
    public partial class frmImportAttendance : Form
    {
        public frmImportAttendance()
        {
            InitializeComponent();
        }

        public void import_attendance()
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;

            openFileDialog1.Filter = "Excel Office |*.xls; *xlsx";
            openFileDialog1.ShowDialog();
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
    }
}
