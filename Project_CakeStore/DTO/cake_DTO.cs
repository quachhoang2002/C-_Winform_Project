using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class cake_DTO
    {
        private String cakeID;
        private String cakeName;
        private String categoryID;
        private int unitPrice;
        private int quantity;
        private String img;

        public cake_DTO(String cakeID, String cakeName, String categoryID, int unitPrice, int quantity, String img)
        {
            this.cakeID = cakeID;
            this.cakeName = cakeName;
            this.categoryID = categoryID;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.img = img;
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

        public String getCategoryID()
        {
            return categoryID;
        }

        public void setCategoryID(String categoryID)
        {
            this.categoryID = categoryID;
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

        public String getImg()
        {
            return img;
        }

        public void setImg(String img)
        {
            this.img = img;
        }
    }
}
