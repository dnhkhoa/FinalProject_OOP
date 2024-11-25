using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_OOP;

namespace FinalProject_OOP
{
    public partial class OrderForm : Form
    {
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void LoadFoodItems(int categoryId)
        {
            lstOrder.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name, price FROM FoodCatagory WHERE idDrink = @CategoryId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string item = $"{reader["name"]} - ${reader["price"]}";
                        lstOrder.Items.Add(item);
                        MessageBox.Show(item); // Hiển thị từng item được thêm
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading food items: " + ex.Message);
                }
            }
        }
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30";

        private void UpdatePrice()
        {
          
        }
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            cbxSize.Items.Add("Small");
            cbxSize.Items.Add("Medium");
            cbxSize.Items.Add("Large");
            LoadCatagory();
        }
        private void LoadCatagory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, name FROM Catagory";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbxCategory.Items.Add(new ComboBoxItem
                        {
                            Text = reader["name"].ToString(),
                            Value = reader["id"]
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message);
                }
            }
        }
        private void cbxCategory_SelectedInxdexChanged(object sender, EventArgs e)
        {
            if (cbxCategory.SelectedItem is ComboBoxItem selectedCategory)
            {
                LoadFoodItems(Convert.ToInt32(selectedCategory.Value));
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudQuantity_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void bgroundExitOrder_Click(object sender, EventArgs e)
        //{
        //}

        private void cbxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tính lại giá khi thay đổi kích thước
            UpdatePrice();
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //private void bgroundBackOrder_Click(object sender, EventArgs e)
        //{ 
        //}

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin mainForm = new frmLogin();
            mainForm.Show();
            this.Hide();
        }

        private void btnExitOrder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
