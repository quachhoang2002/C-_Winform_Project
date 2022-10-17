using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class supplier_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<supplier_DTO> getAllSupp()
        {
            List<supplier_DTO> list= new List<supplier_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select SuppID, SuppName, Address from Supplier where isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();

                    while (sdr.Read())
                    {
                        supplier_DTO supp = new supplier_DTO(sdr["SuppID"].ToString()
                            , sdr["SuppName"].ToString()
                            , sdr["Address"].ToString());

                        list.Add(supp);
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
