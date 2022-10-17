using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class orderInfor_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<orderInfor_DTO> getAllOrderInfor(String orderID, String cusID, String empID)
        {
            List<orderInfor_DTO> list = new List<orderInfor_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select orde.CakeID, cake.CakeName, cake.UnitPrice, orde.Quantity, orde.Price from dbo.[Order] as o, OrderDetail as orde , Cake as cake " +
                        "where o.OrderID = orde.OrderID and orde.CakeID = cake.CakeID and o.OrderID = '"+orderID+ "' and o.CusID = '"+cusID+"' and o.EmpID = '"+empID+"'";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        String cakeID = sdr["CakeID"].ToString();
                        String cakeName = sdr["CakeName"].ToString();
                        int unitPrice = int.Parse(sdr["UnitPrice"].ToString());
                        int quantity = int.Parse(sdr["Quantity"].ToString());
                        int price = int.Parse(sdr["Price"].ToString());
                        orderInfor_DTO infor = new orderInfor_DTO(cakeID, cakeName, unitPrice, quantity, price);
                        list.Add(infor);
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
