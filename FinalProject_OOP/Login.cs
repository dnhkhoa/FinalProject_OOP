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
        SqlConnection con = new SqlConnection(@"Data Source=KHANG;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=True");
        
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
       
        public frmLogin()
        {
            InitializeComponent();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all Username and Password", "Error input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            else
            {
                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
        }
    }
}
