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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30");
        
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
        public void HideAdminFeatures()
        {
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
               // Kiểm tra nếu Username hoặc Password bị bỏ trống
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter both Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn kiểm tra tài khoản và lấy vai trò (Role)
                    string query = "SELECT AccountType FROM Account WHERE UserName = @userName AND PassWord = @password";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userName", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                    object roleObj = cmd.ExecuteScalar();

                    if (roleObj != null)
                    {
                        int role = Convert.ToInt32(roleObj); // Lấy vai trò từ cơ sở dữ liệu

                        // Điều hướng người dùng theo vai trò
                        switch (role)
                        {
                            case 1: // Admin
                                MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm adminForm = new MainForm(role);
                                this.Hide();
                                adminForm.Show();
                                break;

                            case 2: // Barista
                                MessageBox.Show("Welcome Barista!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm baristaForm = new MainForm(role);
                                this.Hide();
                                baristaForm.Show();
                                break;

                            case 3: // Customer
                                MessageBox.Show("Welcome Customer!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OrderForm customerForm = new OrderForm();
                                this.Hide();
                                customerForm.Show();
                                break;

                            default:
                                MessageBox.Show("Invalid role assigned. Please contact the admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        // Sai Username hoặc Password
                        MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        

 

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register mainForm = new Register();
            mainForm.Show();
            this.Hide();
        }

    }
}
