using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_OOP;
using static System.Net.Mime.MediaTypeNames;

namespace FinalProject_OOP
{
    public partial class OrderForm : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";
        string query;
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
       
        

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
            nudQantity.ResetText();
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudQantity.ResetText();
            
            txtPrice.Clear();
            string text = lstOrder.GetItemText(lstOrder.SelectedItem);
            txtItemName.Text = text;
            
        }
        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin mainForm = new frmLogin();
            mainForm.Show();
            this.Hide();
        }

        private void btnExitOrder_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            string catagory = cbxCategory.Text;
            if (catagory == "Cakes")
            {
                i = 2;
            }
            else { i = 1; }
            query = "select name from dbo.DrinkCatagory where idDrink ='" + i + "'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idDrink", i);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa danh sách cũ trong ListBox trước khi thêm mới
                    lstOrder.Items.Clear();

                    // Thêm kết quả từ cơ sở dữ liệu vào ListBox
                    while (reader.Read())
                    {
                        lstOrder.Items.Add(reader["name"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int i;
            string catagory = cbxCategory.Text;
            if (catagory == "Cakes")
            {
                i = 2;
            }
            else { i = 1; }
            query = "select name from dbo.DrinkCatagory where idDrink ='" + i + "' and name like '" +txtSearch.Text+"%' "  ;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idDrink", i);
                    cmd.Parameters.AddWithValue("@searchText", txtSearch.Text + "%");

                    SqlDataReader reader = cmd.ExecuteReader();

                    lstOrder.Items.Clear();

                    while (reader.Read())
                    {
                        lstOrder.Items.Add(reader["name"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching food items: " + ex.Message);
                }
            }
        }

        private void nudQantity_ValueChanged(object sender, EventArgs e)
        {
            txtPrice.Clear();
            if (string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(cbxSize.Text))
            {
                MessageBox.Show("Please select an item and size first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                return;
            }

            float quan = float.Parse(nudQantity.Value.ToString());
            string text = txtItemName.Text;
            query = "select price from dbo.DrinkCatagory where name = '" + text + "'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", text);

                // Thực hiện truy vấn
                object result = cmd.ExecuteScalar();
                // Chuyển giá từ cơ sở dữ liệu thành float
                float price = Convert.ToSingle(result);
                string size = cbxSize.Text;
                float total = quan * price;
                if (size == "Small")
                {
                    total *= 0.8f;
                }
                else
                {
                    if (size == "Medium")
                    {
                        total *= 1.0f;
                    }
                    else
                    {
                        total *= 1.2f;
                    }
                }
                txtPrice.Clear();
                txtPrice.Text = total.ToString();
            }
            
            
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
         
            int n = dataCart.Rows.Add();
            dataCart.Rows[n].Cells[0].Value = txtItemName.Text;
            dataCart.Rows[n].Cells[1].Value = nudQantity.Value;
            dataCart.Rows[n].Cells[2].Value = cbxSize.Text;
            dataCart.Rows[n].Cells[3].Value = txtPrice.Text;
        }
    }
}
