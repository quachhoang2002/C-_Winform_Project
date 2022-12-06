using OfficeOpenXml;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CakeStore.GUI
{
    public partial class customerForm : Form
    {
        private customer_BUS cus_BUS = new customer_BUS();
        RegexPattern regex = new RegexPattern();
        String getName = "";
        String getId = "";
        public customerForm(String name,String id)
        {
            InitializeComponent();
            getId = id;
            getName = name;
            txtCusID.Enabled = false;
            txtAccName.Text = getName + "(" + getId + ")";
            setTableCustomer();
            setCbxSearch();
        }

  
        public void setTableCustomer()
        {
            tableCustomer.Rows.Clear();
            tableCustomer.ColumnCount = 6;
            tableCustomer.Columns[0].Name = "Mã Khách Hàng";
            tableCustomer.Columns[1].Name = "Họ Tên";
            tableCustomer.Columns[2].Name = "Ngày Sinh";
            tableCustomer.Columns[3].Name = "Số Điện Thoại";
            tableCustomer.Columns[4].Name = "Giới Tính";
            tableCustomer.Columns[5].Name = "Địa Chỉ";
            List<customer_DTO> listCustomer = cus_BUS.getAllCusName();
            for(int i = 0; i < listCustomer.Count; i++)
            {
                customer_DTO cus = listCustomer[i];
                String CusID = cus.getCusID();
                String CusName = cus.getCusName();
                String CusDoB = cus.getDoB();
                String CusSex = cus.getSex();
                String CusPhone = cus.getPhone();
                String CusAddress = cus.getAddress();
                tableCustomer.Rows.Add(CusID, CusName, CusDoB, CusPhone, CusSex, CusAddress);

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text.Trim().Equals("") || dtDayOfBirth.Text.Trim().Equals("") || 
                txtCusPhone.Text.Trim().Equals("") || txtCusAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!");
            }
            else if (cbxCusSex.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính khách hàng!");
            }else if (!regex.checkPhoneNumber(txtCusPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!");
            }
            else
            {
                String id = "", cusname = txtCusName.Text, dob = dtDayOfBirth.Text, phone = txtCusPhone.Text, gender = cbxCusSex.SelectedItem.ToString(), add = txtCusAddress.Text;
                customer_DTO cus = new customer_DTO(id,cusname,dob,phone,gender,add);
                if (cus_BUS.addCustomer(cus))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    resetData();
                }
            }
        }


        public void setCbxSearch()
        {
            cbxSearch.Items.Add("Tất cả");
            cbxSearch.Items.Add("Mã Khách Hàng");
            cbxSearch.Items.Add("Tên Khách Hàng");

        }

        public void setTableSearchByID(String data)
        {
            tableCustomer.Rows.Clear();
            tableCustomer.ColumnCount = 6;
            tableCustomer.Columns[0].Name = "Mã Khách Hàng";
            tableCustomer.Columns[1].Name = "Họ Tên";
            tableCustomer.Columns[2].Name = "Ngày Sinh";
            tableCustomer.Columns[3].Name = "Số Điện Thoại";
            tableCustomer.Columns[4].Name = "Giới Tính";
            tableCustomer.Columns[5].Name = "Địa Chỉ";
            List<customer_DTO> listCustomerSearch = cus_BUS.searchCustomerByID(data);
            for (int i = 0; i < listCustomerSearch.Count; i++)
            {
                customer_DTO cus = listCustomerSearch[i];
                String CusID = cus.getCusID();
                String CusName = cus.getCusName();
                String CusDoB = cus.getDoB();
                String CusSex = cus.getSex();
                String CusPhone = cus.getPhone();
                String CusAddress = cus.getAddress();
                tableCustomer.Rows.Add(CusID, CusName, CusDoB, CusPhone, CusSex, CusAddress);
            }

        }


        public void setTableSearchByName(String data)
        {
            tableCustomer.Rows.Clear();
            tableCustomer.ColumnCount = 6;
            tableCustomer.Columns[0].Name = "Mã Khách Hàng";
            tableCustomer.Columns[1].Name = "Họ Tên";
            tableCustomer.Columns[2].Name = "Ngày Sinh";
            tableCustomer.Columns[3].Name = "Số Điện Thoại";
            tableCustomer.Columns[4].Name = "Giới Tính";
            tableCustomer.Columns[5].Name = "Địa Chỉ";
            List<customer_DTO> listCustomerSearch = cus_BUS.searchCustomerByName(data);
            for (int i = 0; i < listCustomerSearch.Count; i++)
            {
                customer_DTO cus = listCustomerSearch[i];
                String CusID = cus.getCusID();
                String CusName = cus.getCusName();
                String CusDoB = cus.getDoB();
                String CusSex = cus.getSex();
                String CusPhone = cus.getPhone();
                String CusAddress = cus.getAddress();
                tableCustomer.Rows.Add(CusID, CusName, CusDoB, CusPhone, CusSex, CusAddress);
            }

        }
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(getName, getId);
            main.ShowDialog();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtSearch.Text;
            int index = cbxSearch.SelectedIndex;
            if (index == 0)
            {
                setTableCustomer();
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

        private void tableCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableCustomer.Rows[e.RowIndex];
                txtCusID.Text = row.Cells["Mã Khách Hàng"].Value.ToString();
                txtCusName.Text = row.Cells["Họ Tên"].Value.ToString();
                dtDayOfBirth.Text = row.Cells["Ngày Sinh"].Value.ToString();
                txtCusPhone.Text = row.Cells["Số Điện Thoại"].Value.ToString();
                cbxCusSex.Text = row.Cells["Giới Tính"].Value.ToString();
                txtCusAddress.Text = row.Cells["Địa Chỉ"].Value.ToString();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text.Trim().Equals("") || dtDayOfBirth.Text.Trim().Equals("") ||
                txtCusPhone.Text.Trim().Equals("") || txtCusAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!");
            }
            else if (cbxCusSex.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính khách hàng!");
            }
            else if (!regex.checkPhoneNumber(txtCusPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!");
            }
            else
            {
                String id = txtCusID.Text, cusname = txtCusName.Text, dob = dtDayOfBirth.Text, phone = txtCusPhone.Text, gender = cbxCusSex.SelectedItem.ToString(), add = txtCusAddress.Text;
                customer_DTO cus = new customer_DTO(id,cusname,dob,phone,gender,add);
                if (cus_BUS.updateCustomer(cus))
                {
                    MessageBox.Show("Sửa khách hàng thành công!");
                    resetData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = txtCusID.Text;
            if (cus_BUS.deleteCustomer(id))
            {
                MessageBox.Show("Xóa khách hàng thành công!");
                resetData();
            }
        }
        public void resetData()
        {
            txtCusID.Text = "";
            txtCusName.Text = "";
            dtDayOfBirth.Text = "1/1/2000";
            cbxCusSex.Text = "";
            txtCusPhone.Text = "";
            txtCusAddress.Text = "";
            setTableCustomer();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
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

                worksheet.Name = "Customer Table";


                for (int i = 0; i < tableCustomer.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = tableCustomer.Columns[i].HeaderText;
                }

                for (int i = 0; i < tableCustomer.RowCount; i++)
                {
                    for (int j = 0; j < tableCustomer.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableCustomer.Rows[i].Cells[j].Value.ToString();
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
                ToExcel(tableCustomer, saveFileDialog.FileName);
            }
        }

        private void picExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(getName, getId);
            main.ShowDialog();
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
        }
    }
}
