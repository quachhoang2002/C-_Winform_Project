using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class importDetail_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public Boolean checkimportDetail(String importID, String cakeID)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "select * from importDetail where ImportID = '" + importID + "' and CakeID = '" + cakeID + "' and isDeleted = 1";
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

        public Boolean addImportDetail(importDetail_DTO impDe)
        {
            Boolean check = false;
            if(con != null)
            {
                try
                {
                    String sql = "insert into ImportDetail (ImportID, CakeID, Quantity, Price, isDeleted)" +
                        " values (@importID, @cakeID, @quantity, @price, 1)";

                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@importID", impDe.getImportID());
                    cm.Parameters.AddWithValue("@cakeID", impDe.getCakeID());
                    cm.Parameters.AddWithValue("@quantity", impDe.getQuantity());
                    cm.Parameters.AddWithValue("@price", impDe.getUnitprice());
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

        public Boolean updateImportDetail(importDetail_DTO impDe)
        {
            Boolean check = false;
            if(con != null)
            {
                try
                {
                    String sql = "update ImportDetail set Quantity = Quantity + @quantity, Price = Price + @price" +
                        " where ImportID = @importID and CakeID = @cakeID and isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@importID",impDe.getImportID());
                    cm.Parameters.AddWithValue("@cakeID", impDe.getCakeID());
                    cm.Parameters.AddWithValue("@quantity", impDe.getQuantity());
                    cm.Parameters.AddWithValue("@price", impDe.getUnitprice());
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
    }
}
