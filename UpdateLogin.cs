using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.Cursor = Cursors.Hand;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0'; // Show password
            }
            else
            {
                textBox2.PasswordChar = '*'; // Hide password
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";      // Clear email textbox

            textBox2.Text = "";      // Clear password textbox

            textBox1.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            // Simple email check (contains @ and .)
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Enter valid email like user@gmail.com");
                textBox1.Focus();
                return;
            }
            // Password checks
            if (password.Length < 5)
            {
                MessageBox.Show("Password must be 5 or more characters");
                textBox2.Focus();
                return;
            }
            // Check for special characters
            if (!(password.Contains("@") || password.Contains("#") ||
                  password.Contains("$") || password.Contains("&")))
            {
                MessageBox.Show("Password needs @, #, $, or &");
                textBox2.Focus();
                return;
            }

            // If everything is OK
            MessageBox.Show("Login Successful!");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(128, 70, 27);
            button2.ForeColor = Color.White;
        }
    }
}
