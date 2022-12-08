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
    public partial class sellForm : Form
    {
        private cake_BUS cake_BUS = new cake_BUS();
        private customer_BUS cus_BUS = new customer_BUS();
        private order_BUS orderBUS = new order_BUS();
        private orderDetail_BUS orde_BUS = new orderDetail_BUS();
        List<customer_DTO> list = new List<customer_DTO>();
        int finalPrice = 0;
        int priceOneRow = 0;
        String cusid = "";
        String empid = "";
        String empName = "";
        public sellForm(String name, String id)
        {
            InitializeComponent();
            setTableCake();
            setCmbCusName();
            empid = id;
            empName = name;
            txtAccName.Text = name + "("+id+")";

        }


        //Set du lieu bang Cake
        public void setTableCake()
        {
            tableCake.Rows.Clear();
            List<cake_DTO> list = cake_BUS.getAllCakeName();

            tableCake.ColumnCount = 5;
            tableCake.Columns[0].Name = "Mã";
            tableCake.Columns[1].Name = "Tên";
            tableCake.Columns[2].Name = "Loại";
            tableCake.Columns[3].Name = "Đơn giá";
            tableCake.Columns[4].Name = "Số lượng";

            for (int i= 0; i < list.Count; i++)
            {
                cake_DTO cake = list.ElementAt(i);
                tableCake.Rows.Add(cake.getCakeID()
                    , cake.getCakeName()
                    , cake.getCategoryID()
                    , cake.getUnitPrice()
                    , cake.getQuantity());
            }
        }

        //Set du lieu combobox khach hang
        public void setCmbCusName()
        {
            
            list = cus_BUS.getAllCusName();
            for (int i = 0; i < list.Count; i++)
            {
                customer_DTO cus = list.ElementAt(i);
                String cusName = cus.getCusName() + "(" + cus.getCusID() + ")";
                cmbCusName.Items.Add(cusName);
            }

            
        }

        //Ham cap nhat so luong banh
        public void updateQuantity()
        {
            int curIndex = tableCake.CurrentCell.RowIndex;
            if (int.Parse(tableCake.Rows[curIndex].Cells[4].Value.ToString()) - int.Parse(txtQuantity.Text) >= 0)
            {
                int newQuantity = int.Parse(tableCake.Rows[curIndex].Cells[4].Value.ToString()) - int.Parse(txtQuantity.Text);
                tableCake.Rows[curIndex].Cells[4].Value = newQuantity.ToString();
            }
            else
            {
                MessageBox.Show("So luong san pham khong du, vui long nhap lai so luong");
            }
        }

        //Ham them hoa don
        public Boolean addOrderClick()
        {
            Boolean check = false;
            order_DTO order = new order_DTO(txtOrderId.Text
                , cusid
                , empid
                , txtDate.Text);

            if (orderBUS.addOrder(order))
            {
                check = true;
            }
            return check;
        }

        //Ham them chi tiet hoa don
        public void addOrderDetailClick()
        {

            for(int i =0; i< tableOrder.Rows.Count; i++)
            {
                String orderID = txtOrderId.Text;
                String cakeID = tableOrder.Rows[i].Cells[0].Value.ToString();
                int quantity = int.Parse(tableOrder.Rows[i].Cells[2].Value.ToString());
                int price = int.Parse(tableOrder.Rows[i].Cells[4].Value.ToString());
                Boolean tmp = orde_BUS.checkOrderDetail(orderID, cakeID);
                if(tmp == false)
                {
                    orderDetail_DTO cthd = new orderDetail_DTO(orderID, cakeID, quantity, price);
                    Boolean a = orde_BUS.addOrderDetail(cthd);
                }
                else
                {
                    orderDetail_DTO cthd = new orderDetail_DTO(orderID, cakeID, quantity, price);
                    Boolean a = orde_BUS.updateOrderDetail(cthd);
                }
            }

        }

        public void updateQuantityCake()
        {
            List<orderDetail_DTO> list = orde_BUS.getOrderDetail(txtOrderId.Text);

            for(int i = 0;i<list.Count; i++)
            {
                orderDetail_DTO cthd = list[i];
                Boolean n = cake_BUS.updateQuantityCake(cthd.getCakeID(), cthd.getQuantity());
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(empName, empid);
            mainForm.ShowDialog();
        }

        //Ham check regex Quantity
        public Boolean checkQuantity(String quantity)
        {
            Boolean check = false;
            String checkNum = @"(-)\d{0,9}";
            String checkChar = @"\D";
            System.Text.RegularExpressions.Regex rg1 = new System.Text.RegularExpressions.Regex(checkNum);
            System.Text.RegularExpressions.Regex rg2 = new System.Text.RegularExpressions.Regex(checkChar);
            if (rg1.IsMatch(quantity) == false && rg2.IsMatch(quantity) == false)
            {
                check = true;
            }
            else
            {
                MessageBox.Show("Sai format, vui long nhap lai so luong");
                txtQuantity.Text = "";
            }
            return check;
        }

        //Ham check regex OrderID
        public Boolean checkOrderID(String orderID)
        {
            Boolean check = false;
            String checkOrder = @"(HD)\d{0,9}";
            System.Text.RegularExpressions.Regex rg = new System.Text.RegularExpressions.Regex(checkOrder);
            if(rg.IsMatch(orderID) && orderBUS.checkOrder(orderID) == false && orderID.Equals("") == false)
            {
                check = true;
            }
            else
            {
                MessageBox.Show("Ma hoa don khong dung cu phap hoac bi trung, vui long nhap lai");
            }
            return check;
        }

        //Ham bat su kien click tung dong de lay thong tin san pham
        private void tableCake_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = tableCake.Rows[e.RowIndex];
                txtCakeId.Text = row.Cells["Mã"].Value.ToString();
                txtCakeName.Text = row.Cells["Tên"].Value.ToString();
                txtCateId.Text = row.Cells["Loại"].Value.ToString();
                txtPrice.Text = row.Cells["Đơn giá"].Value.ToString();
            }
        }


        //Bat su kien nut "Them"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Equals(""))
            {
                MessageBox.Show("Vui long nhap so luong san pham muon mua");
            }
            else if(checkQuantity(txtQuantity.Text))
            {
                txtEmpName.Text = txtAccName.Text;
                txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

                //Set du lieu cho bang hoa don
                int unitPrice = int.Parse(txtPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);

                tableOrder.ColumnCount = 5;
                tableOrder.Columns[0].Name = "Mã";
                tableOrder.Columns[1].Name = "Tên";
                tableOrder.Columns[2].Name = "Số lượng";
                tableOrder.Columns[3].Name = "Đơn giá";
                tableOrder.Columns[4].Name = "Thành tiền";

                int curIndex = tableCake.CurrentCell.RowIndex;
                if (int.Parse(tableCake.Rows[curIndex].Cells[4].Value.ToString()) >= int.Parse(txtQuantity.Text))
                {
                    tableOrder.Rows.Add(txtCakeId.Text
                        , txtCakeName.Text
                        , txtQuantity.Text
                        , txtPrice.Text
                        , (unitPrice * quantity).ToString());

                    //Tinh tong tien
                    int price = (unitPrice * quantity);
                    finalPrice = finalPrice + price;
                    txtPriceAll.Text = finalPrice.ToString();
                    txtPricePro.Text = finalPrice.ToString();

                    //Cap nhat lai bang sp
                    updateQuantity();

                }
                else
                {
                    MessageBox.Show("So luong san pham khong du, vui long nhap lai so luong");
                }
 
            }
        }

        //Bat su kien nut "Lam moi"
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPriceAll.Text = "";
            txtPricePro.Text = "";
            txtDate.Text = "";
            finalPrice = 0;
            tableOrder.Rows.Clear();
            tableCake.Rows.Clear();
            setTableCake();
            
        }


        //Bat su kien nut "Xoa"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            int curIndex = tableOrder.CurrentCell.RowIndex;
            priceOneRow = Convert.ToInt32(tableOrder.Rows[curIndex].Cells[4].Value.ToString());
            finalPrice = finalPrice - priceOneRow;
            tableOrder.Rows.RemoveAt(curIndex);
            txtPriceAll.Text = finalPrice.ToString();
            txtPricePro.Text = finalPrice.ToString();

        }

        //Bat su kien nut "Thanh toan"
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (checkOrderID(txtOrderId.Text))
            {
                customer_DTO ctm = list.ElementAt(cmbCusName.SelectedIndex);
                cusid = ctm.getCusID();
                if (addOrderClick())
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
                addOrderDetailClick();
                updateQuantityCake();
                setTableCake();
            }

        }

    }
}
