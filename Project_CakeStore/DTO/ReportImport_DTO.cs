using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class ReportImport_DTO
    {
        private string cakeId;
        private string cakeName;
        private string cakeType;
        private string date;
        private int quantity;
        private int totalPrice;

        public ReportImport_DTO()
        {
         
        }
        
        public ReportImport_DTO(string cakeId, string cakeName, string cakeType, string date, int quantity, int totalPrice)
        {
            this.cakeId = cakeId;
            this.cakeName = cakeName;
            this.cakeType = cakeType;
            this.date = date;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }

        public string CakeId { get => cakeId; set => cakeId = value; }
        public string CakeName { get => cakeName; set => cakeName = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }
        public string Date { get => date; set => date = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
   

    }


}
