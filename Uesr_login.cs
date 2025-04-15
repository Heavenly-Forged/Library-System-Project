using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using user_Log_Records;

namespace User_Login_Page
{
    public partial class User_login : Form
    {
        public User_login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Optional: Validate login here first

            // Open Dashboard form
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();

            // Hide the login form (optional)
            this.Hide();
        }

        private void Uesr_login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_Histo histoForm = new Login_Histo();
            histoForm.Show();

            // Hide the login form (optional)
            this.Hide();
        }
    }
}
