using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class category_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<category_DTO> getAllCategory()
        {
            List<category_DTO> list = new List<category_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select CategoryID, CategoryName from Category where isDeleted = 1";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        category_DTO cate = new category_DTO(sdr["CategoryID"].ToString(), sdr["CategoryName"].ToString());
                        list.Add(cate);
                    }


                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }


            return list;
        }
    }
}
