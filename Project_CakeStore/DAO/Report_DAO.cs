using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class Report_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();
        public int totalEmployee()
        {
            int total = 0;
            if (con != null)
            {
                try
                {
                    String sql = "select count(EmpID) from Employee where isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    total = (int)cm.ExecuteScalar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //close database connection
                    con.Close();
                }
            }
            return total;

        }

        public int totalCustomer()
        {
            int total = 0;
            if (con != null)
            {
                try
                {
                    String sql = "select count(CusID) from Customer where isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    total = (int)cm.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //close database connection
                    con.Close();
                }
            }
            return total;

        }

        public int totalCake()
        {
            int total = 0;
            if (con != null)
            {
                try
                {
                    String sql = "select count(CakeID) from Cake where isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    total = (int)cm.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //close database connection
                    con.Close();
                }
            }
            return total;

        }

        public int totalOrder()
        {
            int total = 0;
            if (con != null)
            {
                try
                {
                    String sql = "select count(OrderID) from [Order] where isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    total = (int)cm.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //close database connection
                    con.Close();
                }
            }
            return total;

        }

        public int totalManufactor()
        {
            int total = 0;
            if (con != null)
            {
                try
                {
                    String sql = "select count(SuppID) from Supplier where isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    total = (int)cm.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //close database connection
                    con.Close();
                }
            }
            return total;
        }

        public List<ReportImport_DTO> importStatistical(string start_time, string end_time)
        {
            List<ReportImport_DTO> list = new List<ReportImport_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select id.CakeID, c.CakeName, sum(id.Quantity) as Quantity, sum(id.Price) as TotalPrice " +
                        "from Import i," +
                        "importDetail as id" +
                        " Cake c" +
                        " where i.ImportID = id.ImportID" +
                        "and id.CakeID = c.CakeID" +
                        "group by c.id " +
                        "order by Quantity ASC";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        ReportImport_DTO ReportImport = new ReportImport_DTO(sdr["CakeID"].ToString(), sdr["CakeName"].ToString(),
                            int.Parse(sdr["Quantity"].ToString()), int.Parse(sdr["TotalPrice"].ToString()));
                        list.Add(ReportImport);
                    }

                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
