using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class employee_BUS
    {
        private employee_DAO emp_DAO = new employee_DAO();
        public List<employee_DTO> getAllEmployee()
        {
            return emp_DAO.getAllEmployee();
        }

        public Boolean addEmployee(employee_DTO emp)
        {
            return emp_DAO.addEmployee(emp);
        }

        public Boolean deleteEmployee(String id)
        {
            return emp_DAO.deleteEmployee(id);
        }

        public Boolean updateEmployee(employee_DTO emp)
        {
            return emp_DAO.updateEmployee(emp);
        }

       
        public List<employee_DTO> searchEmployeeByID(String data)
        {
            return emp_DAO.searchEmployeeByID(data);
        }

        public List<employee_DTO> searchEmployeeByName(String data)
        {
            return emp_DAO.searchEmployeeByName(data);
        }

        public List<employee_DTO> SearchNewestEmpID()
        {
            return emp_DAO.SearchNewestEmpID();
        }
    }
}
