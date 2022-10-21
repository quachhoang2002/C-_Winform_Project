using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class account_BUS
    {
        account_DAO acc_DAO = new account_DAO();

        public int checkLogin(String userName, String password)
        {
            return acc_DAO.checkLogin(userName, password);
        }

        public employee_DTO getEmpName(String userName, String password)
        {
            return acc_DAO.getInfoEmp(userName, password);
        }

        public List<account_DTO> getAllAccount()
        {
            return acc_DAO.getAllAccount();
        }

        public void AddAccount(account_DTO account)
        {
            if (acc_DAO.AddAccount(account))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
        }

        public void DeleteAccount(String ID)
        {
            if (acc_DAO.DeleteAccount(ID))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
        }

        public List<account_DTO> SearchAccount(String column, String data)
        {
            return acc_DAO.SearchAccount(column, data);
        }

        public void UpdateAcc(account_DTO account)
        {
            if (acc_DAO.UpdateAccount(account))
            { 
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
        }

    }
}
