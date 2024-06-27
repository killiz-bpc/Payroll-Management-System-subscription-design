using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms.Menu_Form
{
    public partial class frmLoading : Form
    {
        public List<string> messages;
        public frmLoading()
        {
            InitializeComponent();
            timer1.Start();

            messages = new List<string>
            {
                "Please wait as we load your resources",
                "Initializing.."
            };
        }

        public int elapsed_secs;


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            frmHome frmHome = new frmHome();
            frmHome.Show();
          
            this.Close();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            elapsed_secs = 0;
            label1.Text = messages[0];
        }

        private void guna2ProgressIndicator1_Click(object sender, EventArgs e)
        {

        }
    }
}
