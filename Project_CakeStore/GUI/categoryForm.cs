using OfficeOpenXml;
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
    public partial class categoryForm : Form
    {
        String getName = "";
        String getID = "";
        private category_BUS cateBUS = new category_BUS();

        public categoryForm(String name, String id)
        {
            InitializeComponent();
            getName = name;
            getID = id;
            txtAccName.Text = getName + "(" + getID + ")";
            setTableCate();
            setCmbSearch();
        }

        public void setTableCate()
        {
            tableCate.Rows.Clear();
            List<category_DTO> list = cateBUS.getAllCategory();

            tableCate.ColumnCount = 2;
            tableCate.Columns[0].Name = "Mã";
            tableCate.Columns[1].Name = "Tên";

            for (int i = 0; i < list.Count; i++)
            {
                category_DTO cake = list.ElementAt(i);
                tableCate.Rows.Add(cake.getCategoryID()
                    , cake.getCategoryName());
            }
        }

        public void setCmbSearch()
        {
            cmbTypeSearch.Items.Clear();
            cmbTypeSearch.Items.Add("Mã danh mục");
            cmbTypeSearch.Items.Add("Tên danh mục");
        }

        public void setTableSearch(String column, String data)
        {
            tableCate.Rows.Clear();
            List<category_DTO> list = cateBUS.searchCate(column, data);

            tableCate.ColumnCount = 2;
            tableCate.Columns[0].Name = "Mã";
            tableCate.Columns[1].Name = "Tên";

            for (int i = 0; i < list.Count; i++)
            {
                category_DTO cate = list.ElementAt(i);
                tableCate.Rows.Add(cate.getCategoryID()
                    , cate.getCategoryName());
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

                worksheet.Name = "Category Table";


                for (int i = 0; i < tableCate.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = tableCate.Columns[i].HeaderText;
                }

                for (int i = 0; i < tableCate.RowCount; i++)
                {
                    for (int j = 0; j < tableCate.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableCate.Rows[i].Cells[j].Value.ToString();
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
            if (txtCateName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                category_DTO cate = new category_DTO("", txtCateName.Text);
                if (cateBUS.addCate(cate))
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
            }
            setTableCate();
        }

        private void tableCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableCate.Rows[e.RowIndex];
                txtCateID.Text = row.Cells["Mã"].Value.ToString();
                txtCateName.Text = row.Cells["Tên"].Value.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cateBUS.deleteCate(txtCateID.Text))
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
            setTableCate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCateName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                category_DTO cate = new category_DTO(txtCateID.Text, txtCateName.Text);
                if (cateBUS.editCate(cate))
                {
                    MessageBox.Show("Chinh sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Chinh sua that bai");
                }
            }
            setTableCate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtContent.Text;
            if (cmbTypeSearch.SelectedIndex == 0)
            {
                setTableSearch("CategoryID", data);
            }
            else if (cmbTypeSearch.SelectedIndex == 1)
            {
                setTableSearch("CategoryName", data);
            }
        }

        private void btnExportEcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(tableCate, saveFileDialog.FileName);
            }
        }

        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row + 1; i < excelWorksheet.Dimension.End.Row; i++)
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
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
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(getName, getID);
            mainForm.ShowDialog();
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
        }
    }
}
