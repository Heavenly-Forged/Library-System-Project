using BookManagement;
using BorrowOrReturnSolution;
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

namespace LibraryUserManagementFE
{
    public partial class UserManagement : Form
    {
        string placeholderText = "Search here...";

        public UserManagement()
        {
            InitializeComponent();

            // Sample data -->
            dgvUsers.Rows.Add("U001", "Maria Santos", "Student", "San Bartolome", "maria@example.com", "Active");
            dgvUsers.Rows.Add("U002", "Juan Dela Cruz", "Faculty", "Main", "juan@example.com", "Inactive");
            dgvUsers.RowsDefaultCellStyle.BackColor = Color.White;

            // Effects -->
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvUsers.CellMouseEnter += DgvUsers_CellMouseEnter;
            dgvUsers.CellMouseLeave += DgvUsers_CellMouseLeave;

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
                dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightYellow;
            }
        }

        private void DgvUsers_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Color baseColor = (e.RowIndex % 2 == 0)
                    ? dgvUsers.RowsDefaultCellStyle.BackColor
                    : dgvUsers.AlternatingRowsDefaultCellStyle.BackColor;

                dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = baseColor;
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

        // <-- Effects
        private void label2_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

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

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard userDashboardForm = new Dashboard();
            userDashboardForm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OverDueBooks overDueForm = new OverDueBooks();
            overDueForm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book_Mangement bookManagementForm = new Book_Mangement();
            bookManagementForm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BorrowOrReturn borrowReturnForm = new BorrowOrReturn();
            borrowReturnForm.Show();

            this.Hide();
        }
    }
}
