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

        public List<ReportImport_DTO> ReportImport(string start_time, string end_time, string field, string data)
        {
            List<ReportImport_DTO> list = new List<ReportImport_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select Cake.CakeID,Cake.CakeName ,Import.Date ,Category.CategoryName, Supplier.SuppName," +
                        " sum(ImportDetail.Quantity) as Quantity,sum(ImportDetail.Price) as Price " +
                        "from Cake " +
                        "LEFT JOIN ImportDetail ON ImportDetail.CakeID = Cake.CakeID " +
                        "LEFT JOIN Import ON ImportDetail.ImportID = Import.ImportID " +
                        "LEFT JOIN Category ON Cake.CategoryID = Category.CategoryID " +
                        "LEFT JOIN Supplier ON Import.SuppID = Supplier.SuppID " +
                        "where Import.Date between '" + start_time + "' and '" + end_time + "' " +
                        " and " + field + " LIKE '%" + data + "%' " +
                        "GROUP BY Cake.CakeID,Cake.CakeName,Import.Date,Category.CategoryName,Supplier.SuppName " +
                        "ORDER BY Import.Date DESC";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        if (sdr["Date"] == DBNull.Value)
                        {
                            continue;
                        }

                        ReportImport_DTO report = new ReportImport_DTO();
                        report.CakeId = sdr["CakeID"].ToString();
                        report.CakeName = sdr["CakeName"].ToString();
                        report.Supplier = sdr["SuppName"].ToString();
                        report.Date = sdr["Date"].ToString();
                        report.CakeType = sdr["CategoryName"].ToString();
                        report.Quantity = int.Parse(sdr["Quantity"].ToString());
                        report.TotalPrice = int.Parse(sdr["Price"].ToString());
                        list.Add(report);
                    }

                }
                catch (Exception e)
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

        public List<ReportSell_DTO> ReportSell(string start_time, string end_time, string field, string data)
        {
            List<ReportSell_DTO> list = new List<ReportSell_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select Cake.CakeID,Cake.CakeName ,[Order].Date,Category.CategoryName, Customer.Name as CusName," +
                        " sum(OrderDetail.Quantity) as Quantity,sum(OrderDetail.Price) as Price " +
                        "from Cake " +
                        "LEFT JOIN OrderDetail ON OrderDetail.CakeID = Cake.CakeID " +
                        "LEFT JOIN [Order] ON OrderDetail.OrderID = [Order].OrderID " +
                        "LEFT JOIN Category ON Cake.CategoryID = Category.CategoryID " +
                        "LEFT JOIN Customer ON [Order].CusID = Customer.CusID " +
                        "where [Order].Date between '" + start_time + "' and '" + end_time + "' " +
                        " and " + field + " LIKE '%" + data + "%' " +
                        "GROUP BY Cake.CakeID,Cake.CakeName,Category.CategoryName,[Order].Date,Customer.Name " +
                        "ORDER BY Date DESC";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        if (sdr["Date"] == DBNull.Value)
                        {
                            continue;
                        }
                        ReportSell_DTO report = new ReportSell_DTO();
                        report.CakeId = sdr["CakeID"].ToString();
                        report.CakeName = sdr["CakeName"].ToString();
                        report.Customer = sdr["CusName"].ToString();
                        report.Date = sdr["Date"].ToString();
                        report.CakeType = sdr["CategoryName"].ToString();
                        report.Quantity = int.Parse(sdr["Quantity"].ToString());
                        report.TotalPrice = int.Parse(sdr["Price"].ToString());
                        list.Add(report);
                    }
                }
                catch (Exception e)
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
