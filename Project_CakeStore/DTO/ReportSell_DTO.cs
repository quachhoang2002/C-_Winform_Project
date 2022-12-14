using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class ReportSell_DTO
    {

        private string cakeId;
        private string cakeName;
        private string cakeType;
        private string date;
        private string customer;
        private int quantity;
        private int totalPrice;

        public ReportSell_DTO()
        {

        }


        public string CakeId { get => cakeId; set => cakeId = value; }
        public string CakeName { get => cakeName; set => cakeName = value; }
        public string Customer { get => customer; set => customer = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }
        public string Date { get => date; set => date = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }


    }
}
