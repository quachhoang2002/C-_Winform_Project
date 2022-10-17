using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class orderDetail_DTO
    {
        private String orderID;
        private String cakeID;
        private int quantity;
        private int price;

        public orderDetail_DTO(string orderID, string cakeID, int quantity, int price)
        {
            this.orderID = orderID;
            this.cakeID = cakeID;
            this.quantity = quantity;
            this.price = price;
        }   

        public String getOrderID()
        {
            return this.orderID;
        }

        public String getCakeID()
        {
            return this.cakeID;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public int getPrice()
        {
            return this.price;
        }

        public void setOrderID(String orderID)
        {
            this.orderID = orderID;
        }

        public void setCakeID(String cakeID)
        {
            this.cakeID = cakeID;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }
    }
}
