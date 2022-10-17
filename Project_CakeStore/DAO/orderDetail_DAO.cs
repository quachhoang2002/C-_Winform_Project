using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class orderDetail_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<orderDetail_DTO> getOrderDetail(String orderID)
        {
            List<orderDetail_DTO> list = new List<orderDetail_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select OrderID, CakeID, Quantity, Price from OrderDetail" +
                    " where OrderID = '" + orderID + "' and isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        orderDetail_DTO cthd = new orderDetail_DTO(sdr["OrderID"].ToString()
                            , sdr["CakeID"].ToString()
                            , int.Parse(sdr["Quantity"].ToString())
                            , int.Parse(sdr["Price"].ToString()));

                        list.Add(cthd);
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            return list;
        }

        public Boolean checkOrderDetail(String orderID, String cakeID)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "Select * from OrderDetail where OrderID = '" + orderID + "' and CakeID = '" + cakeID + "' and isDeleted = 1";
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
                finally
                {
                    con.Close();
                }
            }

            return check;
        }

        public Boolean addOrderDetail(orderDetail_DTO orDe)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    string sql = "insert into OrderDetail (OrderID, CakeID, Quantity, Price, isDeleted) " +
                    "values(@OrderID, @CakeID, @Quantity, @Price, 1)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@OrderID", orDe.getOrderID());
                    cm.Parameters.AddWithValue("@CakeID", orDe.getCakeID());
                    cm.Parameters.AddWithValue("@Quantity", orDe.getQuantity());
                    cm.Parameters.AddWithValue("@Price", orDe.getPrice());
                    con.Open();
                    int n = cm.ExecuteNonQuery();

                    if(n > 0)
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

        public Boolean updateOrderDetail(orderDetail_DTO orde)
        {
            Boolean check = false;
            if(con != null)
            {
                try
                {
                    String sql = "update OrderDetail set Quantity = Quantity + @quantity, Price = Price + @price" +
                        " where OrderID = @orderID and CakeID = @cakeID and isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@quantity",orde.getQuantity());
                    cm.Parameters.AddWithValue("@price",orde.getPrice());
                    cm.Parameters.AddWithValue("@orderID",orde.getOrderID());
                    cm.Parameters.AddWithValue("@cakeID",orde.getCakeID());
                    con.Open();

                    int n = cm.ExecuteNonQuery();
                    if(n > 0)
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
    }
}
