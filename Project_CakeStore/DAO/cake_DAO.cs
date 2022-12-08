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

            if (con != null)
            {
                try
                {
                    String sql = "select Cake.*,Category.CategoryName from Cake " +
                        "JOIN Category On Cake.CategoryID = Category.CategoryID " +
                        " where Cake.isDeleted = 1";
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
                        cake.setCategoryName(sdr["CategoryName"].ToString());
                        list.Add(cake);
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

            return list;
        }

        public Boolean addCake(cake_DTO cake)
        {
            Boolean check = false;

            if (con != null)
            {
                try
                {
                    String sql = "insert into Cake (CakeID, CakeName, CategoryID, UnitPrice, Quantity, isDeleted)" +
                    " values (@CakeID, @CakeName, @categoryID, @UnitPrice, @Quantity, 1)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
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
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally { con.Close(); }
            }

            return check;
        }

        private int CountCake()
        {
            {
                int count = 0;
                if (con != null)
                {
                    try
                    {
                        String sql = "select count(CakeID) from Cake";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        count = (int)cmd.ExecuteScalar();
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

                return count;
            }
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

        public Boolean addCakeAuto(cake_DTO cake)
        {
            Boolean check = false;
            int Id = CountCake() + 1;

            if (con != null)
            {
                try
                {
                    String sql = "insert into Cake (CakeID, CakeName, CategoryID, UnitPrice, Quantity, isDeleted)" +
                    " values (@CakeID, @CakeName, @categoryID, @UnitPrice, @Quantity, 1)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@CakeID", "C" + Id.ToString());
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

        public Boolean deleteCake(String cakeID)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Cake set isDeleted = 0 where CakeID = @cakeID";
                    SqlCommand cm = new SqlCommand(sql, con);
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

        public Boolean editCake(cake_DTO cake)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Cake set CakeName = @cakeName, CategoryID = @categoryID, " +
                        "UnitPrice = @unitPrice, Quantity = @quantity where CakeID = @cakeID and isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@cakeID", cake.getCakeID());
                    cm.Parameters.AddWithValue("@cakeName", cake.getCakeName());
                    cm.Parameters.AddWithValue("@categoryID", cake.getCategoryID());
                    cm.Parameters.AddWithValue("@unitPrice", cake.getUnitPrice());
                    cm.Parameters.AddWithValue("@quantity", cake.getQuantity());
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

        public List<cake_DTO> searchCake(String column, String data)
        {
            List<cake_DTO> list = new List<cake_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select * from Cake where " + column + " = '" + data + "'";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        cake_DTO cake = new cake_DTO(sdr["CakeID"].ToString()
                            , sdr["CakeName"].ToString()
                            , sdr["CategoryID"].ToString()
                            , int.Parse(sdr["UnitPrice"].ToString())
                            , int.Parse(sdr["Quantity"].ToString())
                            , "");

                        list.Add(cake);
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


            return list;
        }
    }
}
