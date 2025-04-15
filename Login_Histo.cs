using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_Log_Records
{
    public partial class Login_Histo : Form
    {
        public Login_Histo()
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox4.Text, textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

       

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, '-', ':', and control keys (like backspace)
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != ':')
            {
                e.Handled = true; // Block the key if it's not allowed
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, '/', '-', ':', and control keys (like backspace)
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '/' &&
                e.KeyChar != '-' &&
                e.KeyChar != ':')
            {
                e.Handled = true; // Block the key if it's not allowed
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Borrowed_Books borrowedBooksForm = new Borrowed_Books();
            borrowedBooksForm.Show(); // Show the Borrowed_Books form
            this.Hide(); // Optional: Hide the current form if you don't want it visible
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Returned_Books returnedBooksForm = new Returned_Books();
            returnedBooksForm.Show();
            this.Hide();
        }

        
  
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
               !char.IsDigit(e.KeyChar) &&
               e.KeyChar != '-' &&
               e.KeyChar != ':')
            {
                e.Handled = true; // Block the key if it's not allowed
            }
        }

        private void Login_Histo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Histo LoginHistoForm = new Login_Histo();
            LoginHistoForm.Show();
            this.Hide();
        }
    }
}
