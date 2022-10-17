using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class account_DTO
    {
        private String accID;
        private String empID;
        private String userName;
        private String password;

        public account_DTO(String accID, String empID, String userName, String password)
        {
            this.accID = accID;
            this.empID = empID;
            this.userName = userName;
            this.password = password;
        }

        public String getAccID()
        {
            return accID;
        }

        public void setAccID(String accID)
        {
            this.accID = accID;
        }

        public String getEmpID()
        {
            return empID;
        }

        public void setEmpID(String empID)
        {
            this.empID = empID;
        }

        public String getUserName()
        {
            return userName;
        }

        public void setUserName(String userName)
        {
            this.userName = userName;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }
    }
}
