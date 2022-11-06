﻿using Project_CakeStore.BUS;
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
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
                label3.Text = "hello";
                tableImportReport.Rows.Clear();
                tableImportReport.ColumnCount =6 ;
                tableImportReport.Columns[0].Name = "Ma San Pham";
                tableImportReport.Columns[1].Name = "Ten San Pham";
                tableImportReport.Columns[2].Name = "Loai San Pham";
                tableImportReport.Columns[3].Name = "So Luong";
                tableImportReport.Columns[4].Name = "Tong Tien Gia";
                tableImportReport.Columns[5].Name = "Thoi Gian";         
                List<ReportImport_DTO> list = reportBUS.reportImport(dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"));
                string start_time = dtpStart.Value.ToString("yyyy-MM-dd");
                foreach (ReportImport_DTO item in list)
                {
                    tableImportReport.Rows.Add(item.CakeId, item.CakeName, item.CakeType, item.Quantity.ToString(), item.TotalPrice.ToString(), item.Date);
                }

            }
            else if (tabControl1.SelectedIndex == 3)
            {
                label4.Text = "test";
            }
        }
    }
}




