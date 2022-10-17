using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class category_BUS
    {
        private category_DAO cate_DAO = new category_DAO();

        public List<category_DTO> getAllCategory()
        {
            return cate_DAO.getAllCategory();
        }
    }
}
