using System;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject_OOP
{
    public class Table
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Status { get; private set; }
        public float TotalAmount { get; set; }

        private string connectionString;

        public Table(int id, string name, string status, string connectionString)
        {
            Id = id;
            Name = name;
            Status = status;
            this.connectionString = connectionString;
        }

        // Cập nhật trạng thái của bàn
        public void UpdateStatus(string newStatus)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE TableCoffee SET status = @Status WHERE id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }

            Status = newStatus;
        }

        // Lấy danh sách bàn từ cơ sở dữ liệu
        public static DataTable GetTables(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, name, status FROM TableCoffee";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tableData = new DataTable();
                adapter.Fill(tableData);
                return tableData;
            }
        }
    }
}