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

        public Boolean addCate(category_DTO cate)
        {
            return cate_DAO.addCate(cate);
        }

        public Boolean deleteCate(String cateID)
        {
            return cate_DAO.deleteCate(cateID);
        }

        public Boolean editCate(category_DTO cate)
        {
            return cate_DAO.editCate(cate);
        }

        public List<category_DTO> searchCate(String column, String data)
        {
            return cate_DAO.searchCate(column, data);
        }
    }
}
