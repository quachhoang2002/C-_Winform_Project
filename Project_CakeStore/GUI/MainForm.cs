using System;
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
    public partial class MainForm : Form
    {
        String getName = "";
        String getid = "";
        public MainForm(String name, String id)
        {
            InitializeComponent();
            getName = name;
            getid = id;
            this.txtAccName.Text = name + "(" + id + ")";
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSellForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            sellForm sellForm = new sellForm(getName, getid);
            sellForm.ShowDialog();
        }

        private void txtImportPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            importProForm importForm = new importProForm(getName, getid);
            importForm.ShowDialog();
        }

        private void txtOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderForm orderForm = new orderForm(getName, getid);
            orderForm.ShowDialog();
        }

        private void txtImport_Click(object sender, EventArgs e)
        {
            this.Hide();
            importForm importForm = new importForm(getName, getid);
            importForm.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void txtEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeForm employeeForm = new employeeForm(getName, getid);
            employeeForm.ShowDialog();
        }

        private void txtCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerForm customerForm = new customerForm(getName, getid);
            customerForm.ShowDialog();
        }

        private void txtAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            accountForm accountForm = new accountForm(getName, getid);
            accountForm.ShowDialog();
            this.Show();
        }

        private void txtStatic_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm reportForm = new ReportForm(getName, getid);
            reportForm.ShowDialog();
        }

        private void txtCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            categoryForm category = new categoryForm(getName, getid);
            category.ShowDialog();
        }

        private void txtCake_Click(object sender, EventArgs e)
        {
            this.Hide();
            cakeForm cake = new cakeForm(getName, getid);
            cake.ShowDialog();
        }

        private void txtSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplierForm supplierForm = new supplierForm(getName, getid);
            supplierForm.ShowDialog();
        }
    }
}
