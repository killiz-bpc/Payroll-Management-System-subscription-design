using MySql.Data.MySqlClient;
using Payroll_Management_System.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        string connString = frmLogin.connString;
       
        
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmViewPayslip frmViewPayslip = new frmViewPayslip();
            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

            if (frmHome.mainPanel != null)
            {
                frmHome.DisplayForm(frmViewPayslip, frmHome.mainPanel);
            }
        }

        public void gross_pay_computation()
        {
            try

            {
                Guna.UI2.WinForms.Guna2TextBox[] arr_deductions =
                {
                   txtBasicSalary, txtSalaryAdjustment, txtTardiness, txtAbsent, txtUndertime
                };

                double gross_pay = 0;
                foreach (Guna.UI2.WinForms.Guna2TextBox textbox in arr_deductions)
                {
                    double value = string.IsNullOrEmpty(textbox.Text) ? 0 : Convert.ToDouble(textbox.Text);

                    if (textbox != txtBasicSalary && textbox != txtSalaryAdjustment)
                    {
                        value = -value;
                    }
                    
                    gross_pay += value;
                }

                txtGrossSalary.Text = gross_pay.ToString("N3");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Message"+ex);

            }
        }


        public void total_deduction_computation()
        {

            try

            {

                Guna.UI2.WinForms.Guna2TextBox[] arr_deductions =
                {
                   txtSSS, txtPhilhealth, txtPagibig, txtHMO, txtWithholdingTax, 
                   txtSSSLoan, txtCalamityLoan, txtPagibigLoan, txtProductDeductions, txtCashAdvance, txtOtherDeductions
                };

                double total_deductions = 0;
                foreach(Guna.UI2.WinForms.Guna2TextBox textbox in arr_deductions)
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
                Guna.UI2.WinForms.Guna2TextBox[] overall_compensation =
               {
                    txtOvertime, txtNightPrem, txtRestdayDuty, txtLegalHoliday, txtSpecialHoliday, txtSpecialHoliday,
                    txtTransportationAllowance, txtMealAllowance, txtCarAllowance, txtGasAllowance, txtNonTaxAllowance, txtOtherAllowance
                };

                double compensation = 0;
                foreach (Guna.UI2.WinForms.Guna2TextBox textbox in overall_compensation)
                {
                    double input_value = string.IsNullOrEmpty(textbox.Text) ? 0.0 : Convert.ToDouble(textbox.Text);
                    compensation+=input_value;
                }


                double gross_salary = string.IsNullOrWhiteSpace(txtGrossSalary.Text) ? 0 : Convert.ToDouble(txtGrossSalary.Text);
                double total_deductions = string.IsNullOrWhiteSpace(txtTotalDeductions.Text) ? 0 : Convert.ToDouble(txtTotalDeductions.Text);


                // Calculate gross salary
                double net_salary = gross_salary + compensation - total_deductions;
                // Display gross salary in the text box formatted to three decimal places
                txtNetSalary.Text = net_salary.ToString("N3");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Message"+ex);

            }
        }



        public void not_saved()
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

            txtHMO.Text = GetPayslipDetails.deduction_hmo.ToString("N3");
            txtGrossSalary.Text = GetPayslipDetails.gross_pay.ToString("N3");
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
                    string salary_adjustment = "";


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
                        salary_adjustment = sdr.GetDouble("salary_adjustment").ToString();
                    }


                    var (employee_name, department, job_title) = GetPayslip.GetEmployeeInfo(GetPayslipDetails.emp_id);
                    txtEmployeeName.Text = employee_name;
                    txtDepartment.Text = department;
                    txtJobTitle.Text = job_title;


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
                    txtSalaryAdjustment.Text = salary_adjustment;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }
        private void frmEditPayslip_Load(object sender, EventArgs e)
        {
            frmViewPayslip frmViewPayslip = new frmViewPayslip();
            if(!GetPayslipDetails.isSaved)
            {
                
                not_saved(); // hindi pa naf-finalize yung data
            }
            else
            {
                load_saved_data(); //nakapagsave na ng data                
            }

            gross_pay_computation();
            total_deduction_computation();  //pre-computation ng total deduction
            net_salary_computation(); //pre-computation ng net salary

        }

        public void convertion_of_textboxes()
        {

            string basic_salary = txtBasicSalary.Text;
            string new_basic_salary = basic_salary.Replace(",", "");

            MessageBox.Show(basic_salary);
            MessageBox.Show(new_basic_salary);
          
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save? It cannot be undone", "Message Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if(result == DialogResult.Yes)
                {
                    if (!GetPayslipDetails.isSaved) //first time i-save ang data
                    {
                        try
                        {
                            using (MySqlConnection conn = new MySqlConnection(connString))
                            {
                                conn.Open();
                                string query = "INSERT INTO payroll_process_tb (attendance_batch_no,  cutoff_period, emp_id, employee_name, department, basic_salary, addition_overtime, addition_nightpremium, addition_legalholiday, addition_restdayduty, addition_specialholiday, addition_transpo_allowance, addition_meal_allowance, addition_car_allowance, addition_gas_allowance, addition_nontax_allowance, addition_other_allowance, gross_salary, deduction_late, deduction_undertime, deduction_absent, deduction_sss_ee, deduction_philhealth, deduction_pagibig, deduction_product_deductions, deduction_hmo, deduction_withholdingtax, deduction_sss_loan, deduction_calamity_loan, deduction_pagibig_loan, deduction_cash_advances, deduction_other_deductions, total_deductions, net_salary, salary_adjustment) VALUES (@attendance_batch_no,  @cutoff_period, @emp_id, @employee_name, @department, @basic_salary, @addition_overtime, @addition_nightpremium, @addition_legalholiday, @addition_restdayduty, @addition_specialholiday, @addition_transpo_allowance, @addition_meal_allowance, @addition_car_allowance, @addition_gas_allowance, @addition_nontax_allowance, @addition_other_allowance, @gross_salary, @deduction_late, @deduction_undertime, @deduction_absent, @deduction_sss_ee, @deduction_philhealth, @deduction_pagibig, @deduction_product_deductions, @deduction_hmo, @deduction_withholdingtax, @deduction_sss_loan, @deduction_calamity_loan, @deduction_pagibig_loan, @deduction_cash_advances, @deduction_other_deductions, @total_deductions, @net_salary, @salary_adjustment)";
                                MySqlCommand cmd = new MySqlCommand(query, conn);


                                cmd.Parameters.AddWithValue("@attendance_batch_no", GetPayslipDetails.attendance_batch_no);
                                cmd.Parameters.AddWithValue("@cutoff_period", GetPayslipDetails.cutoff_period);
                                cmd.Parameters.AddWithValue("@emp_id", GetPayslipDetails.emp_id);
                                cmd.Parameters.AddWithValue("@employee_name", txtEmployeeName.Text);
                                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                                cmd.Parameters.AddWithValue("@basic_salary", GetPayslip.ConvertToDouble(txtBasicSalary.Text));
                                cmd.Parameters.AddWithValue("@addition_overtime", GetPayslip.ConvertToDouble(txtOvertime.Text));
                                cmd.Parameters.AddWithValue("@addition_nightpremium", GetPayslip.ConvertToDouble(txtNightPrem.Text));
                                cmd.Parameters.AddWithValue("@addition_restdayduty", GetPayslip.ConvertToDouble(txtRestdayDuty.Text));
                                cmd.Parameters.AddWithValue("@addition_legalholiday", GetPayslip.ConvertToDouble(txtLegalHoliday.Text));
                                cmd.Parameters.AddWithValue("@addition_specialholiday", GetPayslip.ConvertToDouble(txtSpecialHoliday.Text));
                                cmd.Parameters.AddWithValue("@addition_transpo_allowance", GetPayslip.ConvertToDouble(txtTransportationAllowance.Text));
                                cmd.Parameters.AddWithValue("@addition_meal_allowance", GetPayslip.ConvertToDouble(txtMealAllowance.Text));
                                cmd.Parameters.AddWithValue("@addition_car_allowance", GetPayslip.ConvertToDouble(txtCarAllowance.Text));
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
                                cmd.Parameters.AddWithValue("@salary_adjustment", GetPayslip.ConvertToDouble(txtSalaryAdjustment.Text));
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Payslip has been saved successfully","Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                GetPayslipDetails.isSaved = true;

                                frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();
                                if (frmHome.mainPanel != null)
                                {
                                    frmViewPayslip frmViewPayslip = new frmViewPayslip();
                                    frmHome.DisplayForm(frmViewPayslip, frmHome.mainPanel);
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:"+ex, "Message Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        try
                        {
                            using (MySqlConnection conn = new MySqlConnection(connString))
                            {
                                conn.Open();
                                string query = "UPDATE payroll_process_tb SET basic_salary=@basic_salary, addition_overtime=@addition_overtime, addition_nightpremium=@addition_nightpremium, addition_legalholiday=@addition_legalholiday, addition_restdayduty=@addition_restdayduty, addition_specialholiday=@addition_specialholiday, addition_transpo_allowance=@addition_transpo_allowance, addition_meal_allowance=@addition_meal_allowance, addition_car_allowance=@addition_car_allowance, addition_gas_allowance=@addition_gas_allowance, addition_nontax_allowance=@addition_nontax_allowance, addition_other_allowance=@addition_other_allowance, gross_salary=@gross_salary, deduction_late=@deduction_late, deduction_undertime=@deduction_undertime, deduction_absent=@deduction_absent, deduction_sss_ee=@deduction_sss_ee, deduction_philhealth=@deduction_philhealth, deduction_pagibig=@deduction_pagibig, deduction_product_deductions=@deduction_product_deductions, deduction_hmo=@deduction_hmo, deduction_withholdingtax=@deduction_withholdingtax, deduction_sss_loan=@deduction_sss_loan, deduction_calamity_loan=@deduction_calamity_loan, deduction_pagibig_loan=@deduction_pagibig_loan, deduction_cash_advances=@deduction_cash_advances, deduction_other_deductions=@deduction_other_deductions, total_deductions=total_deductions, net_salary=@net_salary, salary_adjustment=@salary_adjustment WHERE emp_id=@emp_id AND attendance_batch_no=@attendance_batch_no AND cutoff_period=@cutoff_period";

                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@emp_id", GetPayslipDetails.emp_id);
                                cmd.Parameters.AddWithValue("@attendance_batch_no", GetPayslipDetails.attendance_batch_no);
                                cmd.Parameters.AddWithValue("@cutoff_period", GetPayslipDetails.cutoff_period);

                                cmd.Parameters.AddWithValue("@basic_salary", GetPayslip.ConvertToDouble(txtBasicSalary.Text));
                                cmd.Parameters.AddWithValue("@addition_overtime", GetPayslip.ConvertToDouble(txtOvertime.Text));
                                cmd.Parameters.AddWithValue("@addition_nightpremium", GetPayslip.ConvertToDouble(txtNightPrem.Text));
                                cmd.Parameters.AddWithValue("@addition_restdayduty", GetPayslip.ConvertToDouble(txtRestdayDuty.Text));
                                cmd.Parameters.AddWithValue("@addition_legalholiday", GetPayslip.ConvertToDouble(txtLegalHoliday.Text));
                                cmd.Parameters.AddWithValue("@addition_specialholiday", GetPayslip.ConvertToDouble(txtSpecialHoliday.Text));
                                cmd.Parameters.AddWithValue("@addition_transpo_allowance", GetPayslip.ConvertToDouble(txtTransportationAllowance.Text));
                                cmd.Parameters.AddWithValue("@addition_meal_allowance", GetPayslip.ConvertToDouble(txtMealAllowance.Text));
                                cmd.Parameters.AddWithValue("@addition_car_allowance", GetPayslip.ConvertToDouble(txtCarAllowance.Text));
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
                                cmd.Parameters.AddWithValue("@salary_adjustment", GetPayslip.ConvertToDouble(txtSalaryAdjustment.Text));
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Changes has been saved successfully", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                GetPayslipDetails.isSaved = true;
                                frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();
                                if (frmHome.mainPanel != null)
                                {
                                    frmViewPayslip frmViewPayslip = new frmViewPayslip();
                                    frmHome.DisplayForm(frmViewPayslip, frmHome.mainPanel);
                                }



                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error:"+ex,"Message Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    
                }
                else
                {
                    return;
                }
            }
            
        }

        private void txtOvertime_Validated(object sender, EventArgs e)
        {
            gross_pay_computation();
            net_salary_computation();
        }

        private void txtOvertime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void guna2HtmlLabel21_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSSS_Validated(object sender, EventArgs e)
        {
            total_deduction_computation();
            net_salary_computation();
        }

        private void txtSpecialHoliday_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtTransportationAllowance_Validating(object sender, CancelEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox[] input_textboxes = //array ng textfields
                {
                    txtBasicSalary, txtOvertime, txtNightPrem, txtRestdayDuty, txtLegalHoliday, txtSpecialHoliday, txtSpecialHoliday,
                    txtTransportationAllowance, txtMealAllowance, txtCarAllowance, txtGasAllowance, txtNonTaxAllowance, txtOtherAllowance,
                    txtTardiness, txtAbsent, txtUndertime, txtSSS, txtPhilhealth, txtPagibig, txtHMO, txtWithholdingTax,
                    txtSSSLoan, txtCalamityLoan, txtPagibigLoan, txtProductDeductions, txtCashAdvance, txtOtherDeductions
                };

            foreach (Guna.UI2.WinForms.Guna2TextBox textbox in input_textboxes)
            {
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    e.Cancel= true;
                    errorProvider1.SetError(textbox, "Please input 0 if none");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textbox, string.Empty);
                    
                }
            }
        }

        private void txtSalaryAdjustment_Validated(object sender, EventArgs e)
        {
            gross_pay_computation();
        }
    }
}
