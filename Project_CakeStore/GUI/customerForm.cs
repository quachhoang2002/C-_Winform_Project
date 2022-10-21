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
    public partial class customerForm : Form
    {
        private customer_BUS cus_BUS = new customer_BUS();
        String getName = "";
        String getId = "";
        public customerForm(String name,String id)
        {
            InitializeComponent();
            getId = id;
            getName = name;
            txtAccName.Text = getName + "(" + getId + ")";
            setTableCustomer();
            setCbxSearch();
            loadNewestCusID();
        }

        public void loadNewestCusID()
        {
            List<customer_DTO> NewestCusID = cus_BUS.searchNewestCusID();
            for (int i = 0; i < NewestCusID.Count; i++)
            {
                customer_DTO cus = NewestCusID[i];
                txtNewestCusID.Text = cus.getCusID();
            }
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
            if (txtCusID.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!");
            }
            else if (txtCusName.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
            }
            else if (dtDayOfBirth.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn ngày sinh khách hàng!");
            }
            else if (txtCusPhone.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại của khách hàng!");
            }
            else if (cbxCusSex.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn giới tính khách hàng!");
            }
            else if (txtCusAddress.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ của khách hàng!");
            }
            else
            {
                customer_DTO cus = new customer_DTO();
                cus.setCusID(txtCusID.Text);
                cus.setCusName(txtCusName.Text);
                cus.setDoB(dtDayOfBirth.Text);
                cus.setPhone(txtCusPhone.Text);
                cus.setSex(cbxCusSex.Text);
                cus.setAddress(txtCusAddress.Text);
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
                txtCusID.Enabled = false;
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
            if (txtCusName.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
            }
            else if (dtDayOfBirth.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn ngày sinh khách hàng!");
            }
            else if (txtCusPhone.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại của khách hàng!");
            }
            else if (cbxCusSex.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn giới tính khách hàng!");
            }
            else if (txtCusAddress.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ của khách hàng!");
            }
            else
            {
                customer_DTO cus = new customer_DTO();
                cus.setCusID(txtCusID.Text);
                cus.setCusName(txtCusName.Text);
                cus.setDoB(dtDayOfBirth.Text);
                cus.setPhone(txtCusPhone.Text);
                cus.setSex(cbxCusSex.Text);
                cus.setAddress(txtCusAddress.Text);
                if (cus_BUS.updateCustomer(cus))
                {
                    txtCusID.Enabled = true;
                    MessageBox.Show("Sửa khách hàng thành công!");
                    resetData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            customer_DTO cus = new customer_DTO();
            cus.setCusID(txtCusID.Text);
            if (cus_BUS.deleteCustomer(cus))
            {
                MessageBox.Show("Xóa khách hàng thành công!");
                resetData();
            }
        }
        public void resetData()
        {
            txtCusID.Enabled = true;
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
    }
}
