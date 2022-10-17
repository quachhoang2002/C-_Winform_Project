using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class import_BUS
    {
        private import_DAO import_DAO = new import_DAO();

        public List<import_DTO> getAllImport()
        {
            return import_DAO.getAllImport();
        }

        public Boolean addImport(import_DTO imp)
        {
            return import_DAO.addImport(imp);
        }

        public List<import_DTO> searchImport(String column, String data)
        {
            return import_DAO.searchImport(column, data);
        }

        public List<orderInfor_DTO> getAllImportInfor(String importID, String suppID, String empID)
        {
            return import_DAO.getAllImportInfor(importID, suppID, empID);
        }
    }
}
