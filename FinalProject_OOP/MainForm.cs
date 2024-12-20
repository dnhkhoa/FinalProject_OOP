﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_OOP
{   
    
    public partial class MainForm : Form
    {
        private UC_UpdateItems ucUpdateItems;
        private UC_AddItems ucAddItems;
        private int UserRole; // Lưu trữ role của người dùng

      
        // Các UserControl phải được thêm vào đây
        

    
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\Coffee Management System.mdf\";Integrated Security=True;Connect Timeout=30";
        public MainForm(int role)
        {
            InitializeComponent();

            // Gán giá trị role cho biến toàn cục UserRole
            UserRole = role;


            // Thiết lập hiển thị dựa trên role
            if (UserRole == 1) // Admin
            {
                btnAddItems.Show();
                btnRemoveItems.Show();
                btnUpdateItems.Show();
                btnIncome.Show();
                btnPlaceOrder.Show();
            }
            else if (UserRole == 2) // Barista
            {
                btnAddItems.Hide();
                btnRemoveItems.Hide();
                btnUpdateItems.Hide();
                btnIncome.Hide();
                btnPlaceOrder.Show();
            }

        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Khởi tạo UC_UpdateItems trước
            ucUpdateItems = new UC_UpdateItems();

            // Truyền tham chiếu UC_UpdateItems vào UC_AddItems
            ucAddItems = new UC_AddItems(ucUpdateItems);
            uC_AddItems1.Hide();
            uC_UpdateItems1.Hide();
            uC_RemoveItems1.Hide();
            uC_Income1.Hide();
        }

     

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin mainForm = new frmLogin();
            mainForm.Show();
            this.Hide();
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            uC_RemoveItems1.Visible = true;
            uC_RemoveItems1.BringToFront();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            uC_Income1.Visible = true;
            uC_Income1.BringToFront();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void uC_PlaceOrder1_Load(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            AdminRegister mainForm = new AdminRegister();
            mainForm.Show();
            this.Hide();
        }
    }
}
