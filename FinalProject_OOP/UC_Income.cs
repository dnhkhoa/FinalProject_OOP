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
    public partial class UC_Income : UserControl
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public UC_Income()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            string query = "SELECT OrderID, OrderDate, TableName, TotalAmount, Status " +
                           "FROM Orders " +
                           "WHERE OrderDate BETWEEN @StartDate AND @EndDate AND Status = 'Paid'";

            string sumQuery = "SELECT SUM(TotalAmount) AS TotalIncome " +
                              "FROM Orders " +
                              "WHERE OrderDate BETWEEN @StartDate AND @EndDate AND Status = 'Paid'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Lấy dữ liệu đơn hàng
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                    DataTable ordersTable = new DataTable();
                    adapter.Fill(ordersTable);

                    // Hiển thị vào DataGridView
                    dataGridView1.DataSource = ordersTable;

                    // Tính tổng doanh thu
                    SqlCommand cmd = new SqlCommand(sumQuery, conn);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    object result = cmd.ExecuteScalar();
                    decimal totalIncome = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    MessageBox.Show($"Total Income: {totalIncome:C}", "Income Report");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }

        private void UC_Income_Load(object sender, EventArgs e)
        {

        }
    }
}
