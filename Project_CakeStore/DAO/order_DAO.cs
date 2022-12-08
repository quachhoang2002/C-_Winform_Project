using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class order_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<order_DTO> getAllOrder()
        {
            List<order_DTO> list = new List<order_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select OrderID, CusID, EmpID, Date from dbo.[Order] where isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        String orderID = sdr["OrderID"].ToString();
                        String cusID = sdr["CusID"].ToString();
                        String empID = sdr["EmpID"].ToString();
                        String date = sdr["Date"].ToString();
                        order_DTO order = new order_DTO(orderID, cusID, empID, date);
                        list.Add(order);
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

        public Boolean addOrder(order_DTO order)
        {
            Boolean check = false;
            if(con != null)
            {
                try
                {
                    string sql = "insert into dbo.[Order] (OrderID, CusID, EmpID, Date, isDeleted) " +
                    "values (@OrderID, @CusID, @EmpID, @Date, 1)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@OrderID", order.getOrderID());
                    cm.Parameters.AddWithValue("@CusID", order.getCusID());
                    cm.Parameters.AddWithValue("@EmpID", order.getEmpID());
                    cm.Parameters.AddWithValue("@Date", order.getDate());
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

        public Boolean checkOrder(String orderID)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "select * from dbo.[Order] where OrderID = '"+orderID+"' and isDeleted = 1";
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

        public List<order_DTO> searchOrder(String column, String data)
        {
            List<order_DTO> list = new List<order_DTO>();

            if (con != null)
            {
                try
                {
                    String sql = "select OrderID, CusID, EmpID, Date from dbo.[Order] where " + column + " = '" + data + "' and isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();

                    while (sdr.Read())
                    {
                        String orderID = sdr["OrderID"].ToString();
                        String cusID = sdr["CusID"].ToString();
                        String empID = sdr["EmpID"].ToString();
                        String date = sdr["Date"].ToString();
                        order_DTO order = new order_DTO(orderID, cusID, empID, date);
                        list.Add(order);
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
