using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
    }
}
