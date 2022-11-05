using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class ReportImport_DTO
    {
        private string cakeName;
        private string cakeType;
        private int quantity;
        private int turnOver;


        public ReportImport_DTO(string cakeName, string cakeType, int quantity, int turnOver)
        {
            this.cakeName = cakeName;
            this.cakeType = cakeType;
            this.quantity = quantity;
            this.turnOver = turnOver;
        }

        public string CakeName { get => cakeName; set => cakeName = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int TurnOver { get => turnOver; set => turnOver = value; }




    }


}
