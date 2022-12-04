using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Project_CakeStore.BUS;
using Project_CakeStore.DTO;

namespace Project_CakeStore.GUI
{
    public partial class accountForm : Form
    {
        private string getName;
        private string getId;
        private account_BUS accountBus = new account_BUS();
        private employee_BUS employeeBUS = new employee_BUS();
        public accountForm(string getName, string getId)
        {
            InitializeComponent();
            this.getName = getName;
            this.getId = getId;
            txtAccName1.Text = getName + "(" + getId + ")";
            SetTableAccount();
            SetCmbTypeSearch();
            SetCmbEmployeeID();
            SetCmbPermission();
        }

        public void SetTableAccount()
        {
            tableAccount.Rows.Clear();
            tableAccount.ColumnCount = 5;
            tableAccount.Columns[0].Name = "Mã tài khoản";
            tableAccount.Columns[1].Name = "Mã nhân viên";
            tableAccount.Columns[2].Name = "Tên tài khoản";
            tableAccount.Columns[3].Name = "Mật khẩu";
            tableAccount.Columns[4].Name = "Quyền";

            List<account_DTO> listAccount = accountBus.getAllAccount();
            for (int i = 0; i < listAccount.Count; i++)
            {
                account_DTO account = listAccount[i];
                tableAccount.Rows.Add(account.AccID, account.EmpID, account.UserName, account.Password, account.AccountPermission.ToString());
            }
        }

        public void setTableSearch(String column, String data)
        {
            tableAccount.Rows.Clear();
            List<account_DTO> list = accountBus.SearchAccount(column, data);
            for (int i = 0; i < list.Count; i++)
            {
                account_DTO account = list[i];
                tableAccount.Rows.Add(account.AccID, account.EmpID, account.UserName, account.Password, account.AccountPermission.ToString());
            }
        }


        public void SetCmbTypeSearch()
        {
            cmbTypeSearch.Items.Clear();
            cmbTypeSearch.Items.Add("Tất cả");
            cmbTypeSearch.Items.Add("Mã tài khoản");
            cmbTypeSearch.Items.Add("Mã nhân viên");
            cmbTypeSearch.SelectedIndex = 0;
        }

        public void SetCmbEmployeeID()
        {
            cmbEmpID.Items.Clear();
            List<employee_DTO> listEmp = employeeBUS.getAllEmployee();
            foreach (employee_DTO emp in listEmp)
            {
                cmbEmpID.Items.Add(emp.getEmpID());
            }
        }

        public void SetCmbPermission()
        {
            cmbPermission.Items.Clear();
            cmbPermission.Items.Add(account_DTO.Permission.Employee.ToString());
            cmbPermission.Items.Add(account_DTO.Permission.Manager.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtContent.Text;
            int index = cmbTypeSearch.SelectedIndex;
            if (index == 0)
            {
                SetTableAccount();
            }
            else if (index == 1)
            {
                setTableSearch("AccID", data);
                txtContent.Text = "";
            }
            else if (index == 2)
            {
                setTableSearch("EmpID", data);
                txtContent.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tableAccount.Rows.Clear();
            tableAccount.ClearSelection();
            SetTableAccount();
            txtContent.Text = "";
            txtAccID.Text = "";
            txtAccName2.Text = "";
            txtPass.Text = "";
            cmbPermission.SelectedIndex = -1;
            cmbEmpID.SelectedIndex = -1;
        }

        private void tableAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableAccount.Rows[e.RowIndex];
                txtAccID.Text = row.Cells["Mã tài khoản"].Value.ToString();
                cmbEmpID.SelectedItem = row.Cells["Mã nhân viên"].Value.ToString();
                txtAccName2.Text = row.Cells["Tên tài khoản"].Value.ToString();
                txtPass.Text = row.Cells["Mật khẩu"].Value.ToString();
                cmbPermission.SelectedItem = row.Cells["Quyền"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbEmpID.SelectedIndex == -1 || cmbPermission.SelectedIndex == -1)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
                return;
            }

            String AccID = txtAccID.Text, EmpID = cmbEmpID.SelectedItem.ToString(), AccName = txtAccName2.Text, Pass = txtPass.Text, Permission = cmbPermission.SelectedItem.ToString();
            if (AccID.Length != 0 && AccName.Length != 0 && Pass.Length != 0 && Permission != null && EmpID != null)
            {
                if (Permission.Equals(account_DTO.Permission.Manager.ToString()))
                {
                    accountBus.UpdateAcc(new account_DTO(AccID, EmpID, AccName, Pass, account_DTO.Permission.Manager));
                    SetTableAccount();
                }
                else if(Permission.Equals(account_DTO.Permission.Employee.ToString()))
                {
                    accountBus.UpdateAcc(new account_DTO(AccID, EmpID, AccName, Pass, account_DTO.Permission.Employee));
                    SetTableAccount();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String AccID = txtAccID.Text;
            if (AccID.Length != 0)
            {
                accountBus.DeleteAccount(AccID);
                SetTableAccount();
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbEmpID.SelectedIndex == -1 || cmbPermission.SelectedIndex == -1)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
                return;
            }

            String AccID = "", EmpID = cmbEmpID.SelectedItem.ToString(), AccName = txtAccName2.Text, Pass = txtPass.Text, Permission = cmbPermission.SelectedItem.ToString();
            if (AccName.Length != 0 && Pass.Length != 0 && Permission!=null && EmpID!=null)
            {
                if (Permission.Equals(account_DTO.Permission.Manager.ToString()))
                {
                    accountBus.AddAccount(new account_DTO(AccID, EmpID, AccName, Pass, account_DTO.Permission.Manager));
                    SetTableAccount();
                }
                else if(Permission.Equals(account_DTO.Permission.Employee.ToString()))
                {
                    accountBus.AddAccount(new account_DTO(AccID, EmpID, AccName, Pass, account_DTO.Permission.Employee));
                    SetTableAccount();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
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

                worksheet.Name = "Account Table";


                for (int i = 0; i < tableAccount.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = tableAccount.Columns[i].HeaderText;
                }

                for (int i = 0; i < tableAccount.RowCount; i++)
                {
                    for (int j = 0; j < tableAccount.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableAccount.Rows[i].Cells[j].Value.ToString();
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
                ToExcel(tableAccount, saveFileDialog.FileName);
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
            MainForm main = new MainForm(getName, getId);
            main.ShowDialog();
        }
    }


}
