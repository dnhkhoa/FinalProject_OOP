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
    public partial class UC_RemoveItems : UserControl
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30";
        public UC_RemoveItems()
        {
            InitializeComponent();
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
        private void UC_RemoveItems_Load(object sender, EventArgs e)
        {
            string query = "select * from dbo.DrinkCatagory";
            loadData(query);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from dbo.DrinkCatagory where name like '" + txtItemName.Text + "%' ";
            loadData(query);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
