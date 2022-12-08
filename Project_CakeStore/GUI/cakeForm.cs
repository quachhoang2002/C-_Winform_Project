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
            tableCake.ColumnCount = 4;
            tableCake.Columns[0].Name = "Mã";
            tableCake.Columns[1].Name = "Tên";
            tableCake.Columns[2].Name = "Loại";
            tableCake.Columns[3].Name = "Đơn giá";

            for (int i = 0; i < list.Count; i++)
            {
                cake_DTO cake = list.ElementAt(i);
                tableCake.Rows.Add(cake.getCakeID()
                    , cake.getCakeName()
                    , cake.getCategoryID() + " - " + cake.getCategoryName()
                    , cake.getUnitPrice());
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
                String cateID = cate.getCategoryID();
                String cakeName = cate.getCategoryName();
                cmbCate.Items.Add(cateID + " - " + cakeName);
            }
        }

        public void setTableSearch(String column, String data)
        {
            tableCake.Rows.Clear();
            List<cake_DTO> list = cakeBUS.searchCake(column, data);

            tableCake.ColumnCount = 4;
            tableCake.Columns[0].Name = "Mã";
            tableCake.Columns[1].Name = "Tên";
            tableCake.Columns[2].Name = "Loại";
            tableCake.Columns[3].Name = "Đơn giá";

            for (int i = 0; i < list.Count; i++)
            {
                cake_DTO cake = list.ElementAt(i);
                tableCake.Rows.Add(cake.getCakeID()
                    , cake.getCakeName()
                    , cake.getCategoryID()
                    , cake.getUnitPrice());
            }
        }

        public Boolean checkInput(String cakeName, String unitPrice, int typeIndex)
        {
            Boolean check = false;
            String checkNum = @"(-)\d{0,9}";
            String checkChar = @"\D";
            Regex rg1 = new Regex(checkNum);
            Regex rg2 = new Regex(checkChar);

            if (cakeName == "" || unitPrice == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (rg1.IsMatch(unitPrice))
            {
                MessageBox.Show("Đơn giá không được âm");
            }
            else if (rg2.IsMatch(unitPrice))
            {
                MessageBox.Show("Đơn giá  phải là số");
            }
            else if (typeIndex == -1)
            {
                MessageBox.Show("Hay chon loai");
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
            if (checkInput(txtCakeName.Text, txtUnitPrice.Text, cmbCate.SelectedIndex))
            {
                String categoryID = cmbCate.SelectedItem.ToString().Substring(0, 2);
                cake_DTO cake = new cake_DTO("", txtCakeName.Text
                , categoryID, int.Parse(txtUnitPrice.Text)
                , 0, "");

                if (cakeBUS.addCakeAuto(cake))
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
            }

            setTableCake();
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
            setTableCake();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkInput(txtCakeName.Text, txtUnitPrice.Text, cmbCate.SelectedIndex))
            {
                String categoryID = cmbCate.SelectedItem.ToString().Substring(0, 2);
                cake_DTO cake = new cake_DTO(txtCakeId.Text, txtCakeName.Text
                , categoryID, int.Parse(txtUnitPrice.Text)
                , 0, "");

                if (cakeBUS.editCake(cake))
                {
                    MessageBox.Show("Chinh sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Chinh sua that bai");
                }
                setTableCake();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtContent.Text;
            if (cmbTypeSearch.SelectedIndex == 0)
            {
                setTableSearch("CakeID", data);
            }
            else if (cmbTypeSearch.SelectedIndex == 1)
            {
                setTableSearch("CakeName", data);
            }
            else if (cmbTypeSearch.SelectedIndex == 2)
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



        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCakeId.Text = "";
            txtCakeName.Text = "";
            txtContent.Text = "";
            txtUnitPrice.Text = "";
            setTableCake();
        }
    }
}
