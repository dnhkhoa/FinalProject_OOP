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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cbbPayment == null || cbbPrintBill == null)
            {
                MessageBox.Show("Please choose all the items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbbPayment != null || cbbPrintBill !=null) 
            {
                MessageBox.Show("Thank you for using our cafe's services", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFeedback.Clear();
                cbbPayment.Items.Clear();
                cbbPrintBill.Items.Clear();

                OrderForm mainForm = new OrderForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
