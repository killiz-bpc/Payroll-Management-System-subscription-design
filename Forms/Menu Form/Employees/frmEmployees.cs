using Payroll_Management_System.Forms.Menu_Form.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Payroll_Management_System.Connections;

namespace Payroll_Management_System.Forms.Menu_Form
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee frmAddEmployee = new frmAddEmployee();
            frmAddEmployee.ShowDialog();

        }

        public string connString = frmLogin.connString;
        public void load_data()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query;
                conn.Open();
                query = "SELECT emp_id, first_name, middle_name, last_name, gender, mobile_number, job_title, department FROM employee_information ";

                if (txtDepartment.Text != "All")
                {
                    query += "WHERE department=@department";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                sda.Fill(dataTable);

                dgvEmployees.DataSource = dataTable;
                dgvEmployees.Refresh();

                lblTotalEmployees.Text = dgvEmployees.Rows.Count.ToString();

                conn.Dispose();
            }
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            txtDepartment.Text = "All";

            load_data();

           

            List<string> departments = GetData.GetDepartments();

            foreach(string department in departments)
            {
                txtDepartment.Items.Add(department);
            }
        }

        private void txtDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query;
                conn.Open();
                query = "SELECT emp_id, first_name, middle_name, last_name, gender, mobile_number, job_title, department FROM employee_information ";


                MySqlCommand cmd = new MySqlCommand(query, conn);
              

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                sda.Fill(dataTable);

                dgvEmployees.DataSource = dataTable;
                

                DataView dataView = dataTable.DefaultView;
                dataView.RowFilter = "first_name LIKE '%" + txtSearch.Text + "%'";


                lblTotalEmployees.Text = dgvEmployees.Rows.Count.ToString();
                conn.Dispose();
            }
        }
    }
}
