using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;
using Payroll_Management_System.Forms.Menu_Form;
using Payroll_Management_System.Forms.Menu_Form.Employees;

namespace Payroll_Management_System.Connections
{

    public static class GetData
    {
        public static string connString = frmLogin.connString;


        public static List<string> GetDepartments()
        {
            List<string> departments = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT DISTINCT department FROM departments";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string result = reader.GetString("department");
                    departments.Add(result);
                }
                conn.Dispose();


            }

            return departments;

        }


        public static List<string> GetSchedule()
        {
            List<string> shifts = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT DISTINCT shift_schedule FROM schedule";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string result = reader.GetString("shift_schedule");
                    shifts.Add(result);

                }
                conn.Dispose();


            }
            return shifts;

        }

        public static string GetEmployeeName(string last_name, string first_name, string middle_name)
        {
            string ini;
            if (string.IsNullOrWhiteSpace(middle_name))
            {
                ini = "";
            }
            else
            {
                ini = middle_name.Substring(0, 1) + ".";
            }

            return last_name + ", " + first_name + " "+ini;
        }


        public static (double basic_salary, double daily_rate, double hourly_rate, double minute_rate) GetSalary(int salary)
        {

            double basic_salary = (double)salary/2;
            double daily_rate = (double)salary/26;
            double hourly_rate = daily_rate/8;
            double minute_rate = hourly_rate/60;

            return (basic_salary, daily_rate, hourly_rate, minute_rate);
        }

        public static (double deduction_late, double deduction_absent) GetDeduction(int emp_id, double undertime, double absent, double late)
        {
            double daily_rate = 0;
            double minute_rate = 0;

            double deduction_late = 0;
            double deduction_absent = 0;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT daily_rate, minute_rate FROM employee_information where emp_id=@emp_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@emp_id", emp_id);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    daily_rate = reader.GetDouble("daily_rate");
                    minute_rate = reader.GetDouble("minute_rate");
                }

                //compute for tardiness and absent
                deduction_late = (undertime+late)*minute_rate;  //mins of late + mins. of undertime = total late
                deduction_absent = absent* daily_rate;

                conn.Dispose();

            }
            return (deduction_late, deduction_absent);
        }


        public static (double addition_overtime, double addition_nightpremium, double addition_restdayduty, double addition_legalholiday, double addition_specialholiday) GetAddition(int emp_id, double over_time, double night_premium, double restday_duty, double legal_holiday, double special_holiday)

        {

            double daily_rate = 0;
            double hourly_rate = 0;
            double minute_rate = 0;


            double addition_overtime = 0;
            double addition_nightpremium = 0;
            double addition_restdayduty = 0;
            double addition_legalholiday = 0;
            double addition_specialholiday = 0;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT daily_rate, hourly_rate, minute_rate FROM employee_information where emp_id=@emp_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@emp_id", emp_id);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    daily_rate = reader.GetDouble("daily_rate");
                    hourly_rate = reader.GetDouble("hourly_rate");
                    minute_rate = reader.GetDouble("minute_rate");
                }

                //compute for overtime

                addition_overtime = over_time*hourly_rate*1.25; 
                addition_nightpremium = night_premium*hourly_rate*0.10; 
                addition_restdayduty = restday_duty*daily_rate*1.30;
                addition_legalholiday = legal_holiday*daily_rate;
                addition_specialholiday = special_holiday*daily_rate*0.30;

                conn.Dispose();
            }
            return (addition_overtime, addition_nightpremium, addition_restdayduty, addition_legalholiday, addition_specialholiday);
        }
    }





    }
