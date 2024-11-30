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
            if (txtName.Text == "" || txtUserName.Text == "" || txtPassWord.Text == "" || txtContact.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo kết nối SQL
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra Username đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM Account WHERE UserName = @userName";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Lấy ID mới lớn nhất (tự động tăng)
                    string getIdQuery = "SELECT ISNULL(MAX(id), 0) + 1 FROM Account";
                    SqlCommand getIdCmd = new SqlCommand(getIdQuery, connection);
                    int newId = (int)getIdCmd.ExecuteScalar();

                    // Thêm tài khoản mới
                    string insertQuery = "INSERT INTO Account (id, DisplayName, UserName, PassWord, AccountType, PhoneNumber) " +
                                         "VALUES (@id, @displayName, @userName, @password, @accountType, @phoneNumber)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@id", newId);
                    insertCmd.Parameters.AddWithValue("@displayName", txtName.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@password", txtPassWord.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@accountType", 0); // Default AccountType
                    insertCmd.Parameters.AddWithValue("@phoneNumber", txtContact.Text.Trim());

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtUserName.Clear();
                        txtPassWord.Clear();
                        txtConfirmPass.Clear();
                        txtContact.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
  

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
