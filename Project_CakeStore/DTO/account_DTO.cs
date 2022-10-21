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
        private int permission;

        public string AccID { get => accID; set => accID = value; }
        public string EmpID { get => empID; set => empID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Permission { get => permission; set => permission = value; }

        public account_DTO(string accID, string empID, string userName, string password, int permission)
        {
            this.AccID = accID;
            this.EmpID = empID;
            this.UserName = userName;
            this.Password = password;
            this.Permission = permission;
        }

    }   
}
