using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class employee_DTO
    {
        private String empID;
        private String empName;
        private String position;
        private String sex;
        private String phone;
        private String address;

        public employee_DTO(String empID, String empName, String position, String sex, String phone, String address)
        {
            this.empID = empID;
            this.empName = empName;
            this.position = position;
            this.sex = sex;
            this.phone = phone;
            this.address = address;
        }

        public String getEmpID()
        {
            return empID;
        }

        public void setEmpID(String empID)
        {
            this.empID = empID;
        }

        public String getEmpName()
        {
            return empName;
        }

        public void setEmpName(String empName)
        {
            this.empName = empName;
        }

        public String getPosition()
        {
            return position;
        }

        public void setPosition(String position)
        {
            this.position = position;
        }

        public String getSex()
        {
            return sex;
        }

        public void setSex(String sex)
        {
            this.sex = sex;
        }

        public String getPhone()
        {
            return phone;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
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
