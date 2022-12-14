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
    public partial class importForm : Form
    {
        String getName = "";
        String getId = "";
        private import_BUS importBus = new import_BUS();
        public importForm(String name, String id)
        {
            InitializeComponent();
            setTableimport();
            setCmb();
            getName = name;
            getId = id;
            txtAccName.Text = getName+"("+getId+")";
        }

        //Ham set table import
        public void setTableimport()
        {
            List<import_DTO> list = importBus.getAllImport();
            tableImport.ColumnCount = 4;
            tableImport.Columns[0].Name = "Mã phiếu nhập";
            tableImport.Columns[1].Name = "Mã nhà cung cấp";
            tableImport.Columns[2].Name = "Mã nhân viên";
            tableImport.Columns[3].Name = "Ngày lập phiếu nhập";
            for(int i = 0; i < list.Count; i++)
            {
                import_DTO import = list[i];
                tableImport.Rows.Add(import.getImportID()
                    , import.getSuppID()
                    , import.getEmpID()
                    , import.getDate());
            }
        }

        //Ham set table khi search
        public void setSearch(String column, String data)
        {
            tableImport.Rows.Clear();
            List<import_DTO> list = importBus.searchImport(column, data);
            tableImport.ColumnCount = 4;
            tableImport.Columns[0].Name = "Mã phiếu nhập";
            tableImport.Columns[1].Name = "Mã nhà cung cấp";
            tableImport.Columns[2].Name = "Mã nhân viên";
            tableImport.Columns[3].Name = "Ngày lập phiếu nhập";
            for (int i = 0; i < list.Count; i++)
            {
                import_DTO import = list[i];
                tableImport.Rows.Add(import.getImportID()
                    , import.getSuppID()
                    , import.getEmpID()
                    , import.getDate());
            }
        }
    

        //Ham set combobox option
        public void setCmb()
        {
            cmbTypeSearch.Items.Add("Tất cả");
            cmbTypeSearch.Items.Add("Mã phiếu nhập");
            cmbTypeSearch.Items.Add("Mã nhà cung cấp");
            cmbTypeSearch.Items.Add("Mã nhân viên");
        }

        //Ham show chi tiet phieu nhap
        private void tableImport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = tableImport.Rows[e.RowIndex];
                String importID = row.Cells["Mã phiếu nhập"].Value.ToString();
                String suppID = row.Cells["Mã nhà cung cấp"].Value.ToString();
                String EmpId = row.Cells["Mã nhân viên"].Value.ToString();
                String date = row.Cells["Ngày lập phiếu nhập"].Value.ToString();

                showImportDetailForm show = new showImportDetailForm(getName, getId, importID, suppID, EmpId, date);
                show.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtContent.Text;
            int index = cmbTypeSearch.SelectedIndex;
            if (index == 0)
            {
                setTableimport();
            }
            else if (index == 1)
            {
                setSearch("ImportID", data);
                txtContent.Text = "";
            }
            else if (index == 2)
            {
                setSearch("SuppID", data);
                txtContent.Text = "";
            }
            else if (index == 3)
            {
                setSearch("EmployeeID", data);
                txtContent.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tableImport.Rows.Clear();
            txtContent.Text = "";
            setTableimport();
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


                for (int i = 0; i < tableImport.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = tableImport.Columns[i].HeaderText;
                }

                for (int i = 0; i < tableImport.RowCount; i++)
                {
                    for (int j = 0; j < tableImport.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableImport.Rows[i].Cells[j].Value.ToString();
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
                ToExcel(tableImport, saveFileDialog.FileName);
            }
        }
    }
}
