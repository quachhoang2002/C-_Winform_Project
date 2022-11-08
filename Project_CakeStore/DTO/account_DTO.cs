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
        private Permission accountPermission;
       

        public string AccID { get => accID; set => accID = value; }
        public string EmpID { get => empID; set => empID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        internal Permission AccountPermission { get => accountPermission; set => accountPermission = value; }

        public account_DTO()
        {
            
        }

        public account_DTO(string accID, string empID, string userName, string password, Permission accountPermission)
        {
            this.accID = accID;
            this.empID = empID;
            this.userName = userName;
            this.password = password;
            this.accountPermission = accountPermission;
        }

        public enum Permission {None, Manager,Employee }
    }   
}
