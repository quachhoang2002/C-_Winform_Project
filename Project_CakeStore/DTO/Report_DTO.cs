using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class Report_DTO 
    {
        private static int totalEmployee;
        private static int totalCustomer;
        private static int totalSupplier;
        private static int totalProduct;

        public static int TotalEmployee { get => totalEmployee; set => totalEmployee = value; }
        public static int TotalCustomer { get => totalCustomer; set => totalCustomer = value; }
        public static int TotalSupplier { get => totalSupplier; set => totalSupplier = value; }
        public static int TotalProduct { get => totalProduct; set => totalProduct = value; }
    }
    
    
}
