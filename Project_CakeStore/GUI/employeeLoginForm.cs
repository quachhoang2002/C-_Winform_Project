﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CakeStore.GUI
{
    public partial class employeeLoginForm : Form
    {
        String getName = "";
        String getid = "";
        public employeeLoginForm(String name,String id)
        {
            InitializeComponent();
            getName = name;
            getid = id;
            this.txtAccName.Text = name + "(" + id + ")";
        }

        private void txtCategory_Click(object sender, EventArgs e)
        {

        }

        private void txtSellForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            sellForm sellForm = new sellForm(getName, getid);
            sellForm.ShowDialog();
            this.Show();
        }

        private void txtImportPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            importProForm importForm = new importProForm(getName, getid);
            importForm.ShowDialog();
            this.Show();
        }

        private void txtCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerForm customerForm = new customerForm(getName, getid);
            customerForm.ShowDialog();
            this.Show();
        }

        private void txtCake_Click(object sender, EventArgs e)
        {

        }
    }
}
