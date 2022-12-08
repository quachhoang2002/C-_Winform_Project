using Project_CakeStore.BUS;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CakeStore.GUI
{
    public partial class orderForm : Form
    {
        private order_BUS orderBUS = new order_BUS();
        String getName = "";
        String getId = "";
        public orderForm(String name, String id)
        {
            InitializeComponent();
            getId = id;
            getName = name;
            txtAccName.Text = getName +"("+getId+")";
            setTableOrder();
            setCmbTypeSearch();
        }

        //Ham set du lieu cho bang order
        public void setTableOrder()
        {
            tableOrder.ColumnCount = 4;
            tableOrder.Columns[0].Name = "Mã hóa đơn";
            tableOrder.Columns[1].Name = "Mã khách hàng";
            tableOrder.Columns[2].Name = "Mã nhân viên";
            tableOrder.Columns[3].Name = "Ngày lập hóa đơn";

            List<order_DTO> listOrder = orderBUS.getAllorder();
            for(int i = 0; i < listOrder.Count; i++)
            {
                order_DTO order = listOrder[i];
                tableOrder.Rows.Add(order.getOrderID()
                    , order.getCusID()
                    , order.getEmpID()
                    , order.getDate());
            }

        }

        //set table khi search
        public void setTableSearch(String column, String data)
        {
            tableOrder.Rows.Clear();
            tableOrder.ColumnCount = 4;
            tableOrder.Columns[0].Name = "Mã hóa đơn";
            tableOrder.Columns[1].Name = "Mã khách hàng";
            tableOrder.Columns[2].Name = "Mã nhân viên";
            tableOrder.Columns[3].Name = "Ngày lập hóa đơn";

            List<order_DTO> list = orderBUS.searchOrder(column, data);
            for(int i = 0; i < list.Count; i++)
            {
                order_DTO order = list[i];
                tableOrder.Rows.Add(order.getOrderID()
                    , order.getCusID()
                    , order.getEmpID()
                    , order.getDate());
            }
        }

        //Set combobox cot muon search
        public void setCmbTypeSearch()
        {
            cmbTypeSearch.Items.Add("Tất cả");
            cmbTypeSearch.Items.Add("Mã hóa đơn");
            cmbTypeSearch.Items.Add("Mã khách hàng");
            cmbTypeSearch.Items.Add("Mã nhân viên");
            
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tableOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = tableOrder.Rows[e.RowIndex];
                String orderId = row.Cells["Mã hóa đơn"].Value.ToString();
                String cusId = row.Cells["Mã khách hàng"].Value.ToString();
                String EmpId = row.Cells["Mã nhân viên"].Value.ToString();
                String date = row.Cells["Ngày lập hóa đơn"].Value.ToString();

                showOrderDetailForm showOrder = new showOrderDetailForm(getName, getId, orderId, cusId, EmpId, date);
                showOrder.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtContent.Text;
            int index = cmbTypeSearch.SelectedIndex;
            if(index == 0)
            {
                setTableOrder();
            }
            else if(index == 1)
            {
                setTableSearch("OrderID", data);
                txtContent.Text = "";
            } 
            else if(index == 2)
            {
                setTableSearch("CusID", data);
                txtContent.Text = "";
            }
            else if(index == 3)
            {
                setTableSearch("EmpID", data);
                txtContent.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tableOrder.Rows.Clear();
            setTableOrder();
            txtContent.Text = "";
        }

        private void tableOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                worksheet.Name = "Account Table";


                for (int i = 0; i < tableOrder.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = tableOrder.Columns[i].HeaderText;
                }

                for (int i = 0; i < tableOrder.RowCount; i++)
                {
                    for (int j = 0; j < tableOrder.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableOrder.Rows[i].Cells[j].Value.ToString();
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
        private void btnExportEcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(tableOrder, saveFileDialog.FileName);
            }
        }
    }
}
