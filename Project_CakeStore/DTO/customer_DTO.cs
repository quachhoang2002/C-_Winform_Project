using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class customer_DTO
    {
        private String cusID;
        private String cusName;
        private String DoB;
        private String phone;
        private String sex;
        private String address;
        
        public customer_DTO()
        {

        }

        public customer_DTO(String cusID, String cusName, String DoB, String phone, String sex, String address)
        {
            this.cusID = cusID;
            this.cusName = cusName;
            this.DoB = DoB;
            this.phone = phone;
            this.sex = sex;
            this.address = address;
        }

        public String getCusID()
        {
            return cusID;
        }

        public void setCusID(String cusID)
        {
            this.cusID = cusID;
        }

        public String getCusName()
        {
            return cusName;
        }

        public void setCusName(String cusName)
        {
            this.cusName = cusName;
        }

        public String getDoB()
        {
            return DoB;
        }

        public void setDoB(String DoB)
        {
            this.DoB = DoB;
        }

        public String getPhone()
        {
            return phone;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        public String getSex()
        {
            return sex;
        }

        public void setSex(String sex)
        {
            this.sex = sex;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }
    }
}
