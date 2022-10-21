﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_CakeStore.BUS;
using Project_CakeStore.DTO;

namespace Project_CakeStore.GUI
{
    public partial class accountForm : Form
    {
        private string getName;
        private string getId;
        private account_BUS accountBus=new account_BUS();

        public accountForm(string getName, string getId)
        {
            InitializeComponent();
            this.getName = getName;
            this.getId = getId;
            txtAccName1.Text = getName + "(" + getId + ")";
            SetTableAccount();
            SetCmbTypeSearch();
            SetCmbEmployeeID();
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
                tableAccount.Rows.Add(account.AccID, account.EmpID, account.UserName,account.Password,account.Permission);
            }
        }

        public void setTableSearch(String column, String data)
        {
            tableAccount.Rows.Clear();
            List<account_DTO> list = accountBus.SearchAccount(column, data);
            for (int i = 0; i < list.Count; i++)
            {
                account_DTO account = list[i];
                tableAccount.Rows.Add(account.AccID, account.EmpID, account.UserName, account.Password, account.Permission);
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
            txtPermission.Text = "";
            cmbEmpID.SelectedIndex = 0;
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
                txtPermission.Text = row.Cells["Quyền"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String AccID = txtAccID.Text, EmpID="nv1",AccName = txtAccName2.Text,Pass=txtPass.Text,Permission=txtPermission.Text;
            if (AccID.Length != 0&&AccName.Length!=0&&Pass.Length!=0&&Permission.Length!=0)
            {
                accountBus.UpdateAcc(new account_DTO(AccID,EmpID,AccName,Pass,Convert.ToInt32(Permission)));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String AccID = txtAccID.Text;
            if (AccID.Length != 0)
            {
                accountBus.DeleteAccount(AccID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String AccID = "", EmpID = "nv1", AccName = txtAccName2.Text, Pass = txtPass.Text, Permission = txtPermission.Text;
            if (AccName.Length != 0 && Pass.Length != 0 && Permission.Length != 0)
            {
                accountBus.AddAccount(new account_DTO(AccID, EmpID, AccName, Pass, Convert.ToInt32(Permission)));
            }
        }
    }


}