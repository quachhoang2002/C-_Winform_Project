using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class customer_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<customer_DTO> getAllCusName()
        {
            List<customer_DTO> list = new List<customer_DTO>();

            if(con != null)
            {
                try
                {
                    String sql = "select CusID, Name, DoB, Phone, Sex, Address from Customer where isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();

                    while (sdr.Read())
                    {
                        customer_DTO cus = new customer_DTO(sdr["CusID"].ToString()
                            , sdr["Name"].ToString()
                            , sdr["DoB"].ToString()
                            , sdr["Phone"].ToString()
                            , sdr["Sex"].ToString()
                            , sdr["Address"].ToString());

                        list.Add(cus);
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
