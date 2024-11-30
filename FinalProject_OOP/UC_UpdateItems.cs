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
   
    public partial class UC_UpdateItems : UserControl
    {
        private UC_RemoveItems removeItems;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30";
        public UC_UpdateItems()
        {
            InitializeComponent();
        }
        public void RefreshData()
        {
            
            string query = "SELECT * FROM dbo.DrinkCatagory";
            loadData(query);
        }
        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            string query = "select * from dbo.DrinkCatagory";
            loadData(query);
        }
        private void loadData(string q)
        {
            string query = q;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Truy vấn lấy dữ liệu từ cơ sở dữ liệu
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Thêm cột "Type" để hiển thị "Drinks" hoặc "Cakes" thay vì idDrink
                    dataTable.Columns.Add("Type", typeof(string));

                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Ánh xạ giá trị cột idDrink
                        if (row["idDrink"].ToString() == "1")
                        {
                            row["Type"] = "Drinks"; // Thay 1 thành Drinks
                        }
                        else if (row["idDrink"].ToString() == "2")
                        {
                            row["Type"] = "Cakes"; // Thay 2 thành Cakes
                        }
                    }

                    // Đổi tên cột "id" thành "No."
                    dataTable.Columns["id"].ColumnName = "No.";

                    // Gán DataTable vào DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Ẩn cột idDrink
                    if (dataGridView1.Columns.Contains("idDrink"))
                    {
                        dataGridView1.Columns["idDrink"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from dbo.DrinkCatagory where name like '" + txtSearch.Text + "%' ";
            loadData(query);
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string type;
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string catagory= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (catagory == "1")
            {
                type = "Drinks";
            }
            else
            {
                type = "Cakes";
            }
            string name = dataGridView1.Rows[e.RowIndex ].Cells[1].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtCategory.Text = type;
            txtItemName.Text = name;
            txtPrice.Text = price.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Map category text (Drinks/Cakes) to its corresponding numeric value
                int category;
                if (txtCategory.Text == "Drinks")
                {
                    category = 1; 
                }
                else if (txtCategory.Text == "Cakes")
                {
                    category = 2; 
                }
                else
                {
                    MessageBox.Show("Invalid category. Please enter 'Drinks' or 'Cakes'.");
                    return;
                }

                // SQL query with parameters to update the database
                string query = "UPDATE dbo.DrinkCatagory SET name = @name, idDrink = @idDrink, price = @price WHERE id = @id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection and handle data safely
                        cmd.Parameters.AddWithValue("@name", txtItemName.Text);
                        cmd.Parameters.AddWithValue("@idDrink", category);
                        cmd.Parameters.AddWithValue("@price", int.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@id", id);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the record. Please check the input.");
                        }
                    }
                }

                
                loadData("SELECT * FROM dbo.DrinkCatagory");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            removeItems.RefreshData();
        }
    }
}
