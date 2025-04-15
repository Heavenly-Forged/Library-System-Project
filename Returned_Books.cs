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
    public partial class Returned_Books : Form
    {
        public Returned_Books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Histo LoginHistoForm = new Login_Histo();
            LoginHistoForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Borrowed_Books borrowedBooksForm = new Borrowed_Books();
            borrowedBooksForm.Show(); // Show the Borrowed_Books form
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Returned_Books returnedBooksForm = new Returned_Books();
            returnedBooksForm.Show();
            this.Hide();
        }
    }
}
