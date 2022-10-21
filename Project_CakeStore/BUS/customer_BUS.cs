using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class customer_BUS
    {
        private customer_DAO cus_DAO = new customer_DAO();

        public List<customer_DTO> getAllCusName()
        {
            return cus_DAO.getAllCusName();
        }

        public Boolean addCustomer(customer_DTO cus)
        {
            return cus_DAO.addCustomer(cus);
        }

        public Boolean updateCustomer(customer_DTO cus)
        {
            return cus_DAO.updateCustomer(cus);
        }

        public Boolean deleteCustomer(customer_DTO cus)
        {
            return cus_DAO.deleteCustomer(cus);
        }

        public List<customer_DTO> searchCustomerByID(String data)
        {
            return cus_DAO.searchCustomerByID(data);
        }

        public List<customer_DTO> searchCustomerByName(String data)
        {
            return cus_DAO.searchCustomerByName(data);
        }

        public List<customer_DTO> searchNewestCusID()
        {
            return cus_DAO.searchNewestCusID();
        }
    }
}
