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
                    String sql = "select count(CusID) where isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    total = cm.ExecuteNonQuery();

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
                    String sql = "select count(CakeID) where isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    total = cm.ExecuteNonQuery();
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
                    String sql = "select count(OrderID) where isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    total = cm.ExecuteNonQuery();                 
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

        
    }
}
