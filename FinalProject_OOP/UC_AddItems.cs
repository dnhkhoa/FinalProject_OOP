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

namespace FinalProject_OOP
{
    public partial class UC_AddItems : UserControl
    {
        private UC_UpdateItems updateItems; // Tham chiếu tới UC_UpdateItems
        private UC_RemoveItems removeItems;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public UC_AddItems()
        {
            // Constructor mặc định nếu không cần tham số
        }
        public UC_AddItems(UC_UpdateItems updateItems)
        {
            InitializeComponent();
            this.updateItems = updateItems;
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddItems_Load(object sender, EventArgs e)
        {
            cbxCategory.Items.Add("Drinks");
            cbxCategory.Items.Add("Cakes"); 
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            int idDrink;
            string category= cbxCategory.SelectedItem.ToString();
            string name =txtItemName.Text;
            string priceText = txtPrice.Text;
            if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText))
            {
                MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (!decimal.TryParse(priceText, out decimal price) || price <= 0)
            {
                MessageBox.Show("Price must be a valid positive number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (category == "Drinks")
            {
                idDrink = 1;
            }
            else { idDrink = 2; }

            // Tìm giá trị lớn nhất của id hiện tại
            int newId = 1; // Bắt đầu từ 1 nếu bảng trống
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string queryMaxId = "SELECT ISNULL(MAX(id), 0) + 1 FROM DrinkCatagory";
                    SqlCommand cmdMaxId = new SqlCommand(queryMaxId, conn);
                    newId = (int)cmdMaxId.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching new ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }



            string query = "INSERT INTO DrinkCatagory (id,name, idDrink, price) VALUES (@id,@name, @idDrink, @price)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Thực hiện câu lệnh INSERT
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", newId);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@idDrink", idDrink);
                        cmd.Parameters.AddWithValue("@price", price);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Xóa các trường nhập liệu sau khi thêm thành công
                            txtItemName.Clear();
                            txtPrice.Clear();
                            cbxCategory.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add item. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
               

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            updateItems.RefreshData();
            removeItems.RefreshData();
        }
    }
}
