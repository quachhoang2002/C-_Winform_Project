using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class supplier_BUS
    {
        private supplier_DAO sup_DAO = new supplier_DAO();

        public List<supplier_DTO> getAllSupp()
        {
            return sup_DAO.getAllSupp();
        }
    }
}
