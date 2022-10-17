using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class orderInfor_BUS
    {
        private orderInfor_DAO orderInforDAO = new orderInfor_DAO();

        public List<orderInfor_DTO> getAllOrderInfor(String orderID, String cusID, String empID)
        {
            return orderInforDAO.getAllOrderInfor(orderID, cusID, empID);
        }

    }
}
