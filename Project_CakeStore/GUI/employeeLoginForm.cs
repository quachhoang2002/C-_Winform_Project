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
        String getID = "";
        public employeeLoginForm(String name,String id)
        {
            InitializeComponent();
            getName = name;
            getID = id;
            this.txtAccName.Text = name + "(" + id + ")";
        }

        private void txtSellForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            sellForm sellForm = new sellForm(getName, getID);
            sellForm.ShowDialog();
            this.Show();
        }

        private void txtImportPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            importProForm importForm = new importProForm(getName, getID);
            importForm.ShowDialog();
            this.Show();
        }

        private void txtCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerForm customerForm = new customerForm(getName, getID);
            customerForm.ShowDialog();
            this.Show();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(getName, getID);
            main.ShowDialog();
        }
    }
}
