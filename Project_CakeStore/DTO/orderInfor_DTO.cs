using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class orderInfor_DTO
    {
        private String cakeID;
        private String cakeName;
        private int unitPrice;
        private int quantity;
        private int Price;

        public orderInfor_DTO(String cakeID, String cakeName, int unitPrice, int quantity, int Price)
        {
            this.cakeID = cakeID;
            this.cakeName = cakeName;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.Price = Price;
        }

        public String getCakeID()
        {
            return cakeID;
        }

        public void setCakeID(String cakeID)
        {
            this.cakeID = cakeID;
        }

        public String getCakeName()
        {
            return cakeName;
        }

        public void setCakeName(String cakeName)
        {
            this.cakeName = cakeName;
        }

        public int getUnitPrice()
        {
            return unitPrice;
        }

        public void setUnitPrice(int unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int getPrice()
        {
            return Price;
        }

        public void setPrice(int Price)
        {
            this.Price = Price;
        }
    }
}
