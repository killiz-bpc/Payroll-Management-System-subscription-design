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

        public string emp_department {  get; set; }



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


     
        public void load_data()
        {
            // header 
            var (employee_name, department, job_title) = GetPayslip.GetEmployeeInfo(GetPayslipDetails.emp_id);
            txtEmpName.Text = employee_name;
            txtDeptTitle.Text = department + " | " + job_title;
            emp_department = department;

            // reference (attendance batch no. and cutoff period
            txtAttendanceBatchNo.Text = "Attendance Batch No. : "+GetPayslipDetails.attendance_batch_no;
            txtPeriod.Text = "Period: "+GetPayslipDetails.cutoff_period;

            //get computation from attendance
            var (deduction_late, deduction_undertime, deduction_absent, addition_overtime, addition_nightpremium, addition_restdayduty, addition_legalholiday, addition_specialholiday) = GetPayslip.GetAttendanceComputation(GetPayslipDetails.emp_id, GetPayslipDetails.attendance_batch_no);

            //basic salary
            double basic_salary = GetPayslip.GetEmployeeSalary(GetPayslipDetails.emp_id, GetPayslipDetails.attendance_batch_no, GetPayslipDetails.cutoff_period);
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
            if (GetPayslipDetails.cutoff_period != "First")
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
            double deduction_hmo = GetPayslip.GetDeductionHMO(GetPayslipDetails.emp_id);
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

        public void load_saved_data()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM payroll_process_tb where emp_id=@emp_id AND attendance_batch_no=@attendance_batch_no AND cutoff_period=@cutoff_period";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@emp_id", GetPayslipDetails.emp_id);
                    cmd.Parameters.AddWithValue("@attendance_batch_no", GetPayslipDetails.attendance_batch_no);
                    cmd.Parameters.AddWithValue("@cutoff_period", GetPayslipDetails.cutoff_period);

                    MySqlDataReader sdr = cmd.ExecuteReader();

                  
                    string basic_salary = "";
                    string addition_overtime = "";
                    string addition_nightpremium = "";
                    string addition_restdayduty = "";
                    string addition_legalholiday = "";
                    string addition_specialholiday = "";
                    string addition_transpo_allowance = "";
                    string addition_meal_allowance = "";
                    string addition_car_allowance = "";
                    string addition_gas_allowance = "";
                    string addition_nontax_allowance = "";
                    string addition_other_allowance = "";
                    string gross_salary = "";
                    string deduction_late = "";
                    string deduction_undertime = "";
                    string deduction_absent = "";
                    string deduction_sss_ee = "";
                    string deduction_philhealth = "";
                    string deduction_pagibig = "";
                    string deduction_product_deductions = "";
                    string deduction_hmo = "";
                    string deduction_withholdingtax = "";
                    string deduction_sss_loan = "";
                    string deduction_calamity_loan = "";
                    string deduction_pagibig_loan = "";
                    string deduction_cash_advances = "";
                    string deduction_other_deductions = "";
                    string total_deductions = "";
                    string net_salary = "";


                    while (sdr.Read())
                    {
                        basic_salary = sdr.GetDouble("basic_salary").ToString();
                        addition_overtime = sdr.GetDouble("addition_overtime").ToString();
                        addition_nightpremium = sdr.GetDouble("addition_nightpremium").ToString();
                        addition_restdayduty = sdr.GetDouble("addition_restdayduty").ToString();
                        addition_legalholiday = sdr.GetDouble("addition_legalholiday").ToString();
                        addition_specialholiday = sdr.GetDouble("addition_specialholiday").ToString();
                        addition_transpo_allowance = sdr.GetDouble("addition_transpo_allowance").ToString();
                        addition_meal_allowance = sdr.GetDouble("addition_meal_allowance").ToString();
                        addition_car_allowance = sdr.GetDouble("addition_car_allowance").ToString();
                        addition_gas_allowance = sdr.GetDouble("addition_gas_allowance").ToString();
                        addition_nontax_allowance = sdr.GetDouble("addition_nontax_allowance").ToString();
                        addition_other_allowance = sdr.GetDouble("addition_other_allowance").ToString();
                        gross_salary = sdr.GetDouble("gross_salary").ToString();
                        deduction_late = sdr.GetDouble("deduction_late").ToString();
                        deduction_undertime = sdr.GetDouble("deduction_undertime").ToString();
                        deduction_absent = sdr.GetDouble("deduction_absent").ToString();
                        deduction_sss_ee = sdr.GetDouble("deduction_sss_ee").ToString();
                        deduction_philhealth = sdr.GetDouble("deduction_philhealth").ToString();
                        deduction_pagibig = sdr.GetDouble("deduction_pagibig").ToString();
                        deduction_product_deductions = sdr.GetDouble("deduction_product_deductions").ToString();
                        deduction_hmo = sdr.GetDouble("deduction_hmo").ToString();
                        deduction_withholdingtax = sdr.GetDouble("deduction_withholdingtax").ToString();
                        deduction_sss_loan = sdr.GetDouble("deduction_sss_loan").ToString();
                        deduction_calamity_loan = sdr.GetDouble("deduction_calamity_loan").ToString();
                        deduction_pagibig_loan = sdr.GetDouble("deduction_pagibig_loan").ToString();
                        deduction_cash_advances = sdr.GetDouble("deduction_cash_advances").ToString();
                        deduction_other_deductions = sdr.GetDouble("deduction_other_deductions").ToString();
                        total_deductions = sdr.GetDouble("total_deductions").ToString();
                        net_salary = sdr.GetDouble("net_salary").ToString();
                    }


                    var (employee_name, department, job_title) = GetPayslip.GetEmployeeInfo(GetPayslipDetails.emp_id);
                    txtEmpName.Text = employee_name;
                    txtDeptTitle.Text = department + " | " + job_title;

                    // reference (attendance batch no. and cutoff period
                    txtAttendanceBatchNo.Text = "Attendance Batch No. : "+GetPayslipDetails.attendance_batch_no;
                    txtPeriod.Text = "Period: "+GetPayslipDetails.cutoff_period;


                    txtBasicSalary.Text = basic_salary;
                    txtOvertime.Text = addition_overtime;
                    txtNightPrem.Text = addition_nightpremium;
                    txtRestdayDuty.Text = addition_restdayduty; 
                    txtLegalHoliday.Text = addition_legalholiday; 
                    txtSpecialHoliday.Text = addition_specialholiday; 
                    txtTransportationAllowance.Text = addition_transpo_allowance; 
                    txtMealAllowance.Text = addition_meal_allowance; 
                    txtCarAllowance.Text = addition_car_allowance; 
                    txtGasAllowance.Text = addition_gas_allowance;
                    txtNonTaxAllowance.Text = addition_nontax_allowance;
                    txtOtherAllowance.Text = addition_other_allowance;
                    txtGrossSalary.Text = gross_salary;
                    txtTardiness.Text = deduction_late;
                    txtUndertime.Text = deduction_undertime;
                    txtAbsent.Text = deduction_absent;
                    txtSSS.Text = deduction_sss_ee; 
                    txtPhilhealth.Text = deduction_philhealth;
                    txtPagibig.Text = deduction_pagibig;
                    txtProductDeductions.Text = deduction_product_deductions;
                    txtHMO.Text = deduction_hmo;
                    txtWithholdingTax.Text = deduction_withholdingtax;
                    txtSSSLoan.Text = deduction_sss_loan;
                    txtCalamityLoan.Text = deduction_calamity_loan;
                    txtPagibigLoan.Text = deduction_pagibig_loan;
                    txtCashAdvance.Text = deduction_cash_advances;
                    txtOtherDeductions.Text = deduction_other_deductions;
                    txtTotalDeductions.Text = total_deductions;
                    txtNetSalary.Text = net_salary;



                } 
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
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
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmHome.DisplayForm(frmEditPayslip, frmHome.mainPanel);

            }
        }

        private void frmViewPayslip_Load(object sender, EventArgs e)
        {
            if (!GetPayslipDetails.isSaved)
            {
                load_data();
            }
            else
            {
               
                load_saved_data();
            }
            gross_salary_computation();
            total_deduction_computation();
            net_salary_computation();
        }

        public void insert_data()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO payroll_process_tb (attendance_batch_no,  cutoff_period, emp_id, employee_name, department, basic_salary, addition_overtime, addition_nightpremium, addition_legalholiday, addition_restdayduty, addition_specialholiday, addition_transpo_allowance, addition_meal_allowance, addition_gas_allowance, addition_nontax_allowance, addition_other_allowance, gross_salary, deduction_late, deduction_undertime, deduction_absent, deduction_sss_ee, deduction_philhealth, deduction_pagibig, deduction_product_deductions, deduction_hmo, deduction_withholdingtax, deduction_sss_loan, deduction_calamity_loan, deduction_pagibig_loan, deduction_cash_advances, deduction_other_deductions, total_deductions, net_salary) VALUES (@attendance_batch_no,  @cutoff_period, @emp_id, @employee_name, @department, @basic_salary, @addition_overtime, @addition_nightpremium, @addition_legalholiday, @addition_restdayduty, @addition_specialholiday, @addition_transpo_allowance, @addition_meal_allowance, @addition_gas_allowance, @addition_nontax_allowance, @addition_other_allowance, @gross_salary, @deduction_late, @deduction_undertime, @deduction_absent, @deduction_sss_ee, @deduction_philhealth, @deduction_pagibig, @deduction_product_deductions, @deduction_hmo, @deduction_withholdingtax, @deduction_sss_loan, @deduction_calamity_loan, @deduction_pagibig_loan, @deduction_cash_advances, @deduction_other_deductions, @total_deductions, @net_salary)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@attendance_batch_no", GetPayslipDetails.attendance_batch_no);
                    cmd.Parameters.AddWithValue("@cutoff_period", GetPayslipDetails.cutoff_period);
                    cmd.Parameters.AddWithValue("@emp_id", GetPayslipDetails.emp_id);
                    cmd.Parameters.AddWithValue("@employee_name", txtEmpName.Text);
                    cmd.Parameters.AddWithValue("@department", emp_department);
                    cmd.Parameters.AddWithValue("@basic_salary", GetPayslip.ConvertToDouble(txtBasicSalary.Text));
                    cmd.Parameters.AddWithValue("@addition_overtime", GetPayslip.ConvertToDouble(txtOvertime.Text));
                    cmd.Parameters.AddWithValue("@addition_nightpremium", GetPayslip.ConvertToDouble(txtNightPrem.Text));
                    cmd.Parameters.AddWithValue("@addition_restdayduty", GetPayslip.ConvertToDouble(txtRestdayDuty.Text));
                    cmd.Parameters.AddWithValue("@addition_legalholiday", GetPayslip.ConvertToDouble(txtLegalHoliday.Text));
                    cmd.Parameters.AddWithValue("@addition_specialholiday", GetPayslip.ConvertToDouble(txtSpecialHoliday.Text));
                    cmd.Parameters.AddWithValue("@addition_transpo_allowance", GetPayslip.ConvertToDouble(txtTransportationAllowance.Text));
                    cmd.Parameters.AddWithValue("@addition_meal_allowance", GetPayslip.ConvertToDouble(txtMealAllowance.Text));
                    cmd.Parameters.AddWithValue("@addition_gas_allowance", GetPayslip.ConvertToDouble(txtGasAllowance.Text));
                    cmd.Parameters.AddWithValue("@addition_nontax_allowance", GetPayslip.ConvertToDouble(txtNonTaxAllowance.Text));
                    cmd.Parameters.AddWithValue("@addition_other_allowance", GetPayslip.ConvertToDouble(txtOtherAllowance.Text));
                    cmd.Parameters.AddWithValue("@gross_salary", GetPayslip.ConvertToDouble(txtGrossSalary.Text));
                    cmd.Parameters.AddWithValue("@deduction_late", GetPayslip.ConvertToDouble(txtTardiness.Text));
                    cmd.Parameters.AddWithValue("@deduction_undertime", GetPayslip.ConvertToDouble(txtUndertime.Text));
                    cmd.Parameters.AddWithValue("@deduction_absent", GetPayslip.ConvertToDouble(txtAbsent.Text));
                    cmd.Parameters.AddWithValue("@deduction_sss_ee", GetPayslip.ConvertToDouble(txtSSS.Text));
                    cmd.Parameters.AddWithValue("@deduction_philhealth", GetPayslip.ConvertToDouble(txtPhilhealth.Text));
                    cmd.Parameters.AddWithValue("@deduction_pagibig", GetPayslip.ConvertToDouble(txtPagibig.Text));
                    cmd.Parameters.AddWithValue("@deduction_product_deductions", GetPayslip.ConvertToDouble(txtProductDeductions.Text));
                    cmd.Parameters.AddWithValue("@deduction_hmo", GetPayslip.ConvertToDouble(txtHMO.Text));
                    cmd.Parameters.AddWithValue("@deduction_withholdingtax", GetPayslip.ConvertToDouble(txtWithholdingTax.Text));
                    cmd.Parameters.AddWithValue("@deduction_sss_loan", GetPayslip.ConvertToDouble(txtSSSLoan.Text));
                    cmd.Parameters.AddWithValue("@deduction_calamity_loan", GetPayslip.ConvertToDouble(txtCalamityLoan.Text));
                    cmd.Parameters.AddWithValue("@deduction_pagibig_loan", GetPayslip.ConvertToDouble(txtPagibigLoan.Text));
                    cmd.Parameters.AddWithValue("@deduction_cash_advances", GetPayslip.ConvertToDouble(txtCashAdvance.Text));
                    cmd.Parameters.AddWithValue("@deduction_other_deductions", GetPayslip.ConvertToDouble(txtOtherDeductions.Text));
                    cmd.Parameters.AddWithValue("@total_deductions", GetPayslip.ConvertToDouble(txtTotalDeductions.Text));
                    cmd.Parameters.AddWithValue("@net_salary", GetPayslip.ConvertToDouble(txtNetSalary.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payslip has been saved successfully", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPayslipDetails.isSaved = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex, "Message Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to approve this payslip?", "Message Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if (!GetPayslipDetails.isSaved)
                {
                    insert_data();  //kapag ayaw na pumunta sa edit payslip diretso save agad
                }

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        string query = "UPDATE attendance_monitoring SET status = 'For Payroll' WHERE attendance_batch_no=@attendance_batch_no AND emp_id=@emp_id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@attendance_batch_no", GetPayslipDetails.attendance_batch_no);
                        cmd.Parameters.AddWithValue("@emp_id", GetPayslipDetails.emp_id);

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
