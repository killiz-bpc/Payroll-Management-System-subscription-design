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
                Guna.UI2.WinForms.Guna2TextBox [] addition_input = //array ng textfields
                {
                    txtBasicSalary, txtOvertime, txtNightPrem, txtRestdayDuty, txtLegalHoliday, txtSpecialHoliday, txtSpecialHoliday,
                    txtTransportationAllowance, txtMealAllowance, txtCarAllowance, txtGasAllowance, txtNonTaxAllowance, txtOtherAllowance
                };

                double gross_salary = 0;

                foreach(Guna.UI2.WinForms.Guna2TextBox textBox in addition_input)
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
        }


        private void frmEditPayslip_Load(object sender, EventArgs e)
        {
            frmViewPayslip frmViewPayslip = new frmViewPayslip();

            if(!frmViewPayslip.isSaved)
            {
                
                not_saved(); // hindi pa naf-finalize yung data
                gross_salary_computation(); //pre-computation ng gross salary
                total_deduction_computation();  //pre-computation ng total deduction
                net_salary_computation(); //pre-computation ng net salary

            }
            else
            {
                MessageBox.Show("true");
            }
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
                    try
                    {


                        using (MySqlConnection conn = new MySqlConnection(connString))
                        {
                            conn.Open();
                            string query = "INSERT INTO payroll_process_tb (attendance_batch_no,  cutoff_period, emp_id, employee_name, department, basic_salary, addition_overtime, addition_nightpremium, addition_legalholiday, addition_restdayduty, addition_specialholiday, addition_transpo_allowance, addition_meal_allowance, addition_gas_allowance, addition_nontax_allowance, addition_other_allowance, gross_salary, deduction_late, deduction_undertime, deduction_absent, deduction_sss_ee, deduction_philhealth, deduction_pagibig, deduction_product_deductions, deduction_hmo, deduction_withholdingtax, deduction_sss_loan, deduction_calamity_loan, deduction_pagibig_loan, deduction_cash_advances, deduction_other_deductions, total_deductions, net_salary) VALUES (@attendance_batch_no,  @cutoff_period, @emp_id, @employee_name, @department, @basic_salary, @addition_overtime, @addition_nightpremium, @addition_legalholiday, @addition_restdayduty, @addition_specialholiday, @addition_transpo_allowance, @addition_meal_allowance, @addition_gas_allowance, @addition_nontax_allowance, @addition_other_allowance, @gross_salary, @deduction_late, @deduction_undertime, @deduction_absent, @deduction_sss_ee, @deduction_philhealth, @deduction_pagibig, @deduction_product_deductions, @deduction_hmo, @deduction_withholdingtax, @deduction_sss_loan, @deduction_calamity_loan, @deduction_pagibig_loan, @deduction_cash_advances, @deduction_other_deductions, @total_deductions, @net_salary)";
                            MySqlCommand cmd = new MySqlCommand(query, conn);

                           
                            cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no);
                            cmd.Parameters.AddWithValue("@cutoff_period", cutoff_period);
                            cmd.Parameters.AddWithValue("@emp_id", emp_id);
                            cmd.Parameters.AddWithValue("@employee_name", txtEmployeeName.Text);
                            cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                            cmd.Parameters.AddWithValue("@basic_salary", GetPayslip.ConvertToDouble(txtBasicSalary.Text));
                            cmd.Parameters.AddWithValue("@addition_overtime", GetPayslip.ConvertToDouble(txtBasicSalary.Text));
                            cmd.Parameters.AddWithValue("@addition_nightpremium", GetPayslip.ConvertToDouble(txtBasicSalary.Text));
                            cmd.Parameters.AddWithValue("@addition_restdayduty", GetPayslip.ConvertToDouble(txtRestdayDuty.Text));
                            cmd.Parameters.AddWithValue("@addition_legalholiday", GetPayslip.ConvertToDouble(txtLegalHoliday.Text));
                            cmd.Parameters.AddWithValue("@addition_specialholiday", GetPayslip.ConvertToDouble(txtSpecialHoliday.Text));    
                            cmd.Parameters.AddWithValue("@addition_transpo_allowance", GetPayslip.ConvertToDouble(txtTransportationAllowance.Text));
                            cmd.Parameters.AddWithValue("@addition_meal_allowance", GetPayslip.ConvertToDouble(txtMealAllowance.Text));
                            cmd.Parameters.AddWithValue("@addition_gas_allowance", GetPayslip.ConvertToDouble(txtGasAllowance.Text));
                            cmd.Parameters.AddWithValue("@addition_nontax_allowance", GetPayslip.ConvertToDouble(txtNonTaxAllowance.Text));
                            cmd.Parameters.AddWithValue("@addition_other_allowance", GetPayslip.ConvertToDouble(txtOtherAllowance.Text));
                            cmd.Parameters.AddWithValue("@gross_salary", GetPayslip.ConvertToDouble(txtGrossSalary.Text));
                            cmd.Parameters.AddWithValue("@deduction_late", GetPayslip.ConvertToDouble(txtAbsent.Text));
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
                            cmd.Parameters.AddWithValue("@deduction_pagibig_loan", GetPayslip.ConvertToDouble(txtPagibig.Text));
                            cmd.Parameters.AddWithValue("@deduction_cash_advances", GetPayslip.ConvertToDouble(txtCashAdvance.Text));
                            cmd.Parameters.AddWithValue("@deduction_other_deductions", GetPayslip.ConvertToDouble(txtOtherDeductions.Text));
                            cmd.Parameters.AddWithValue("@total_deductions", GetPayslip.ConvertToDouble(txtTotalDeductions.Text));
                            cmd.Parameters.AddWithValue("@net_salary", GetPayslip.ConvertToDouble(txtNetSalary.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Inserted");
                            frmViewPayslip frmViewPayslip = new frmViewPayslip();
                            frmViewPayslip.isSaved = true;
                            frmHome frmHome = Application.OpenForms.OfType<frmHome>().FirstOrDefault();

                            if (frmHome.mainPanel != null)
                            {
                                frmHome.DisplayForm(frmViewPayslip, frmHome.mainPanel);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Message: " + ex.Message);
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
            gross_salary_computation();
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
    }
}
