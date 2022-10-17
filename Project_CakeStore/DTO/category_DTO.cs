using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DTO
{
    internal class category_DTO
    {
        private String categoryID;
        private String categoryName;

        public category_DTO(String categoryID, String categoryName)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
        }

        public String getCategoryID()
        {
            return categoryID;
        }

        public void setCategoryID(String categoryID)
        {
            this.categoryID = categoryID;
        }

        public String getCategoryName()
        {
            return categoryName;
        }

        public void setCategoryName(String categoryName)
        {
            this.categoryName = categoryName;
        }
    }
}
