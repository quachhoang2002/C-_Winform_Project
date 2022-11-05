using Project_CakeStore.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class Report_BUS
    {
        private Report_DAO reportDao = new Report_DAO();

        public int totalEmployee()
        {
            return reportDao.totalEmployee();
        }

        public int totalCustomer()
        {
            return reportDao.totalCustomer();
        }

        public int totalCake()
        {
            return reportDao.totalCake();
        }

        public int totalOrder()
        {
            return reportDao.totalOrder();
        }

        public int totalManufactor()
        {
            return reportDao.totalManufactor();
        }
    }

    // public static int totalEmployee = reportDao.totalEmployee();
    // public static int totalCustomer = reportDao.totalCustomer();
    //  public static int totalSupplier = reportDao.totalCake();
    // public static int totalProduct = reportDao.totalOrder();
}

