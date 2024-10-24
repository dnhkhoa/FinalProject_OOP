using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_OOP
{
    public partial class frmLogin : Form
    {
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        // Simple dictionary storing username and password
        private Dictionary<string, string> userData = new Dictionary<string, string>
        {
            { "admin", "123"},
            { "user1", "pass1"},
            { "user2", "pass2"}
        };
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // check username password
            if (userData.ContainsKey(username) && userData[username] == password)
            {
                MessageBox.Show("Login successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.",
               "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear the password field for security reasons
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
