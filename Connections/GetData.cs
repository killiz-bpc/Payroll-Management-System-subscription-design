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
using Org.BouncyCastle.Crypto.Utilities;
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
                while(reader.Read())
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
            if (middle_name  == null)
            {
                middle_name = "";
            }

            return last_name + "," + first_name + " "+middle_name;
        }
       

        public static (double basic_salary, double daily_rate, double hourly_rate, double minute_rate) GetSalary(int salary)
        {

            double basic_salary = salary/2;
            double daily_rate = salary/26;
            double hourly_rate = daily_rate/8;
            double minute_rate = hourly_rate/60;

            return (basic_salary, daily_rate, hourly_rate, minute_rate);
        }
    }
    
}
