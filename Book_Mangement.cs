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
using User_Login_Page;

namespace BookManagement
{
    public partial class Book_Mangement: Form
    {
        public Book_Mangement()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            AddBook addBookForm = new AddBook();
            addBookForm.ShowDialog(); // Opens as a modal pop-up

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dashboard
            Dashboard userDashboardForm = new Dashboard();
            userDashboardForm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book_Mangement bookManagementForm = new Book_Mangement();
            bookManagementForm.Show();

            this.Hide();
            // Book Management
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // User Management
            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Borrow Return
            BorrowOrReturn borrowReturnForm = new BorrowOrReturn();
            borrowReturnForm.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Overdue
            OverDueBooks overDueForm = new OverDueBooks();
            overDueForm.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // logout
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
