using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject_OOP
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");
        
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        //Simple dictionary storing username and password
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
        //SqlConnection Con = new SqlConnection(@"Data Source=KHANG;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Plase fill all Username and Password", "Error input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataDataContext db = new DataDataContext(con);

            string tUsername = txtUsername.Text;
            string tPassword = txtPassword.Text;

            var user = db.Accounts.FirstOrDefault(u => u.UserName == tUsername && u.PassWord == tPassword);

            if (user != null )
            {
                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else if (user != null )
            {
                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //string username = txtUsername.Text;
            //string password = txtPassword.Text;

            //// check username password
            //if (userData.ContainsKey(username) && userData[username] == password)
            //{
            //    MessageBox.Show("Login successful!", "Success",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    MainForm mainForm = new MainForm();
            //    mainForm.Show();
            //    this.Hide();
            //} e
            //else
            //{
            //    MessageBox.Show("Invalid username or password. Please try again.",
            //   "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    // Clear the password field for security reasons
            //    txtPassword.Clear();
            //    txtPassword.Focus();
            //}
        }

        private void lbOrder_Click(object sender, EventArgs e)
        {
            OrderForm mainForm = new OrderForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
