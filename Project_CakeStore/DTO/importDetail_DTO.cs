using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class importDetail_DTO
    {
        private String importID;
        private String cakeID;
        private int quantity;
        private int unitprice;

        public importDetail_DTO(String importID, String cakeID, int quantity, int unitprice)
        {
            this.importID = importID;
            this.cakeID = cakeID;
            this.quantity = quantity;
            this.unitprice = unitprice;
        }


        public String getImportID()
        {
            return importID;
        }

        public void setImportID(String importID)
        {
            this.importID = importID;
        }

        public String getCakeID()
        {
            return cakeID;
        }

        public void setCakeID(String cakeID)
        {
            this.cakeID = cakeID;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int getUnitprice()
        {
            return unitprice;
        }

        public void setUnitprice(int unitprice)
        {
            this.unitprice = unitprice;
        }
    }
}
