using Payroll_Management_System.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms.Menu_Form.Payroll
{
    public partial class frmEditPayslip : Form
    {
        public frmEditPayslip()
        {
            InitializeComponent();
        }

        public int emp_id { get; set; }
        public string attendance_batch_no { get; set; }
        public string cutoff_period { get; set; }

       
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmViewPayslip frmViewPayslip = new frmViewPayslip();
            frmViewPayslip.emp_id = emp_id;
            frmViewPayslip.attendance_batch_no = attendance_batch_no;
            frmViewPayslip.cutoff_period = cutoff_period;


            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmHome.DisplayForm(frmViewPayslip, frmHome.mainPanel);
            }
        }

        public void gross_salary_computation()
        {

            try
            {
                double overtime = string.IsNullOrWhiteSpace(txtOvertime.Text) ? 0 : Convert.ToDouble(txtOvertime.Text);
                double nightprem = string.IsNullOrWhiteSpace(txtNightPrem.Text) ? 0 : Convert.ToDouble(txtNightPrem.Text);
                double restday_duty = string.IsNullOrWhiteSpace(txtRestdayDuty.Text) ? 0 : Convert.ToDouble(txtRestdayDuty.Text);
                double legal_holiday = string.IsNullOrWhiteSpace(txtLegalHoliday.Text) ? 0 : Convert.ToDouble(txtLegalHoliday.Text);
                double special_holiday = string.IsNullOrWhiteSpace(txtSpecialHoliday.Text) ? 0 : Convert.ToDouble(txtSpecialHoliday.Text);

                // Calculate gross salary
                double gross_salary = overtime + nightprem + restday_duty + legal_holiday + special_holiday;

                // Display gross salary in the text box formatted to three decimal places
                txtGrossSalary.Text = gross_salary.ToString("N3");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Message"+ex);
                
            }
           
        }

        private void frmEditPayslip_Load(object sender, EventArgs e)
        {
            frmViewPayslip frmViewPayslip = new frmViewPayslip();

            if(!frmViewPayslip.isSaved)
            {

                
                txtEmployeeName.Text = GetPayslipDetails.employee_name;
                txtJobTitle.Text = GetPayslipDetails.job_title;
                txtDepartment.Text = GetPayslipDetails.department;

                txtBasicSalary.Text = GetPayslipDetails.basic_salary.ToString("N3");

                //deductions
                txtTardiness.Text = GetPayslipDetails.deduction_late.ToString("N3");
                txtUndertime.Text = GetPayslipDetails.deduction_undertime.ToString("N3");
                txtAbsent.Text = GetPayslipDetails.deduction_absent.ToString("N3");

                //additions
                txtOvertime.Text = GetPayslipDetails.addition_overtime.ToString("N3");
                txtNightPrem.Text = GetPayslipDetails.addition_nightpremium.ToString("N3");
                txtRestdayDuty.Text = GetPayslipDetails.addition_restdayduty.ToString("N3");
                txtLegalHoliday.Text = GetPayslipDetails.addition_legalholiday.ToString("N3");
                txtSpecialHoliday.Text = GetPayslipDetails.addition_specialholiday.ToString("N3");




                



            }
            else
            {
                MessageBox.Show("true");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmViewPayslip frmViewPayslip = new frmViewPayslip();
            frmViewPayslip.isSaved = true;
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmHome.DisplayForm(frmViewPayslip, frmHome.mainPanel);
            }
        }

        private void txtOvertime_Validated(object sender, EventArgs e)
        {
            gross_salary_computation();
        }

        private void txtOvertime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
