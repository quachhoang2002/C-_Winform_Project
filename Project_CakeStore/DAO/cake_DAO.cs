using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class cake_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<cake_DTO> getAllCakeName()
        {
            List<cake_DTO> list = new List<cake_DTO>();

            if(con != null)
            {
                try
                {
                    String sql = "select * from Cake where isDeleted = 1";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        cake_DTO cake = new cake_DTO(sdr["CakeID"].ToString()
                            , sdr["CakeName"].ToString()
                            , sdr["CategoryID"].ToString()
                            , (int)sdr["UnitPrice"]
                            , (int)sdr["Quantity"]
                            , "");

                        list.Add(cake);
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

        public Boolean addCake(cake_DTO cake)
        {
            Boolean check = false;

            if(con != null)
            {
                try
                {
                    String sql = "insert into Cake (CakeID, CakeName, CategoryID, UnitPrice, Quantity, isDeleted)" +
                    " values (@CakeID, @CakeName, @categoryID, @UnitPrice, @Quantity, 1)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@CakeID", cake.getCakeID());
                    cm.Parameters.AddWithValue("@CakeName", cake.getCakeName());
                    cm.Parameters.AddWithValue("@categoryID", cake.getCategoryID());
                    cm.Parameters.AddWithValue("@UnitPrice", cake.getUnitPrice());
                    cm.Parameters.AddWithValue("@Quantity", cake.getQuantity());
                    con.Open();
                    int n = cm.ExecuteNonQuery();

                    if (n > 0)
                    {
                        check = true;
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

            return check;
        }

        public Boolean checkCakeID(String cakeID)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "select * from Cake where CakeID = '" + cakeID + "' and isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        check = true;
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally { con.Close(); }
            }

            return check;
        }

        public Boolean updateQuantityCake(String cakeID, int quantity)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Cake set Quantity = Quantity - @quantity where CakeID = @cakeID and isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@quantity",quantity);
                    cm.Parameters.AddWithValue("@cakeID", cakeID);
                    con.Open();

                    int n = cm.ExecuteNonQuery();
                    if (n > 0)
                    {
                        check = true;
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


            return check;
        }

        public Boolean updateQuantityCakePlus(String cakeID, int quantity)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Cake set Quantity = Quantity + @quantity where CakeID = @cakeID and isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@quantity", quantity);
                    cm.Parameters.AddWithValue("@cakeID", cakeID);
                    con.Open();

                    int n = cm.ExecuteNonQuery();
                    if (n > 0)
                    {
                        check = true;
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }


            return check;
        }
    }
}
