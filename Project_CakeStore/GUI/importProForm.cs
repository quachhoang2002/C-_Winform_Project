using Project_CakeStore.BUS;
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
    public partial class importProForm : Form
    {
        cake_BUS cakeBUS = new cake_BUS();
        category_BUS cate_BUS = new category_BUS();
        supplier_BUS supp_BUS = new supplier_BUS();
        import_BUS importBUS = new import_BUS();
        importDetail_BUS impDe_BUS = new importDetail_BUS();
        String getName = "";
        String getId = "";
        int finalPrice = 0;
        int priceOneRow = 0;
        public importProForm(String name, String id)
        {
            getName = name;
            getId = id;
            InitializeComponent();
            txtAccName.Text = getName + "(" + getId + ")";
            setTableCake();
            setCmbCategory();
            setCmbSupplier();
        }

        //Ham load table Cake
        public void setTableCake()
        {
            List<cake_DTO> listCake = cakeBUS.getAllCakeName();
            tableCake.ColumnCount = 5;
            tableCake.Columns[0].Name = "Mã";
            tableCake.Columns[1].Name = "Tên";
            tableCake.Columns[2].Name = "Loại";
            tableCake.Columns[3].Name = "Đơn giá";
            tableCake.Columns[4].Name = "Số lượng";

            for (int i = 0; i < listCake.Count; i++)
            {
                cake_DTO cake = listCake.ElementAt(i);
                tableCake.Rows.Add(cake.getCakeID()
                    , cake.getCakeName()
                    , cake.getCategoryID()
                    , cake.getUnitPrice()
                    , cake.getQuantity());
            }
        }

        //Ham load combobox category
        public void setCmbCategory()
        {
            List<category_DTO> listCate = cate_BUS.getAllCategory();

            for (int i = 0; i < listCate.Count; i++)
            {
                category_DTO cate = listCate.ElementAt(i);
                String cmbItem = cate.getCategoryName() + "(" + cate.getCategoryID() + ")";
                cmbCateId.Items.Add(cmbItem);
            }
        }

        //Ham load combobox supplier
        public void setCmbSupplier()
        {
            List<supplier_DTO> listSupp = supp_BUS.getAllSupp();

            for (int i = 0; i < listSupp.Count; i++)
            {
                supplier_DTO supp = listSupp.ElementAt(i);
                String cmbItem = supp.getSuppName() + "(" + supp.getSuppID() + ")";
                cmbSuppName.Items.Add(cmbItem);
            }
        }

        //Ham them phieu nhap
        public void addImport()
        {
            List<supplier_DTO> supList = supp_BUS.getAllSupp();
            supplier_DTO sup = supList.ElementAt(cmbSuppName.SelectedIndex);
            String importID = txtImportID.Text;
            String suppid = sup.getSuppID();
            String empID = getId;

            import_DTO imp = new import_DTO(importID, suppid, txtDate.Text, empID);
            if (importBUS.addImport(imp))
            {
                MessageBox.Show("Them thanh cong");

            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }

        //Ham them chi tiet phieu nhap
        public void addImportDetail()
        {
            for(int i = 0; i < tableImport.Rows.Count; i++)
            {
                String importID = txtImportID.Text;
                String cakeID = tableImport.Rows[i].Cells[0].Value.ToString();
                int quantity = int.Parse(tableImport.Rows[i].Cells[3].Value.ToString());
                int price = int.Parse(tableImport.Rows[i].Cells[5].Value.ToString());

                String cateID = tableImport.Rows[i].Cells[1].Value.ToString();
                String cakeName = tableImport.Rows[i].Cells[2].Value.ToString();
                int unitPrice = int.Parse(tableImport.Rows[i].Cells[4].Value.ToString());


                Boolean tmp = impDe_BUS.checkImportDetail(importID, cakeID);
                Boolean checkCakeid = cakeBUS.checkCakeID(cakeID);
                if(tmp == true)
                {
                    importDetail_DTO impDe = new importDetail_DTO(importID,cakeID,quantity,price);
                    Boolean a = impDe_BUS.updateImportDetail(impDe);
                    Boolean b = cakeBUS.updateQuantityPlus(cakeID,quantity);
                } 
                else
                {
                    if(checkCakeid == true)
                    {
                        importDetail_DTO impDe = new importDetail_DTO(importID, cakeID, quantity, price);
                        Boolean a = impDe_BUS.addimportDetail(impDe);
                        Boolean b = cakeBUS.updateQuantityPlus(cakeID, quantity);
                    }
                    else
                    {
                        cake_DTO cake = new cake_DTO(cakeID,cakeName,cateID,unitPrice,quantity,"");
                        importDetail_DTO impDe = new importDetail_DTO(importID, cakeID, quantity, price);
                        Boolean a = cakeBUS.addCake(cake);
                        Boolean b = impDe_BUS.addimportDetail(impDe);
                    }
                }

            }
        }

        public void updateQuantity()
        {
            int curIndex = tableCake.CurrentCell.RowIndex;
            if (int.Parse(tableCake.Rows[curIndex].Cells[4].Value.ToString()) >= 0)
            {
                int newQuantity = int.Parse(tableCake.Rows[curIndex].Cells[4].Value.ToString()) + int.Parse(txtOldQuantity.Text);
                tableCake.Rows[curIndex].Cells[4].Value = newQuantity.ToString();
            }
            else
            {
                MessageBox.Show("So luong san pham khong du, vui long nhap lai so luong");
            }
        }

        //Ham check regex old Quantity
        public Boolean checkOldQuantity(String oldQuantity)
        {
            Boolean check = false;
            String checkNum = @"(-)\d{0,9}";
            String checkChar = @"\D";
            Regex rg1 = new Regex(checkNum);
            Regex rg2 = new Regex(checkChar);
            if (rg1.IsMatch(oldQuantity) == false && rg2.IsMatch(oldQuantity) == false)
            {
                check = true;
            }
            else
            {
                MessageBox.Show("Sai format, vui long nhap lai");
                txtOldQuantity.Text = "";
            }
            return check;
        }

        //Ham check regen new Cake
        public Boolean checkNewCake(String cakeID, String cakeName, String unitPrice, String quantity)
        {
            Boolean check = false;
            String checkCakeID = @"(C)\d{0,9}";
            Regex rgCakeID = new Regex(checkCakeID);
            if (cakeID.Equals("") || cakeName.Equals("") || unitPrice.Equals(""))
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else if (cakeBUS.checkCakeID(cakeID) == false && rgCakeID.IsMatch(cakeID) && checkOldQuantity(unitPrice) && checkOldQuantity(quantity))
            {
                check = true;
            }
            else if (cakeBUS.checkCakeID(cakeID))
            {
                MessageBox.Show("Ma san pham da ton tai");
            }

            return check;
        }

        public Boolean checkImportID(String importID)
        {
            Boolean check = false;
            String checkImport = @"(PN)\d{0,9}";
            Regex rg = new Regex(checkImport);
            if (rg.IsMatch(importID) && importBUS.checkImportID(importID) == false)
            {
                check = true;
            }
            else
            {
                MessageBox.Show("Sai cu phap hoac trung ma, vui long nhap lai");
            }
            return check;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(getName, getId);
            mainForm.ShowDialog();
        }


        //Bat su kien click tung dong de lay thong tin san pham
        private void tableCake_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableCake.Rows[e.RowIndex];
                txtOldCakeId.Text = row.Cells["Mã"].Value.ToString();
                txtOldCakeName.Text = row.Cells["Tên"].Value.ToString();
                txtOldCateId.Text = row.Cells["Loại"].Value.ToString();
                txtOldPrice.Text = row.Cells["Đơn giá"].Value.ToString();
            }
        }

        //Bat su kien nut them san pham da co
        private void btnAddOldCake_Click(object sender, EventArgs e)
        {
            if (txtOldQuantity.Text.Equals(""))
            {
                MessageBox.Show("Vui long nhap so luong san pham");
            }
            else if(checkOldQuantity(txtOldQuantity.Text))
            {
                txtEmpName.Text = txtAccName.Text;
                txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

                //Set du lieu cho bang import
                int unitPrice = int.Parse(txtOldPrice.Text);
                int quantity = int.Parse(txtOldQuantity.Text);

                tableImport.ColumnCount = 6;
                tableImport.Columns[0].Name = "Mã";
                tableImport.Columns[1].Name = "Loại";
                tableImport.Columns[2].Name = "Tên";
                tableImport.Columns[3].Name = "Số lượng";
                tableImport.Columns[4].Name = "Đơn giá";
                tableImport.Columns[5].Name = "Thành tiền";

                int curIndex = tableCake.CurrentCell.RowIndex;
                
                    tableImport.Rows.Add(txtOldCakeId.Text
                        , txtOldCateId.Text
                        , txtOldCakeName.Text
                        , txtOldQuantity.Text
                        , txtOldPrice.Text
                        , (unitPrice * quantity).ToString());

                    //Tinh tong tien
                    int price = (unitPrice * quantity);
                    finalPrice = finalPrice + price;
                    txtPriceAll.Text = finalPrice.ToString();
                    txtPricePro.Text = finalPrice.ToString();

                    //Cap nhat lai bang sp
                    updateQuantity();

                

            }

        }

        //Bat su kien them san pham moi
        private void btnAddNewCake_Click(object sender, EventArgs e)
        {
            if (txtNewQuantity.Text.Equals(""))
            {
                MessageBox.Show("Vui long nhap so luong san pham");
            }
            else if(checkNewCake(txtNewCakeId.Text, txtNewCakeName.Text, txtNewPrice.Text, txtNewQuantity.Text))
            {
                txtEmpName.Text = txtAccName.Text;
                txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

                //Set du lieu cho bang import
                int unitPrice = int.Parse(txtNewPrice.Text);
                int quantity = int.Parse(txtNewQuantity.Text);
                List<category_DTO> cateList = cate_BUS.getAllCategory();
                category_DTO cate = cateList.ElementAt(cmbCateId.SelectedIndex);
                String cateid = cate.getCategoryID();

                tableImport.ColumnCount = 6;
                tableImport.Columns[0].Name = "Mã";
                tableImport.Columns[1].Name = "Loai";
                tableImport.Columns[2].Name = "Tên";
                tableImport.Columns[3].Name = "Số lượng";
                tableImport.Columns[4].Name = "Đơn giá";
                tableImport.Columns[5].Name = "Thành tiền";
                tableImport.Rows.Add(txtNewCakeId.Text
                    , cateid
                    , txtNewCakeName.Text
                    , txtNewQuantity.Text
                    , txtNewPrice.Text
                    , (unitPrice * quantity).ToString());

                //Tinh tong tien
                int price = (unitPrice * quantity);
                finalPrice = finalPrice + price;
                txtPriceAll.Text = finalPrice.ToString();
                txtPricePro.Text = finalPrice.ToString();

            }

        }

        //Bat su kien nut xoa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int curIndex = tableImport.CurrentCell.RowIndex;
            priceOneRow = Convert.ToInt32(tableImport.Rows[curIndex].Cells[5].Value.ToString());
            finalPrice = finalPrice - priceOneRow;
            tableImport.Rows.RemoveAt(curIndex);
            txtPriceAll.Text = finalPrice.ToString();
            txtPricePro.Text = finalPrice.ToString();
        }

        //Bat su kien nut lam moi
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPriceAll.Text = "";
            txtPricePro.Text = "";
            txtDate.Text = "";
            finalPrice = 0;
            tableImport.Rows.Clear();
            tableCake.Rows.Clear();
            setTableCake();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (checkImportID(txtImportID.Text) && txtImportID.Text.Equals("") == false)
            {
                addImport();
                addImportDetail();
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
