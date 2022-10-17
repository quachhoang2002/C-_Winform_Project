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

        public Boolean checkLogin(String userName, String password)
        {
            return acc_DAO.checkLogin(userName, password);
        }

        public employee_DTO getEmpName(String userName, String password)
        {
            return acc_DAO.getInfoEmp(userName, password);
        }
    }
}
