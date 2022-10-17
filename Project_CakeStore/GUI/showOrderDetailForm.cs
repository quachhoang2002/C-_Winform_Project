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
    public partial class showOrderDetailForm : Form
    {
        String getName = "";
        String getId = "";
        private orderInfor_BUS orderInforBUS = new orderInfor_BUS();
        public showOrderDetailForm(String name, String id, String orderID, String cusID, String empID, String date)
        {
            InitializeComponent();
            getId = id;
            getName = name;
            txtAccName.Text = getName +"("+getId+")";
            txtOrderId.Text = orderID;
            txtCus.Text = cusID;
            txtEmp.Text = empID;
            txtDate.Text = date;
            setTableShowInfo();
        }

        public void setTableShowInfo()
        {
            List<orderInfor_DTO> list = orderInforBUS.getAllOrderInfor(txtOrderId.Text, txtCus.Text, txtEmp.Text);
            tableShowInfo.ColumnCount = 5;
            tableShowInfo.Columns[0].Name = "Mã bánh";
            tableShowInfo.Columns[1].Name = "Tên bánh";
            tableShowInfo.Columns[2].Name = "Đơn giá";
            tableShowInfo.Columns[3].Name = "Số lượng";
            tableShowInfo.Columns[4].Name = "Thành tiền";

            for(int i = 0;i < list.Count; i++)
            {
                orderInfor_DTO infor = list[i];
                tableShowInfo.Rows.Add(infor.getCakeID()
                    , infor.getCakeName()
                    , infor.getUnitPrice().ToString()
                    , infor.getQuantity().ToString()
                    , infor.getPrice().ToString());
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderForm order = new orderForm(getName, getId);
            order.ShowDialog();
        }
    }
}
