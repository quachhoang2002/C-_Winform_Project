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
            setDefauldValue();
            setCbxSearch();
            setCbxSellSearch();
            getName = name;
            getId = id;
            txtAccName.Text = name + "(" + id + ")";
        }


        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(getName, getId);
            mainForm.ShowDialog();
        }

        private void setDefauldValue()
        {
            dtpEnd.Value = DateTime.Now;
            txtTotalEmployee.Text = reportBUS.totalEmployee().ToString();
            txtTotalCustomer.Text = reportBUS.totalCustomer().ToString();
            txtTotalCake.Text = reportBUS.totalCake().ToString();
            txtTotalOrder.Text = reportBUS.totalOrder().ToString();
            txtTotalManufactor.Text = reportBUS.totalManufactor().ToString();
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
                //end time is now
                dtpEnd.Value = DateTime.Now;
                string start_time = dtpStart.Value.ToString("yyyy-MM-dd");
                string end_time = dtpEnd.Value.ToString("yyyy-MM-dd");
                string field = "Cake.CakeName";
                string data = "";
                setReportImportTable(start_time, end_time, field, data);

            }
            else if (tabControl1.SelectedIndex == 2)
            {
                //end time is now
                dtpEnd.Value = DateTime.Now;
                string start_time = dtpStartSell.Value.ToString("yyyy-MM-dd");
                string end_time = dtpEndSell.Value.ToString("yyyy-MM-dd");
                string field = "Cake.CakeName";
                string data = "";
                setReportSellTable(start_time, end_time, field, data);
            }
        }

        #region Report Import
        public void setCbxSearch()
        {
            cbxSearch.Items.Add("Ten San Pham");
            cbxSearch.Items.Add("Loai San Pham");
            cbxSearch.Items.Add("Nha San Xuat");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = cbxSearch.SelectedIndex;
            string field = "Cake.CakeName";
            string data = "";
            if (index == 0)
            {
                field = "Cake.CakeName";
                data = searchValue.Text;

            }
            else if (index == 1)
            {
                field = "Category.CategoryName";
                data = searchValue.Text;
            }
            else if (index == 2)
            {
                field = "Supplier.SuppName";
                data = searchValue.Text;
            }
            string start_time = dtpStart.Value.ToString("yyyy-MM-dd");
            string end_time = dtpEnd.Value.ToString("yyyy-MM-dd");
            setReportImportTable(start_time, end_time, field, data);
        }

        private void setReportImportTable(string start_time, string end_time, string field, string data)
        {
            tableImportReport.Rows.Clear();
            tableImportReport.ColumnCount = 7;
            tableImportReport.Columns[0].Name = "Ma San Pham";
            tableImportReport.Columns[1].Name = "Ten San Pham";
            tableImportReport.Columns[2].Name = "Loai San Pham";
            tableImportReport.Columns[3].Name = "Nha Cung Cap";
            tableImportReport.Columns[4].Name = "So Luong";
            tableImportReport.Columns[5].Name = "Tong Tien Gia";
            tableImportReport.Columns[6].Name = "Thoi Gian";
            List<ReportImport_DTO> list = reportBUS.reportImport(start_time, end_time, field, data);
            foreach (ReportImport_DTO item in list)
            {
                tableImportReport.Rows.Add(item.CakeId, item.CakeName, item.CakeType, item.Supplier, item.Quantity.ToString(), item.TotalPrice.ToString(), item.Date);
            }

        }


        private void ToExcel(DataGridView dataGridView1, string fileName)
        {

            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {

                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];

                worksheet.Name = "ReportTable";


                for (int i = 0; i < tableImportReport.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = tableImportReport.Columns[i].HeaderText;
                }

                for (int i = 0; i < tableImportReport.RowCount; i++)
                {
                    for (int j = 0; j < tableImportReport.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableImportReport.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(fileName);

                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void exportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(tableImportReport, saveFileDialog.FileName);
            }
        }

        //refresh
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string field = "Cake.CakeName";
            string data = "";
            dtpStart.Value = new DateTime(2022, 1, 1);
            dtpEnd.Value = DateTime.Now;
            string start_time = dtpStart.Value.ToString("yyyy-MM-dd");
            string end_time = dtpEnd.Value.ToString("yyyy-MM-dd");
            setReportImportTable(start_time, end_time, field, data);

        }
        #endregion



        #region Sell
        private void setReportSellTable(string start_time, string end_time, string field, string data)
        {
            tableSellReport.Rows.Clear();
            tableSellReport.ColumnCount = 7;
            tableSellReport.Columns[0].Name = "Ma San Pham";
            tableSellReport.Columns[1].Name = "Ten San Pham";
            tableSellReport.Columns[2].Name = "Loai San Pham";
            tableSellReport.Columns[3].Name = "Khach Hang";
            tableSellReport.Columns[4].Name = "So Luong";
            tableSellReport.Columns[5].Name = "Tong Tien Gia";
            tableSellReport.Columns[6].Name = "Thoi Gian";
            List<ReportSell_DTO> list = reportBUS.reportSell(start_time, end_time, field, data);
            foreach (ReportSell_DTO item in list)
            {
                tableSellReport.Rows.Add(item.CakeId, item.CakeName, item.CakeType, item.Customer, item.Quantity.ToString(), item.TotalPrice.ToString(), item.Date);
            }
        }

        public void setCbxSellSearch()
        {
            cbxSellSearch.Items.Add("Ten San Pham");
            cbxSellSearch.Items.Add("Loai San Pham");
            cbxSellSearch.Items.Add("Ten Khach Hang");
        }

        private void btnSellSearch_Click(object sender, EventArgs e)
        {
            int index = cbxSellSearch.SelectedIndex;
            string field = "Cake.CakeName";
            string data = "";
            if (index == 0)
            {
                field = "Cake.CakeName";
                data = sellSearch.Text;

            }
            else if (index == 1)
            {
                field = "Category.CategoryName";
                data = sellSearch.Text;
            }
            else if (index == 2)
            {
                field = "Customer.Name";
                data = sellSearch.Text;
            }
            string start_time = dtpStartSell.Value.ToString("yyyy-MM-dd");
            string end_time = dtpEndSell.Value.ToString("yyyy-MM-dd");
            setReportSellTable(start_time, end_time, field, data);
        }

        private void ToExcelSell(DataGridView dataGridView1, string fileName)
        {

            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {

                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];

                worksheet.Name = "Report_Sell_Table";


                for (int i = 0; i < tableSellReport.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = tableSellReport.Columns[i].HeaderText;
                }

                for (int i = 0; i < tableSellReport.RowCount; i++)
                {
                    for (int j = 0; j < tableSellReport.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableSellReport.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(fileName);

                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void exportExcelSell_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToExcelSell(tableImportReport, saveFileDialog.FileName);
            }

        }

        //refresh
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string field = "Cake.CakeName";
            string data = "";
            dtpStart.Value = new DateTime(2022, 1, 1);
            dtpEnd.Value = DateTime.Now;
            string start_time = dtpStart.Value.ToString("yyyy-MM-dd");
            string end_time = dtpEnd.Value.ToString("yyyy-MM-dd");
            setReportSellTable(start_time, end_time, field, data);
        }


        #endregion



    }
}




