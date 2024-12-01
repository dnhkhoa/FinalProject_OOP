using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using DGVPrinterHelper;
using static FinalProject_OOP.OrderForm;

namespace FinalProject_OOP
{
    public partial class UC_PlaceOrder : UserControl
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";
        
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}
        private void DrawTable()
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
                        flowLayoutPanel1.Controls.Add(btn);
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
            cbxSize.Items.Add("Small");
            cbxSize.Items.Add("Medium");
            cbxSize.Items.Add("Large");
            DrawTable();
            LoadItem();
            LoadTable();
        }
        private void LoadItem()
        {
            nudQantity.ResetText();
            using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT name from dbo.DrinkCatagory";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            cbxItemName.Items.Add(new ComboBoxItem
                            {
                                Text = reader["name"].ToString(),
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading categories: " + ex.Message);
                    }
                }
            
        }
        private void LoadTable()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name from dbo.TableCoffee";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbxTable.Items.Add(new ComboBoxItem
                        {
                            Text = reader["name"].ToString(),
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message);
                }
            }
        }

        private void cbxItemName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudQantity_ValueChanged(object sender, EventArgs e)
        {
            float quan = float.Parse(nudQantity.Value.ToString());
            string text = cbxItemName.Text;
            string query = "select price from dbo.DrinkCatagory where name = '" + text + "'";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = cbxTable.Text;
            dataGridView1.Rows[n].Cells[1].Value = cbxItemName.Text;
            dataGridView1.Rows[n].Cells[2].Value = nudQantity.Text;
            dataGridView1.Rows[n].Cells[3].Value = cbxSize.Text;
            dataGridView1.Rows[n].Cells[4].Value = txtPrice.Text;
        }

        private void cbxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Clear();
            nudQantity.ResetText();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cbxTable.Text))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Cập nhật trạng thái bàn trong cơ sở dữ liệu
                        string query = "UPDATE TableCoffee SET status = 'Occupied' WHERE name = @tableName";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@tableName", cbxTable.Text);
                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Payment successful! Table marked as Occupied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating table status: " + ex.Message);
                    }
                }
            }

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Thank you for your visit!";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);

            // Xóa danh sách order
            dataGridView1.Rows.Clear();

            // Vẽ lại danh sách bàn
            flowLayoutPanel1.Controls.Clear();
            DrawTable();

        }
    }
}
