using System;
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
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassWord.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
            txtConfirmPass.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
        }

        private void btnExitRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackWard_Click(object sender, EventArgs e)
        {
            MainForm adminForm = new MainForm(role);
            this.Hide();
            adminForm.Show();
        }
    }
}
