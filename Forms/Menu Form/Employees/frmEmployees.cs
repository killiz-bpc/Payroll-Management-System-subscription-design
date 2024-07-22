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
                query = "SELECT emp_id, employee_name, first_name, middle_name, last_name, gender, mobile_number, job_title, department, active_status FROM employee_information ";

                if (txtDepartment.Text != "All" && txtActiveStatus.Text != "All") //same naka filter
                {
                    query += " WHERE department=@department AND active_status=@active_status";
                }

                if (txtDepartment.Text == "All" && txtActiveStatus.Text != "All") //active status lang yung naka-filter
                {
                    query += " WHERE active_status=@active_status";
                }

                if (txtDepartment.Text != "All" && txtActiveStatus.Text == "All") //department lang yung nakafilter
                {
                    query += " WHERE department=@department";
                }


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@active_status", txtActiveStatus.Text);

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

            txtActiveStatus.Text = "All";

            load_data();

           

            List<string> departments = GetData.GetDepartments();

            foreach(string department in departments)
            {
                txtDepartment.Items.Add(department);
            }
        }

        private void txtDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            load_data();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query;
                conn.Open();
                query = "SELECT emp_id, employee_name, first_name, middle_name, last_name, gender, mobile_number, job_title, department, active_status FROM employee_information";


                if (txtDepartment.Text != "All" && txtActiveStatus.Text != "All") //same naka filter
                {
                    query += " WHERE department=@department AND active_status=@active_status";
                }

                if (txtDepartment.Text == "All" && txtActiveStatus.Text != "All") //active status lang yung naka-filter
                {
                    query += " WHERE active_status=@active_status";
                }

                if (txtDepartment.Text != "All" && txtActiveStatus.Text == "All") //department lang yung nakafilter
                {
                    query += " WHERE department=@department";
                }



                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@active_status", txtActiveStatus.Text);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                sda.Fill(dataTable);

                dgvEmployees.DataSource = dataTable;
                

                DataView dataView = dataTable.DefaultView;
                dataView.RowFilter = "employee_name LIKE '%" + txtSearch.Text + "%'";


                lblTotalEmployees.Text = dgvEmployees.Rows.Count.ToString();
                conn.Dispose();
            }
        }   

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmployees.Columns["view_more"].Index && e.RowIndex >= 0)
            {
                dgvEmployees.CurrentCell = dgvEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex];

                string employee_id = dgvEmployees.CurrentRow.Cells["emp_id"].Value.ToString();
                frmEditEmployee frmEditEmployee = new frmEditEmployee();
                frmEditEmployee.employee_id = employee_id;
                frmEditEmployee.ShowDialog();
            }  
        }

        private void txtActiveStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            load_data();
        }
    }
}
