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

        private void txtSellForm_Click(object sender, EventArgs e)
        {
            sellForm sellForm = new sellForm(getName, getid);
            sellForm.ShowDialog();
        }

        private void txtImportPro_Click(object sender, EventArgs e)
        {
            importProForm importForm = new importProForm(getName, getid);
            importForm.ShowDialog();
        }

        private void txtCus_Click(object sender, EventArgs e)
        {
            customerForm customerForm = new customerForm(getName, getid);
            customerForm.ShowDialog();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Bạn có thật sự muốn thoát ? ",
                             "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
        }

        private void txtCategory_Click(object sender, EventArgs e)
        {
            categoryForm category = new categoryForm(getName, getid);
            category.ShowDialog();
        }

        private void txtCake_Click(object sender, EventArgs e)
        {
            cakeForm cake = new cakeForm(getName, getid);
            cake.ShowDialog();
        }


    }
}
