using System;
using System.Collections.Generic;
using System.Linq;
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




    }
    
}
