using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class supplier_DTO
    {
        private String suppID;
        private String suppName;
        private String address;

        public supplier_DTO(string suppID, string suppName, string address)
        {
            this.suppID = suppID;
            this.suppName = suppName;
            this.address = address;
        }

        public String getSuppID()
        {
            return this.suppID;
        }

        public String getSuppName()
        {
            return this.suppName;
        }

        public String getAddress()
        {
            return this.address;
        }

        public void setSuppID(String suppID)
        {
            this.suppID = suppID;
        }

        public void setSuppName(String suppName)
        {
            this.suppName = suppName;
        }

        public void setAddress(String address) 
        { 
            this.address = address; 
        }
    }
}
