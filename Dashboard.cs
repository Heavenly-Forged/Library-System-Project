using BookManagement;
using BorrowOrReturnSolution;
using LibraryUserManagementFE;
using OverdueBooksFE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Login_Page
{
    public partial class Dashboard: Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();

            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OverDueBooks overDueForm = new OverDueBooks();
            overDueForm.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dashboard userDashboardForm = new Dashboard();
            userDashboardForm.Show();

            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Book_Mangement bookManagementForm = new Book_Mangement();
            bookManagementForm.Show();

            this.Hide();
            //Book Management Dashboard
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();

            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OverDueBooks overDueForm = new OverDueBooks();
            overDueForm.Show();

            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Borrow Return Dashboard page
            BorrowOrReturn borrowReturnForm = new BorrowOrReturn();
            borrowReturnForm.Show();

            this.Hide();

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Book_Mangement bookManagementForm = new Book_Mangement();
            bookManagementForm.Show();

            this.Hide();
            //Book management Panel DB
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();

            this.Hide();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            OverDueBooks overDueForm = new OverDueBooks();
            overDueForm.Show();

            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Example logout logic --> | Lalagyan nalang ng tunay na logIn/out logics
                    this.Close();
                }
            
        }
    }
}
