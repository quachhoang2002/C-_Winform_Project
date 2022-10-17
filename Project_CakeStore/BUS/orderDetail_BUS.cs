using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class orderDetail_BUS
    {
        private orderDetail_DAO orde_DAO = new orderDetail_DAO();

        public List<orderDetail_DTO> getOrderDetail(String orderID)
        {
            return orde_DAO.getOrderDetail(orderID);
        }

        public Boolean checkOrderDetail(String orderID, String cakeID)
        {
            return orde_DAO.checkOrderDetail(orderID, cakeID);
        }

        public Boolean addOrderDetail(orderDetail_DTO orde)
        {
            return orde_DAO.addOrderDetail(orde);
        }

        public Boolean updateOrderDetail(orderDetail_DTO order)
        {
            return orde_DAO.updateOrderDetail(order);
        }
    }
}
