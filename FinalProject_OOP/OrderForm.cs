using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            lstOrder.Items.Clear();

            string category = cbxCategory.Text;

            if (category == "Drinks")
            {
                if (MenuShop.Coffees != null && MenuShop.Coffees.Count > 0)
                {
                    foreach (var coffee in MenuShop.Coffees)
                    {
                        lstOrder.Items.Add(coffee.CoffeeName);
                    }
                }
                else
                {
                    MessageBox.Show("No coffee items found.");
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudQuantity_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bgroundExitOrder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tính lại giá khi thay đổi kích thước
            UpdatePrice();
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void bgroundBackOrder_Click(object sender, EventArgs e)
        {
            frmLogin mainForm = new frmLogin();
            mainForm.Show();
            this.Hide();
        }
    }
}
