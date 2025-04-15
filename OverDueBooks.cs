using BookManagement;
using BorrowOrReturnSolution;
using LibraryUserManagementFE;
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

namespace OverdueBooksFE
{
    public partial class OverDueBooks : Form
    {
        string placeholderText = "Search here...";

        public OverDueBooks()
        {
            InitializeComponent();

            // Sample Data -->
            dgvUsers.Rows.Add("Clean Code", "STU-1032 / Alice Ramos", "2025-03-10", "2025-03-24", "19", "QCUL Main", "Overdue");
            dgvUsers.Rows.Add("Atomic Habits", "STU-1009 / Carla Reyes", "2025-03-20", "2025-04-03", "9", "QCUL North", "Overdue");
            dgvUsers.Rows.Add("Design Patterns", "STU-1065 / David Chan", "2025-02-25", "2025-03-10", "33", "QCUL Main", "Returned Late");
            dgvUsers.Rows.Add("Python Crash Course", "STU-1010 / Felix Ong", "2025-03-05", "2025-03-19", "25", "QCUL South", "Overdue");
            dgvUsers.Rows.Add("The Pragmatic Programmer", "STU-1041 / Ben Cruz", "2025-03-01", "2025-03-15", "28", "QCUL South", "Lost");

            // Effects -->
            dgvUsers.RowsDefaultCellStyle.BackColor = Color.White;
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

        private void Form1_Load(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

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

        private void button5_Click(object sender, EventArgs e)
        {
            OverDueBooks overDueForm = new OverDueBooks();
            overDueForm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();

            this.Hide();
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

        private void button4_Click(object sender, EventArgs e)
        {
            BorrowOrReturn borrowReturnForm = new BorrowOrReturn();
            borrowReturnForm.Show();

            this.Hide();
        }
    }
}
