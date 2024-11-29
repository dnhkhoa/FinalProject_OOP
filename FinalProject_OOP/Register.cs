using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_OOP
{
    public partial class Register : Form
    {
        SqlConnection connectionString = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            frmLogin mainForm = new frmLogin();
            mainForm.Show();
            this.Hide();
        }
     
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="" || txtUserName.Text == "" || txtPassWord.Text =="" || txtContact.Text == "")
            {
                MessageBox.Show("Please fill all Username and Password", "Error input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "";
            }
        }
        //public bool checkCon() 
        //{
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
