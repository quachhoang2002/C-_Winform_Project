using Project_CakeStore.BUS;
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
    public partial class ReportForm : Form
    {
        String getName = "";
        String getId = "";
        private Report_BUS reportBUS = new Report_BUS();
        public ReportForm(String name, String id)
        {
            InitializeComponent();
            tabControl_Select();
            getName = name;
            getId = id;
            txtAccName.Text = name + "(" + id + ")";
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(getName, getId);
            mainForm.ShowDialog();
        }

        private void tabControl_Select()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txtTotalEmployee.Text = reportBUS.totalEmployee().ToString();
                //txtTotalCustomer.Text = reportBUS.totalCustomer().ToString();
                //txtTotalSupplier.Text = reportBUS.totalSupplier().ToString();
                //txtTotalProduct.Text = reportBUS.totalProduct().ToString();
            }
        }

    }
}




