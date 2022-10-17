using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class order_BUS
    {
        private order_DAO orderDAO = new order_DAO();

        public Boolean addOrder(order_DTO order)
        {
            return orderDAO.addOrder(order);
        }

        public List<order_DTO> getAllorder()
        {
            return orderDAO.getAllOrder();
        }

        public List<order_DTO> searchOrder(String column, String data)
        {
            return orderDAO.searchOrder(column, data);
        }

        public Boolean checkOrder(String orderID)
        {
            return orderDAO.checkOrder(orderID);
        }
    }
}
