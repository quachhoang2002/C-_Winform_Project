using Project_CakeStore.BUS;
using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CakeStore.GUI
{
    public partial class employeeForm : Form
    {
        private employee_BUS emp_BUS = new employee_BUS();
        String getName = "";
        String getId = "";
        public employeeForm(String name, String id)
        {
            InitializeComponent();
            getId = id;
            getName = name;
            txtAccName.Text = getName + "(" + getId + ")";
            setTableEmloyee();
            setCbxSearch();
            loadNewestEmpID();
        }


        //set data for employee table
        public void setTableEmloyee()
        {
            tableEmployee.Rows.Clear();
            tableEmployee.ColumnCount = 6;
            tableEmployee.Columns[0].Name = "Mã Nhân Viên";
            tableEmployee.Columns[1].Name = "Họ Tên";
            tableEmployee.Columns[2].Name = "Vị Trí";
            tableEmployee.Columns[3].Name = "Giới Tính";
            tableEmployee.Columns[4].Name = "Số Điện Thoại";
            tableEmployee.Columns[5].Name = "Địa Chỉ";
            List<employee_DTO> listEmployee = emp_BUS.getAllEmployee();
            for (int i = 0; i < listEmployee.Count; i++)
            {
                employee_DTO emp = listEmployee[i];
                tableEmployee.Rows.Add(emp.getEmpID()
                    , emp.getEmpName()
                    , emp.getPosition()
                    , emp.getSex()
                    , emp.getPhone()
                    , emp.getAddress());

            }
        }
        public void setCbxSearch()
        {
            cbxSearch.Items.Add("Tất cả");
            cbxSearch.Items.Add("Mã Nhân Viên");
            cbxSearch.Items.Add("Tên Nhân Viên");

        }
        public void setTableSearchByID(String data)
        {
            tableEmployee.Rows.Clear();
            tableEmployee.ColumnCount = 6;
            tableEmployee.Columns[0].Name = "Mã Nhân Viên";
            tableEmployee.Columns[1].Name = "Họ Tên";
            tableEmployee.Columns[2].Name = "Vị Trí";
            tableEmployee.Columns[3].Name = "Giới Tính";
            tableEmployee.Columns[4].Name = "Số Điện Thoại";
            tableEmployee.Columns[5].Name = "Địa Chỉ";
            List<employee_DTO> listEmployeeSearch = emp_BUS.searchEmployeeByID(data);
            for (int i = 0; i < listEmployeeSearch.Count; i++)
            {
                employee_DTO emp = listEmployeeSearch[i];
                tableEmployee.Rows.Add(emp.getEmpID(),
                    emp.getEmpName(),
                    emp.getPosition(),
                    emp.getSex(),
                    emp.getPhone(),
                    emp.getAddress());
            }

        }

        public void loadNewestEmpID()
        {       
            List<employee_DTO> NewestEmpID = emp_BUS.SearchNewestEmpID();
            for (int i = 0; i < NewestEmpID.Count; i++)
            {
                employee_DTO emp = NewestEmpID[i];
                txtNewestEmpID.Text = emp.getEmpID();
            }
        }
        public void setTableSearchByName(String data)
        {
            tableEmployee.Rows.Clear();
            tableEmployee.ColumnCount = 6;
            tableEmployee.Columns[0].Name = "Mã Nhân Viên";
            tableEmployee.Columns[1].Name = "Họ Tên";
            tableEmployee.Columns[2].Name = "Vị Trí";
            tableEmployee.Columns[3].Name = "Giới Tính";
            tableEmployee.Columns[4].Name = "Số Điện Thoại";
            tableEmployee.Columns[5].Name = "Địa Chỉ";
            List<employee_DTO> listEmployeeSearch = emp_BUS.searchEmployeeByName(data);
            for (int i = 0; i < listEmployeeSearch.Count; i++)
            {
                employee_DTO emp = listEmployeeSearch[i];
                tableEmployee.Rows.Add(emp.getEmpID(),
                    emp.getEmpName(),
                    emp.getPosition(),
                    emp.getSex(),
                    emp.getPhone(),
                    emp.getAddress());
            }
        }
        private void tableEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập vào mã nhân viên!");
            }

            else if (txtEmpName.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập vào họ tên nhân viên!");

            }
            else if (txtEmpPosition.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập vào vị trí nhân viên!");

            }
            else if (cbxEmpSex.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn giới tính nhân viên!");

            }
            else if (txtEmpPhone.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập vào số diện thoại của nhân viên!");

            }
            else if (txtEmpAddress.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập vào địa chỉ của nhân viên!");

            }
            else
            {
                employee_DTO emp = new employee_DTO();
                emp.setEmpID(txtEmpID.Text);
                emp.setEmpName(txtEmpName.Text);
                emp.setPosition(txtEmpPosition.Text);
                emp.setSex(cbxEmpSex.Text);
                emp.setPhone(txtEmpPhone.Text);
                emp.setAddress(txtEmpAddress.Text);
                if (emp_BUS.addEmployee(emp))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    resetData();
                }

            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(getName, getId);
            main.ShowDialog();
        }
        public void resetData()
        {
            txtEmpID.Enabled = true;
            txtEmpID.Text = "";
            txtEmpName.Text = "";
            txtEmpPosition.Text = "";
            cbxEmpSex.Text = "";
            txtEmpPhone.Text = "";
            txtEmpAddress.Text = "";
            txtSearch.Text = "";
            cbxSearch.Text = "";
            setTableEmloyee();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtEmpID.Enabled = false;
                DataGridViewRow row = tableEmployee.Rows[e.RowIndex];
                txtEmpID.Text = row.Cells["Mã Nhân Viên"].Value.ToString();
                txtEmpName.Text = row.Cells["Họ Tên"].Value.ToString();
                txtEmpPosition.Text = row.Cells["Vị Trí"].Value.ToString();
                cbxEmpSex.Text = row.Cells["Giới Tính"].Value.ToString();
                txtEmpPhone.Text = row.Cells["Số Điện Thoại"].Value.ToString();
                txtEmpAddress.Text = row.Cells["Địa Chỉ"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            employee_DTO emp = new employee_DTO();
            emp.setEmpID(txtEmpID.Text);
            if (emp_BUS.deleteEmployee(emp))
            {
                MessageBox.Show("Xóa nhân viên thành công!");
                
                tableEmployee.Rows.Clear();
                resetData();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập vào họ tên nhân viên!");

            }
            else if (txtEmpPosition.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập vào vị trí nhân viên!");

            }
            else if (cbxEmpSex.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn giới tính nhân viên!");

            }
            else if (txtEmpPhone.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập vào số diện thoại của nhân viên!");

            }
            else if (txtEmpAddress.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập vào địa chỉ của nhân viên!");

            }
            else
            {
                employee_DTO emp = new employee_DTO();
                emp.setEmpID(txtEmpID.Text);
                emp.setEmpName(txtEmpName.Text);
                emp.setPosition(txtEmpPosition.Text);
                emp.setSex(cbxEmpSex.Text);
                emp.setPhone(txtEmpPhone.Text);
                emp.setAddress(txtEmpAddress.Text);

                if (emp_BUS.updateEmployee(emp))
                {
                    txtEmpID.Enabled = true;
                    MessageBox.Show("Sửa nhân viên thành công!");
                    resetData();

                }

            }
        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtSearch.Text;
            int index = cbxSearch.SelectedIndex;
            if (index == 0)
            {
                setTableEmloyee();
            }
            else if (index == 1)
            {
                setTableSearchByID(data);
                txtSearch.Text = "";
            }
            else if (index == 2)
            {
                setTableSearchByName(data);
                txtSearch.Text = "";
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

                worksheet.Name = "Cake Table";


                for (int i = 0; i < tableEmployee.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = tableEmployee.Columns[i].HeaderText;
                }

                for (int i = 0; i < tableEmployee.RowCount; i++)
                {
                    for (int j = 0; j < tableEmployee.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableEmployee.Rows[i].Cells[j].Value.ToString();
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
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(tableEmployee, saveFileDialog.FileName);
            }
        }
    }
}