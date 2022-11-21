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

        public Boolean addSupplier(supplier_DTO supp)
        {
            return sup_DAO.addSupplier(supp);
        }

        public Boolean deleteSupplier(supplier_DTO supp)
        {
            return sup_DAO.deleteSupplier(supp);
        }

        public Boolean updateSupplier(supplier_DTO supp)
        {
            return sup_DAO.updateSupplier(supp);
        }

        public List<supplier_DTO> searchSupplierByID(String data)
        {
            return sup_DAO.searchSupplierByID(data);
        }

        public List<supplier_DTO> searchSupplierByName(String data)
        {
            return sup_DAO.searchSupplierByName(data);
        }

        /*public List<supplier_DTO> SearchNewestSuppID()
        {
            return sup_DAO.SearchNewestSuppID();
        }*/
    }
}
