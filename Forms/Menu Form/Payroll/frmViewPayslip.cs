using MySql.Data.MySqlClient;
using Payroll_Management_System.Connections;
using Payroll_Management_System.Forms.Menu_Form.Attendance;
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
    public partial class frmViewPayslip : Form
    {
        public frmViewPayslip()
        {
            InitializeComponent();
        }

        public int emp_id { get; set; }
        public string attendance_batch_no { get; set; }
        public string cutoff_period { get; set; }

        string connString = frmLogin.connString;

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmOverviewPayroll frmOverviewPayroll = new frmOverviewPayroll();
                frmHome.DisplayForm(frmOverviewPayroll, frmHome.mainPanel);
            }
        }


        public bool isSaved = false;
        public void load_data()
        {
            // header 
            var (employee_name, department, job_title) = GetPayslip.GetEmployeeInfo(emp_id);
            txtEmpName.Text = employee_name;
            txtDeptTitle.Text = department + " | " + job_title;

            // reference (attendance batch no. and cutoff period
            txtAttendanceBatchNo.Text = "Attendance Batch No. : "+attendance_batch_no;
            txtPeriod.Text = "Period: "+cutoff_period;

            //get computation from attendance
            var (deduction_late, deduction_undertime, deduction_absent, addition_overtime, addition_nightpremium, addition_restdayduty, addition_legalholiday, addition_specialholiday) = GetPayslip.GetAttendanceComputation(emp_id, attendance_batch_no);

            //basic salary
            double basic_salary = GetPayslip.GetEmployeeSalary(emp_id, attendance_batch_no, cutoff_period);
            txtBasicSalary.Text = basic_salary.ToString("N3");
            
            //deductions
            txtTardiness.Text = deduction_late.ToString("N3");
            txtUndertime.Text = deduction_undertime.ToString("N3");
            txtAbsent.Text = deduction_absent.ToString("N3");

            //additions
            txtOvertime.Text = addition_overtime.ToString("N3");
            txtNightPrem.Text = addition_nightpremium.ToString("N3");
            txtRestdayDuty.Text = addition_restdayduty.ToString("N3");
            txtLegalHoliday.Text = addition_legalholiday.ToString("N3");
            txtSpecialHoliday.Text = addition_specialholiday.ToString("N3");

            //mandatory deductions
            var (deduction_sss_er, deduction_sss_ee, deduction_philhealth, deduction_pagibig) = GetPayslip.GetDeductionMandatory(basic_salary);
            if (cutoff_period != "First")
            {
                txtPagibig.Text = deduction_pagibig.ToString("N3");
                txtPhilhealth.Text = deduction_philhealth.ToString("N3");
                txtSSS.Text = deduction_sss_ee.ToString("N3");   
            }
            else
            {
                deduction_sss_ee = 0.00;
                deduction_sss_er = 0.00;
                deduction_philhealth = 0.00;
                deduction_pagibig = 0.00;
            }

            //hmo deductions
            double deduction_hmo = GetPayslip.GetDeductionHMO(emp_id);
            txtHMO.Text = deduction_hmo.ToString("N3");

            //store data to retrieve it in edit payslip form
            GetPayslipDetails.employee_name= employee_name;
            GetPayslipDetails.job_title= job_title;
            GetPayslipDetails.department= department;
            //attendance
            GetPayslipDetails.basic_salary= basic_salary;
            GetPayslipDetails.addition_overtime= addition_overtime;
            GetPayslipDetails.addition_nightpremium= addition_nightpremium;
            GetPayslipDetails.addition_restdayduty= addition_restdayduty;
            GetPayslipDetails.addition_legalholiday= addition_legalholiday;
            GetPayslipDetails.addition_specialholiday= addition_specialholiday;
            GetPayslipDetails.deduction_late= deduction_late;
            GetPayslipDetails.deduction_undertime= deduction_undertime;
            GetPayslipDetails.deduction_absent= deduction_absent;
            //mandatory
            GetPayslipDetails.deduction_philhealth = deduction_philhealth;
            GetPayslipDetails.deduction_sss = deduction_sss_ee;
            GetPayslipDetails.deduction_pagibig = deduction_pagibig;
            GetPayslipDetails.deduction_hmo= deduction_hmo;


        }

        public void gross_salary_computation()
        {
            // gross salary computation
            try

            {
                Guna.UI2.WinForms.Guna2TextBox[] addition_input = //array ng textfields
                {
                    txtBasicSalary, txtOvertime, txtNightPrem, txtRestdayDuty, txtLegalHoliday, txtSpecialHoliday, txtSpecialHoliday,
                    txtTransportationAllowance, txtMealAllowance, txtCarAllowance, txtGasAllowance, txtNonTaxAllowance, txtOtherAllowance
                };

                double gross_salary = 0;
                foreach (Guna.UI2.WinForms.Guna2TextBox textBox in addition_input)
                {
                    double value = string.IsNullOrWhiteSpace(textBox.Text) ? 0 : Convert.ToDouble(textBox.Text); //if null = 0; else  = value
                    gross_salary += value;
                }
                txtGrossSalary.Text = gross_salary.ToString("N3");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Message: "+ex.Message);

            }


        }

        public void total_deduction_computation()
        {
            try

            {
                Guna.UI2.WinForms.Guna2TextBox[] arr_deductions =
                {
                   txtTardiness, txtAbsent, txtUndertime, txtSSS, txtPhilhealth, txtPagibig, txtHMO, txtWithholdingTax,
                   txtSSSLoan, txtCalamityLoan, txtPagibigLoan, txtProductDeductions, txtCashAdvance, txtOtherDeductions
                };

                double total_deductions = 0;
                foreach (Guna.UI2.WinForms.Guna2TextBox textbox in arr_deductions)
                {
                    double value = string.IsNullOrEmpty(textbox.Text) ? 0 : Convert.ToDouble(textbox.Text);
                    total_deductions += value;
                }
                txtTotalDeductions.Text = total_deductions.ToString("N3");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Message"+ex);

            }
        }

        public void net_salary_computation()
        {
            try

            {
                double gross_salary = string.IsNullOrWhiteSpace(txtGrossSalary.Text) ? 0 : Convert.ToDouble(txtGrossSalary.Text);
                double total_deductions = string.IsNullOrWhiteSpace(txtTotalDeductions.Text) ? 0 : Convert.ToDouble(txtTotalDeductions.Text);


                // Calculate gross salary
                double net_salary = gross_salary - total_deductions;

                // Display gross salary in the text box formatted to three decimal places
                txtNetSalary.Text = net_salary.ToString("N3");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Message"+ex);

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            frmEditPayslip frmEditPayslip = new frmEditPayslip();
            frmEditPayslip.emp_id = emp_id;
            frmEditPayslip.attendance_batch_no = attendance_batch_no;
            frmEditPayslip.cutoff_period = cutoff_period;
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmHome.DisplayForm(frmEditPayslip, frmHome.mainPanel);

            }
        }

        private void frmViewPayslip_Load(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                load_data();
                gross_salary_computation();
                total_deduction_computation();
                net_salary_computation();
            }
            else
            {
                MessageBox.Show("saved na data kaya iba na dapat makikita");
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to approve this payslip?", "Message Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        string query = "UPDATE attendance_monitoring SET status = 'For Payroll' WHERE attendance_batch_no=@attendance_batch_no AND emp_id=@emp_id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no);
                        cmd.Parameters.AddWithValue("@emp_id", emp_id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Payslip has been approved.", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

                        if (frmHome.mainPanel != null)
                        {

                            frmOverviewPayroll frmOverviewPayroll = new frmOverviewPayroll();
                            frmHome.DisplayForm(frmOverviewPayroll, frmHome.mainPanel);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error"+ex);
                }
                
            }
            else
            {
                return;
            }
        }

        
    }
}
