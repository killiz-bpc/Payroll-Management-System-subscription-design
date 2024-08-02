using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using Org.BouncyCastle.Crypto.Utilities;

namespace Payroll_Management_System.Connections
{
    public static class GetPayslip
    {
        public static string connString = frmLogin.connString;

        public static (string employee_name, string department, string job_title) GetEmployeeInfo(int emp_id)
        {
            string employee_name = "";
            string department = "";
            string job_title = "";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT employee_name, department, job_title FROM employee_information WHERE emp_id=@emp_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@emp_id", emp_id);
                MySqlDataReader sdr = cmd.ExecuteReader();

                while(sdr.Read())
                {
                    employee_name = sdr.GetString("employee_name").ToString();
                    department = sdr.GetString("department").ToString();
                    job_title = sdr.GetString("job_title").ToString();
                }

                conn.Dispose();
            }
            return (employee_name, department, job_title);
        }

        private static string GetEmployeeType(int emp_id)
        {

            string employee_type = "";
            try
            {

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT employee_type from employee_information WHERE emp_id=@emp_id;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@emp_id", emp_id);

                    MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        employee_type = sdr.GetString("employee_type");
                    }
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Message"+ex);
            }


            return employee_type;
        }
        public static double GetDeductionHMO(int emp_id)
        {
            string employee_type = GetEmployeeType(emp_id);
            double deduction_hmo = 0;
            try
            {

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT deduction_hmo FROM hmo_tb WHERE employee_type=@employee_type";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@employee_type", employee_type);

                    MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        deduction_hmo = sdr.GetDouble("deduction_hmo");
                    }
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Message"+ex);
            }
            return deduction_hmo;
        }

        public static double GetEmployeeSalary(int emp_id, string attendance_batch_no, string period)
        {
            double basic_salary = 0;

            if (period == "First")
            {
                var employee_salary = GetSalaryRate(emp_id);
                basic_salary = employee_salary.basic_salary;
            }
            else
            {
                basic_salary = 150;
            }
           
            return basic_salary;
        }

        public static (double salary, double basic_salary, double daily_rate, double hourly_rate, double minute_rate) GetSalaryRate(int emp_id)
        {
            double salary = 0;
            double basic_salary = 0;
            double daily_rate = 0;
            double hourly_rate = 0;
            double minute_rate = 0;


            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT salary, basic_salary, daily_rate, hourly_rate, minute_rate FROM employee_information where emp_id=@emp_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@emp_id", emp_id);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    salary = reader.GetDouble("salary");
                    basic_salary = reader.GetDouble("basic_salary");
                    daily_rate = reader.GetDouble("daily_rate");
                    minute_rate = reader.GetDouble("minute_rate");
                    hourly_rate = reader.GetDouble("hourly_rate");
                }
                conn.Dispose();
            }
            return (salary, basic_salary, daily_rate, hourly_rate, minute_rate);
        }

        public static (double deduction_late, double deduction_undertime, double deduction_absent, double addition_overtime, double addition_nightpremium, double addition_restdayduty, double addition_legalholiday, double addition_specialholiday) GetAttendanceComputation(int emp_id, string attendance_batch_no)
        {
            // rate of employee
            var employee_rate = GetSalaryRate(emp_id);
            double daily_rate = employee_rate.daily_rate;
            double minute_rate = employee_rate.minute_rate;
            double hourly_rate = employee_rate.hourly_rate;


            //get employee data atttendance
            var employee_attendance = GetEmployeeAttendance(emp_id, attendance_batch_no);
            double undertime = employee_attendance.undertime;
            double absent = employee_attendance.absent;
            double late = employee_attendance.late;
            double over_time = employee_attendance.over_time;
            double night_premium = employee_attendance.night_premium;
            double restday_duty = employee_attendance.restday_duty;
            double legal_holiday = employee_attendance.legal_holiday;
            double special_holiday = employee_attendance.special_holiday;

            //compute for deduction
            double deduction_late = late * minute_rate;  //mins of late 
            double deduction_undertime = undertime * minute_rate;  //mins of undertime 
            double deduction_absent = absent* daily_rate;

            //compute for additions
            double addition_overtime = over_time*hourly_rate*1.25;
            double addition_nightpremium = night_premium*hourly_rate*0.10;
            double addition_restdayduty = restday_duty*daily_rate*1.30;
            double addition_legalholiday = legal_holiday*daily_rate;
            double addition_specialholiday = special_holiday*daily_rate*0.30;


            return (deduction_late, deduction_undertime, deduction_absent, addition_overtime, addition_nightpremium, addition_restdayduty, addition_legalholiday, addition_specialholiday);
        }

        public static (double undertime, double absent, double late, double over_time, double night_premium, double restday_duty, double legal_holiday, double special_holiday) GetEmployeeAttendance(int emp_id, string attendance_batch_no)
        {
            double undertime = 0;
            double absent = 0;
            double late = 0;
            double over_time = 0;
            double night_premium = 0;
            double restday_duty = 0;
            double legal_holiday = 0;
            double special_holiday = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT absences, lates, under_time, over_time, night_premium, restday_duty, legal_holiday, special_holiday FROM attendance_monitoring where emp_id=@emp_id AND attendance_batch_no=@attendance_batch_no";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@emp_id", emp_id);
                    cmd.Parameters.AddWithValue("@attendance_batch_no", attendance_batch_no);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string absencesDB = reader["absences"].ToString();
                        string latesDB = reader["lates"].ToString();
                        string under_timeDB = reader["under_time"].ToString();
                        string over_timeDB = reader["over_time"].ToString();
                        string night_premiumDB = reader["night_premium"].ToString();
                        string restday_dutyDB = reader["restday_duty"].ToString();
                        string legal_holidayDB = reader["legal_holiday"].ToString();
                        string special_holidayDB = reader["special_holiday"].ToString();

                        absent = string.IsNullOrWhiteSpace(absencesDB) ? 0.0 : Convert.ToDouble(absencesDB);
                        late = string.IsNullOrWhiteSpace(latesDB) ? 0.0 : Convert.ToDouble(latesDB);
                        undertime = string.IsNullOrWhiteSpace(under_timeDB) ? 0.0 : Convert.ToDouble(under_timeDB);
                        over_time = string.IsNullOrWhiteSpace(over_timeDB) ? 0.0 : Convert.ToDouble(over_timeDB);
                        night_premium = string.IsNullOrWhiteSpace(night_premiumDB) ? 0.0 : Convert.ToDouble(night_premiumDB);
                        restday_duty = string.IsNullOrWhiteSpace(restday_dutyDB) ? 0.0 : Convert.ToDouble(restday_dutyDB);
                        legal_holiday = string.IsNullOrWhiteSpace(legal_holidayDB) ? 0.0 : Convert.ToDouble(legal_holidayDB);
                        special_holiday = string.IsNullOrWhiteSpace(special_holidayDB) ? 0.0 : Convert.ToDouble(special_holidayDB);
                    }
                    conn.Dispose();
                }
             
            }
            catch (Exception ex)
            {

                MessageBox.Show("error message"+ex);
            }


            return (undertime, absent, late, over_time, night_premium, restday_duty, legal_holiday, special_holiday);

        }

        private static (double deduction_sss_er, double deduction_sss_ee) GetDeductionSSS(double salary)
        {
            double deduction_sss_er = 0;
            double deduction_sss_ee = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT employer, employee from sss_tb WHERE @salary BETWEEN salary_from AND salary_to";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@salary", salary);

                    MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        deduction_sss_er = sdr.GetDouble("employer");
                        deduction_sss_ee = sdr.GetDouble("employee");
                    }
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Message"+ex);
            }
            return (deduction_sss_er, deduction_sss_ee);
        }
        private static double GetDeductionPhilhealth(double salary)
        {
            double deduction_philhealth = 0;
            double percent = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT percent from philhealth_tb WHERE @salary BETWEEN salary_from AND salary_to";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@salary", salary);

                    MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        percent = sdr.GetDouble("percent");
                    }
                    conn.Dispose();
                }

                deduction_philhealth = salary * percent;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Message"+ex);
            }
            return deduction_philhealth;
        }


        public static (double deduction_sss_er, double deduction_sss_ee, double deduction_philhealth, double deduction_pagibig) GetDeductionMandatory(double salary)
        {

            var (deduction_sss_er, deduction_sss_ee) = GetDeductionSSS(salary);
            double deduction_philhealth = GetDeductionPhilhealth(salary);
            double deduction_pagibig = 200;
            return (deduction_sss_er, deduction_sss_ee, deduction_philhealth, deduction_pagibig);
        }

    
        public static double ConvertToDouble(string textbox)
        {
            string new_text_box = textbox.Replace(",","");
            return Convert.ToDouble(new_text_box);
        }


    }
}
