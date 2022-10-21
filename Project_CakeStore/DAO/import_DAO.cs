using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class import_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<import_DTO> getAllImport()
        {
            List<import_DTO> list = new List<import_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select ImportID, SuppID, Date, EmployeeID from Import where isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        String importID = sdr["ImportID"].ToString();
                        String suppID = sdr["SuppID"].ToString();
                        String date = sdr["Date"].ToString();
                        String empID = sdr["EmployeeID"].ToString();
                        import_DTO import = new import_DTO(importID, suppID, date, empID);
                        list.Add(import);
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

        public Boolean addImport(import_DTO imp)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "insert into Import (ImportID, SuppID, Date, EmployeeID, isDeleted)" +
                        "values (@importID, @suppID, @date, @employeeID, 1)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@importID", imp.getImportID());
                    cm.Parameters.AddWithValue("@suppID", imp.getSuppID());
                    cm.Parameters.AddWithValue("@date", imp.getDate());
                    cm.Parameters.AddWithValue("@employeeID", imp.getEmpID());
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

        public List<import_DTO> searchImport(String column, String data)
        {
            List<import_DTO> list = new List<import_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select ImportID, SuppID, Date, EmployeeID from Import where " + column + " = '" + data + "'";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        String importID = sdr["ImportID"].ToString();
                        String suppID = sdr["SuppID"].ToString();
                        String date = sdr["Date"].ToString();
                        String empID = sdr["EmployeeID"].ToString();
                        import_DTO import = new import_DTO(importID, suppID, date, empID);
                        list.Add(import);
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


        public List<orderInfor_DTO> getAllImportInfor(String importID, String suppID, String empID)
        {
            List<orderInfor_DTO> list = new List<orderInfor_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select orde.CakeID, cake.CakeName, cake.UnitPrice, orde.Quantity, orde.Price from Import as o, ImportDetail as orde , Cake as cake " +
                        "where o.ImportID = orde.ImportID and orde.CakeID = cake.CakeID and o.ImportID = '" + importID + "' and o.SuppID = '" + suppID + "' and o.EmployeeID = '" + empID + "'";
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

        public Boolean checkImportID(String importID)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "Select * from Import where ImportID = '" + importID + "' and isDeleted = 1";
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
                finally
                {
                    con.Close();
                }
            }
            return check;
        }
    }
}
