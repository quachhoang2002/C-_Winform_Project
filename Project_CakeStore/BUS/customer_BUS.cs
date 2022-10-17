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
    }
}
