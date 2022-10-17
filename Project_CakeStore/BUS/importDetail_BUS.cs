using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class importDetail_BUS
    {
        private importDetail_DAO impDe_DAO = new importDetail_DAO();

        public Boolean checkImportDetail(String importID, String cakeID)
        {
            return impDe_DAO.checkimportDetail(importID, cakeID);
        }

        public Boolean addimportDetail(importDetail_DTO impDe)
        {
            return impDe_DAO.addImportDetail(impDe);
        }

        public Boolean updateImportDetail(importDetail_DTO impDe)
        {
            return impDe_DAO.updateImportDetail(impDe);
        }

    }
}
