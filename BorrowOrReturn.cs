using BookManagement;
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

namespace BorrowOrReturnSolution
{
    public partial class BorrowOrReturn : Form
    {
        string placeholderText = "Search here...";

        public BorrowOrReturn()
        {
            InitializeComponent();

            // Sample data -->
            dgvBorrowOrReturn.Rows.Add("TXN001", "Maria Santos", "The Lord of the Rings", "September 18, 2024", "September 25, 2024", null, "Borrowed");
            dgvBorrowOrReturn.Rows.Add("TXN002", "Juan Dela Cruz", "Frieren: Beyond Journey's End", "October 10, 2024", "October 17, 2024", "October 15, 2024", "Returned");
            dgvBorrowOrReturn.Rows.Add("TXN003", "Steve", "Dante's Inferno", "November 2, 2024", "November 9, 2024", null, "Borrowed");
            dgvBorrowOrReturn.Rows.Add("TXN004", "Craig", "Harry Potter vol. 1", "November 21, 2024", "November 28, 2024", null, "Overdue");
            dgvBorrowOrReturn.RowsDefaultCellStyle.BackColor = Color.White;

            // Effects -->
            dgvBorrowOrReturn.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvBorrowOrReturn.CellMouseEnter += DgvUsers_CellMouseEnter;
            dgvBorrowOrReturn.CellMouseLeave += DgvUsers_CellMouseLeave;

            txtSearch.Text = placeholderText;
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Enter += TxtSearch_Enter;
            txtSearch.Leave += TxtSearch_Leave;

            ApplyHoverToButtons(this);
        }

        private void DgvUsers_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvBorrowOrReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightYellow;
            }
        }

        private void DgvUsers_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Color baseColor = (e.RowIndex % 2 == 0)
                    ? dgvBorrowOrReturn.RowsDefaultCellStyle.BackColor
                    : dgvBorrowOrReturn.AlternatingRowsDefaultCellStyle.BackColor;

                dgvBorrowOrReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = baseColor;
            }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholderText)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholderText;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void ApplyHoverToButtons(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;

                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.UseVisualStyleBackColor = false;
                }
                else if (ctrl.HasChildren)
                {
                    ApplyHoverToButtons(ctrl);
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackColor = Color.LightGray;
            btn.ForeColor = Color.White;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackColor = SystemColors.Control;
            btn.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard userDashboardForm = new Dashboard();
            userDashboardForm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book_Mangement bookManagementForm = new Book_Mangement();
            bookManagementForm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BorrowOrReturn borrowReturnForm = new BorrowOrReturn();
            borrowReturnForm.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OverDueBooks overDueForm = new OverDueBooks();
            overDueForm.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void logOutbtn_Click(object sender, EventArgs e)
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
