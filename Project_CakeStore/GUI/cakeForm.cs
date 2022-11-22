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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace Project_CakeStore.GUI
{
    public partial class cakeForm : Form
    {
        String getName = "";
        String getID = "";
        private List<category_DTO> list;
        private cake_BUS cakeBUS = new cake_BUS();
        private category_BUS cateBUS = new category_BUS();


        public cakeForm(String name, String id)
        {
            InitializeComponent();
            getName = name;
            getID = id;
            txtAccName.Text = getName + "(" + getID + ")";
            setTableCake();
            setCmbSearch();
            setCmbCate();
            
        }

        public void setTableCake()
        {
            tableCake.Rows.Clear();
            List<cake_DTO> list = cakeBUS.getAllCakeName();

            tableCake.ColumnCount = 5;
            tableCake.Columns[0].Name = "Mã";
            tableCake.Columns[1].Name = "Tên";
            tableCake.Columns[2].Name = "Loại";
            tableCake.Columns[3].Name = "Đơn giá";
            tableCake.Columns[4].Name = "Số lượng";

            for (int i = 0; i < list.Count; i++)
            {
                cake_DTO cake = list.ElementAt(i);
                tableCake.Rows.Add(cake.getCakeID()
                    , cake.getCakeName()
                    , cake.getCategoryID()
                    , cake.getUnitPrice()
                    , cake.getQuantity());
            }
        }

        public void setCmbSearch()
        {
            cmbTypeSearch.Items.Clear();
            cmbTypeSearch.Items.Add("Mã bánh");
            cmbTypeSearch.Items.Add("Tên bánh");
            cmbTypeSearch.Items.Add("Loại bánh");
        }

        public void setCmbCate()
        {
            list = cateBUS.getAllCategory();
            for (int i = 0; i < list.Count; i++)
            {
                category_DTO cate = list.ElementAt(i);
                String cateID = cate.getCategoryID() ;
                cmbCate.Items.Add(cateID);
            }
        }

        public void setTableSearch(String column, String data)
        {
            tableCake.Rows.Clear();
            List<cake_DTO> list = cakeBUS.searchCake(column, data);

            tableCake.ColumnCount = 5;
            tableCake.Columns[0].Name = "Mã";
            tableCake.Columns[1].Name = "Tên";
            tableCake.Columns[2].Name = "Loại";
            tableCake.Columns[3].Name = "Đơn giá";
            tableCake.Columns[4].Name = "Số lượng";

            for (int i = 0; i < list.Count; i++)
            {
                cake_DTO cake = list.ElementAt(i);
                tableCake.Rows.Add(cake.getCakeID()
                    , cake.getCakeName()
                    , cake.getCategoryID()
                    , cake.getUnitPrice()
                    , cake.getQuantity());
            }
        }

        public Boolean checkInput(String cakeName, String unitPrice, String quantity)
        {
            Boolean check = false;
            String checkNum = @"(-)\d{0,9}";
            String checkChar = @"\D";
            Regex rg1 = new Regex(checkNum);
            Regex rg2 = new Regex(checkChar);

            if(cakeName.Trim().Equals("") || unitPrice.Trim().Equals("") || quantity.Trim().Equals(""))
            {
                
                MessageBox.Show("Vui long nhap dung format");
            }
            else if(rg1.IsMatch(quantity) || rg2.IsMatch(quantity) || rg1.IsMatch(unitPrice) || rg2.IsMatch(unitPrice))
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                check = true;
            }


            return check;
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
                
                worksheet.Name = "Cake Table";

                
                for (int i = 0; i < tableCake.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = tableCake.Columns[i].HeaderText;
                }
                
                for (int i = 0; i < tableCake.RowCount; i++)
                {
                    for (int j = 0; j < tableCake.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableCake.Rows[i].Cells[j].Value.ToString();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInput(txtCakeName.Text, txtUnitPrice.Text, txtQuantity.Text))
            {
                cake_DTO cake = new cake_DTO("", txtCakeName.Text
                , cmbCate.SelectedItem.ToString(), int.Parse(txtUnitPrice.Text)
                , int.Parse(txtQuantity.Text), "");

                if (cakeBUS.addCakeAuto(cake))
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
            }
        }

        private void tableCake_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableCake.Rows[e.RowIndex];
                txtCakeId.Text = row.Cells["Mã"].Value.ToString();
                txtCakeName.Text = row.Cells["Tên"].Value.ToString();
                cmbCate.SelectedItem = row.Cells["Loại"].Value.ToString();
                txtUnitPrice.Text = row.Cells["Đơn giá"].Value.ToString();
                txtQuantity.Text = row.Cells["Số lượng"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cakeBUS.deleteCake(txtCakeId.Text))
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(checkInput(txtCakeName.Text, txtUnitPrice.Text, txtQuantity.Text))
            {
                cake_DTO cake = new cake_DTO(txtCakeId.Text, txtCakeName.Text
                , cmbCate.SelectedItem.ToString(), int.Parse(txtUnitPrice.Text)
                , int.Parse(txtQuantity.Text), "");

                if (cakeBUS.editCake(cake))
                {
                    MessageBox.Show("Chinh sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Chinh sua that bai");
                }
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtContent.Text;
            if(cmbTypeSearch.SelectedIndex == 0)
            {
                setTableSearch("CakeID", data);
            }
            else if(cmbTypeSearch.SelectedIndex == 1)
            {
                setTableSearch("CakeName", data);
            }
            else if(cmbTypeSearch.SelectedIndex == 2)
            {
                setTableSearch("CategoryID", data);
            }
        }

        private void btnExportEcel_Click(object sender, EventArgs e)


        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(tableCake, saveFileDialog.FileName);
            }
        }

<<<<<<< HEAD
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(getName, getID);
            main.ShowDialog();
=======
        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i<=excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row+1; i < excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                DataGridView dataGridView = new DataGridView();
                dataGridView.DataSource = dataTable;
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập dữ liệu vào Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập dữ liệu không thành công!\n" + ex.Message);
                }
            }
>>>>>>> eab1018161c511e9181614015e14b0f46c96b8a7
        }
    }
}
