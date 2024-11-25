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
    public partial class UC_PlaceOrder : UserControl
    {   
        
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}
        private void LoadTable()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30";
            string query = "SELECT id, name, status FROM TableCoffee WHERE id IS NOT NULL";

  
            try
            {
                // Kết nối SQL Server và lấy dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable tablecoffee = new DataTable();
                    adapter.Fill(tablecoffee);

                    // Tạo Button cho mỗi bàn
                    foreach (DataRow row in tablecoffee.Rows)
                    {
                        string tableName = row["name"].ToString();
                        string tableStatus = row["status"].ToString();

                        // Tạo nút
                        Button btn = new Button();
                        btn.Text = tableName;
                        btn.Width = 100;
                        btn.Height = 50;
                        btn.BackColor = tableStatus == "Empty" ? Color.Green : Color.Red; // Xanh nếu trống, đỏ nếu có khách
                        btn.Tag = tableStatus; // Lưu trạng thái vào Tag để dễ dàng truy cập

                        // Sự kiện Click
                        btn.Click += (s, e) =>
                        {
                            string status = btn.Tag.ToString();
                            MessageBox.Show($"{tableName} hiện đang {status}");
                        };

                        // Thêm nút vào FlowLayoutPanel
                        panel1.Controls.Add(btn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kết nối cơ sở dữ liệu: {ex.Message}");
            }
        }
        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
    }
}
