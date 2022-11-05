using Project_CakeStore.BUS;
using Project_CakeStore.DTO;
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
                txtTotalCustomer.Text = reportBUS.totalCustomer().ToString();
                txtTotalCake.Text = reportBUS.totalCake().ToString();
                txtTotalOrder.Text = reportBUS.totalOrder().ToString();
                txtTotalManufactor.Text = reportBUS.totalManufactor().ToString();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                tableImportReport.Rows.Clear();
                tableImportReport.Columns[0].Name = "Ma San Pham";
                tableImportReport.Columns[1].Name = "Ten San Pham";
                tableImportReport.Columns[2].Name = "So Luong";
                tableImportReport.Columns[3].Name = "Tong Tien Gia";
                List<ReportImport_DTO> list = reportBUS.listImportReport();


            }
        }
    }
}




