using Project_CakeStore.DAO;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.BUS
{
    internal class cake_BUS
    {
        private cake_DAO cake_DAO = new cake_DAO();

        public List<cake_DTO> getAllCakeName()
        {
            return cake_DAO.getAllCakeName();
        }

        public Boolean checkCakeID(String cakeID)
        {
            return cake_DAO.checkCakeID(cakeID);
        }

        public Boolean addCake(cake_DTO cake)
        {
            return cake_DAO.addCake(cake);
        }

        public Boolean updateQuantityCake(String cakeID, int quantity)
        {
            return cake_DAO.updateQuantityCake(cakeID, quantity);
        }

        public Boolean updateQuantityPlus(String cakeID, int quantity)
        {
            return cake_DAO.updateQuantityCakePlus(cakeID, quantity);
        }

        public Boolean addCakeAuto(cake_DTO cake)
        {
            return cake_DAO.addCakeAuto(cake);
        }

        public Boolean deleteCake(String cakeID)
        {
            return cake_DAO.deleteCake(cakeID);
        }

        public Boolean editCake(cake_DTO cake)
        {
            return cake_DAO.editCake(cake);
        }

        public List<cake_DTO> searchCake(String column, String data)
        {
            return cake_DAO.searchCake(column, data);
        }
    }
}
