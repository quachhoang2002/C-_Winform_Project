using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
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

        public List<ReportImport_DTO> reportImport(string start_time, string end_time)
        {
            return reportDao.ReportImport(start_time, end_time);
        }
    }

    // public static int totalEmployee = reportDao.totalEmployee();
    // public static int totalCustomer = reportDao.totalCustomer();
    //  public static int totalSupplier = reportDao.totalCake();
    // public static int totalProduct = reportDao.totalOrder();
}

