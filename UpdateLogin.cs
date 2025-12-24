using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Shop
{
    public partial class Login : Form
    {
        public Login()
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
            txtUserPassword.PasswordChar = '*';
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (txtUserPassword.PasswordChar == '*')
            {
                txtUserPassword.PasswordChar = '\0'; // Show password
            }
            else
            {
                txtUserPassword.PasswordChar = '*'; // Hide password
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserEmail.Text = "";      // Clear email textbox

            txtUserPassword.Text = "";      // Clear password textbox

            txtUserEmail.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtUserEmail.Text.Trim();
            string password = txtUserPassword.Text;

            // Email validation with regex
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Enter valid email like user@gmail.com");
                txtUserEmail.Focus();
                return;
            }
            // Password checks
            if (password.Length < 5)
            {
                MessageBox.Show("Password must be 5 or more characters");
                txtUserPassword.Focus();
                return;
            }
            // Check for special characters
            if (!(password.Contains("@") || password.Contains("#") ||
                  password.Contains("$") || password.Contains("&")))
            {
                MessageBox.Show("Password needs @, #, $, or &");
                txtUserPassword.Focus();
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
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(64, 64, 64);
            btnClear.ForeColor = Color.White;
        }
    }
}
