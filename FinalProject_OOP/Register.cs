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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=True");
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
                if (checkCon())
                {
                    try
                    {
                        con.Open();
                        string checkUsername = "SELECT *FROM Account WHERE UserName= @UserName";
                        using (SqlCommand cmd = new SqlCommand(checkUsername, con)) 
                        { 
                            cmd.Parameters.AddWithValue("@UserName",txtUserName.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtUserName.Text.Trim()+ "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else 
                            {
                                string insertData = "INSERT INTO Account (DisplayName,UserName,PassWord,AccountType,PhoneNumber)" + "VALUE (@DisplayName,@UserName,@PassWord,@AccountType,@PhoneNumber)";
                                using (SqlCommand insertD = new SqlCommand(insertData, con))
                                {
                                    insertD.Parameters.AddWithValue("@DisplayName", txtName.Text.Trim());
                                    insertD.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                                    insertD.Parameters.AddWithValue("@PassWord", txtPassWord.Text.Trim());
                                    insertD.Parameters.AddWithValue("@AccountType", 3);
                                    insertD.Parameters.AddWithValue("@PhoneNumber", txtContact.Text.Trim());
                                    insertD.ExecuteNonQuery();
                                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    frmLogin mainForm = new frmLogin();
                                    mainForm.Show();
                                    this.Hide();
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    { 
                    con.Close();
                    }
                }
            }
        }
        public bool checkCon() 
        {
            if (con.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
