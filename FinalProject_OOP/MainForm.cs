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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //private void bgroundExitMain_Click(object sender, EventArgs e)
        //{
        //}

        //private void bgroundBackMain_Click(object sender, EventArgs e)
        //{
        //}

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
    }
}
