using OfficeOpenXml;
using Project_CakeStore.BUS;
using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CakeStore.GUI
{
    public partial class supplierForm : Form
    {
        private supplier_BUS supp_BUS = new supplier_BUS();
        RegexPattern regex = new RegexPattern();
        String getName = "";
        String getId = "";
        public supplierForm(String name, String id)
        {
            InitializeComponent();
            getName = name;
            getId = id;
            txtSuppID.Enabled = false;
            txtAccName.Text = getName + "(" + getId + ")";
            setTableSupplier();
            setCbxSearch();
        }
        public void setTableSupplier()
        {
            tableSupplier.Rows.Clear();
            tableSupplier.ColumnCount = 6;
            tableSupplier.Columns[0].Name = "Mã Nhà Cung Cấp";
            tableSupplier.Columns[1].Name = "Tên Nhà Cung Cấp";
            tableSupplier.Columns[2].Name = "Địa Chỉ";
            tableSupplier.Columns[3].Name = "Email";
            tableSupplier.Columns[4].Name = "Số Điện Thoại";
            tableSupplier.Columns[5].Name = "Người Liên Hệ";
            List<supplier_DTO> listSupplier = supp_BUS.getAllSupp();
            for (int i = 0; i < listSupplier.Count; i++)
            {
                supplier_DTO emp = listSupplier[i];
                tableSupplier.Rows.Add(emp.getSuppID()
                    , emp.getSuppName()
                    , emp.getAddress()
                    , emp.getEmail()
                    , emp.getPhone()
                    , emp.getContactPerson());

            }
        }
        public void setCbxSearch()
        {
            cbxSearch.Items.Add("Tất cả");
            cbxSearch.Items.Add("Mã nhà cung cấp");
            cbxSearch.Items.Add("Tên nhà cung cấp");

        }

        public void setTableSearchByID(String data)
        {
            tableSupplier.Rows.Clear();
            tableSupplier.ColumnCount = 6;
            tableSupplier.Columns[0].Name = "Mã Nhà Cung Cấp";
            tableSupplier.Columns[1].Name = "Tên Nhà Cung Cấp";
            tableSupplier.Columns[2].Name = "Địa Chỉ";
            tableSupplier.Columns[3].Name = "Email";
            tableSupplier.Columns[4].Name = "Số Điện Thoại";
            tableSupplier.Columns[5].Name = "Người Liên Hệ";
            List<supplier_DTO> listSupplierSearch = supp_BUS.searchSupplierByID(data);
            for (int i = 0; i < listSupplierSearch.Count; i++)
            {
                supplier_DTO supp = listSupplierSearch[i];
                String SuppID = supp.getSuppID();
                String SuppName = supp.getSuppName();
                String SuppAddress = supp.getAddress();
                String SuppEmail = supp.getEmail();
                String SuppPhone = supp.getPhone();
                String SuppCP = supp.getContactPerson();
                tableSupplier.Rows.Add(SuppID, SuppName, SuppAddress, SuppEmail, SuppPhone, SuppCP);
            }

        }
        public void setTableSearchByName(String data)
        {
            tableSupplier.Rows.Clear();
            tableSupplier.ColumnCount = 6;
            tableSupplier.Columns[0].Name = "Mã Nhà Cung Cấp";
            tableSupplier.Columns[1].Name = "Tên Nhà Cung Cấp";
            tableSupplier.Columns[2].Name = "Địa Chỉ";
            tableSupplier.Columns[3].Name = "Email";
            tableSupplier.Columns[4].Name = "Số Điện Thoại";
            tableSupplier.Columns[5].Name = "Người Liên Hệ";
            List<supplier_DTO> listSupplierSearch = supp_BUS.searchSupplierByName(data);
            for (int i = 0; i < listSupplierSearch.Count; i++)
            {
                supplier_DTO supp = listSupplierSearch[i];
                String SuppID = supp.getSuppID();
                String SuppName = supp.getSuppName();
                String SuppAddress = supp.getAddress();
                String SuppEmail = supp.getEmail();
                String SuppPhone = supp.getPhone();
                String SuppCP = supp.getContactPerson();
                tableSupplier.Rows.Add(SuppID, SuppName, SuppAddress, SuppEmail, SuppPhone, SuppCP);
            }
        }
        public void resetData()
        {
            txtSuppID.Enabled = false;
            txtSuppID.Text = "";
            txtSuppName.Text = "";
            txtSuppEmail.Text = "";
            txtSuppAddress.Text = "";
            txtSuppPhone.Text = "";
            txtSuppCP.Text = "";
            setTableSupplier();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSuppName.Text.Trim().Equals("") || txtSuppAddress.Text.Trim().Equals("") ||
                txtSuppEmail.Text.Trim().Equals("") || txtSuppCP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp!");
            }
            else if (!regex.checkPhoneNumber(txtSuppPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!");
            }
            else
            {
                String id = "";
                String suppname = txtSuppName.Text;
                String add = txtSuppAddress.Text;
                String email = txtSuppEmail.Text;
                String phone = txtSuppPhone.Text;
                String contact = txtSuppCP.Text;
                supplier_DTO supp = new supplier_DTO(id, suppname, add, email, phone, contact);
                if (supp_BUS.addSupplier(supp))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
                    resetData();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtSuppName.Text.Trim().Equals("") || txtSuppAddress.Text.Trim().Equals("") ||
                txtSuppEmail.Text.Trim().Equals("") || txtSuppCP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp!");
            }
            else if (!regex.checkPhoneNumber(txtSuppPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!");
            }
            else
            {
                String id = txtSuppID.Text;
                String suppname = txtSuppName.Text;
                String add = txtSuppAddress.Text;
                String email = txtSuppEmail.Text;
                String phone = txtSuppPhone.Text;
                String contact = txtSuppCP.Text;
                supplier_DTO supp = new supplier_DTO(id, suppname, add, email, phone, contact);
                if (supp_BUS.updateSupplier(supp))
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công!");
                    resetData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            supplier_DTO supp = new supplier_DTO();
            supp.setSuppID(txtSuppID.Text);
            if (supp_BUS.deleteSupplier(supp))
            {
                MessageBox.Show("Xóa nhà cung cấp thành công!");
                resetData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtSearch.Text;
            int index = cbxSearch.SelectedIndex;

            if (index == 0)
            {
                setTableSupplier();
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

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void tableSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableSupplier.Rows[e.RowIndex];
                txtSuppID.Text = row.Cells["Mã Nhà Cung Cấp"].Value.ToString();
                txtSuppName.Text = row.Cells["Tên Nhà Cung Cấp"].Value.ToString();
                txtSuppAddress.Text = row.Cells["Địa Chỉ"].Value.ToString();
                txtSuppEmail.Text = row.Cells["Email"].Value.ToString();
                txtSuppPhone.Text = row.Cells["Số Điện Thoại"].Value.ToString();
                txtSuppCP.Text = row.Cells["Người Liên Hệ"].Value.ToString();

            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(getName, getId);
            main.ShowDialog();
        }

        private void btnOutExcel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
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

                worksheet.Name = "Supplier Table";


                for (int i = 0; i < tableSupplier.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = tableSupplier.Columns[i].HeaderText;
                }

                for (int i = 0; i < tableSupplier.RowCount; i++)
                {
                    for (int j = 0; j < tableSupplier.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableSupplier.Rows[i].Cells[j].Value.ToString();
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
                ToExcel(tableSupplier, saveFileDialog.FileName);
            }
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
        }
    }
}
