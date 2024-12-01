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
        private UC_UpdateItems updateItems; // Tham chiếu tới UC_UpdateItems
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
        public void RefreshData()
        {

            string query = "SELECT * FROM dbo.DrinkCatagory";
            loadData(query);
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
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Delete item?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                    string deleteQuery = "DELETE FROM DrinkCatagory WHERE id = @id";
                    string resequenceQuery = @"
                WITH CTE AS (
                    SELECT id, ROW_NUMBER() OVER (ORDER BY id) AS NewID
                    FROM DrinkCatagory
                )
                UPDATE DrinkCatagory
                SET id = CTE.NewID
                FROM DrinkCatagory
                INNER JOIN CTE ON DrinkCatagory.id = CTE.id;";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();

                            // Xóa mục
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }

                            // Tái đánh số ID
                            using (SqlCommand cmd = new SqlCommand(resequenceQuery, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            // Tải lại dữ liệu
                            string loadQuery = "SELECT * FROM dbo.DrinkCatagory";
                            loadData(loadQuery);

                            MessageBox.Show("Item deleted and IDs updated successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting item: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
