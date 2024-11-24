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
        SqlConnection con = new SqlConnection(@"Data Source=KHANG;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
        private void UpdatePrice()
        {
            // Lấy kích thước đã chọn
            string size = cbxSize.SelectedItem.ToString();

            // tìm thức uống đã chọn từ danh sách
            //var selectedcoffee = menu.find(coffee => coffee.coffeename == txtitemname.text);

            //// nếu tìm thấy thức uống, tính giá theo kích thước
            //if (selectedcoffee != null)
            //{
            //    double price = selectedcoffee.pricebysize(size);
            //    txtprice.text = price.tostring("c"); // hiển thị dưới dạng tiền tệ
            //}
        }
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            cbxCategory.Items.Add("Drinks");
            cbxCategory.Items.Add("Cake");
            cbxSize.Items.Add("Small");
            cbxSize.Items.Add("Medium");
            cbxSize.Items.Add("Large");
        }

        private void cbxCategory_SelectedInxdexChanged(object sender, EventArgs e)
        {
           string category= cbxCategory.Text;

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
