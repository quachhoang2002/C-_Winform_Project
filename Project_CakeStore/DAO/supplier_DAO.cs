using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class supplier_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<supplier_DTO> getAllSupp()
        {
            List<supplier_DTO> list = new List<supplier_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select * from Supplier where isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    //lay du lieu tu database
                    while (sdr.Read())
                    {
                        supplier_DTO supp = new supplier_DTO(sdr["SuppID"].ToString()
                            , sdr["SuppName"].ToString()
                            , sdr["Address"].ToString()
                            , sdr["Email"].ToString()
                            , sdr["Phone"].ToString()
                            , sdr["ContactPerson"].ToString());

                        list.Add(supp);
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

        public List<supplier_DTO> getAllSuppWithIsDeleted()
        {
            List<supplier_DTO> list = new List<supplier_DTO>();

            if (con != null)
            {
                try
                {
                    String sql = "select SuppID, SuppName, Address, Email, Phone, ContactPerson from Supplier";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();

                    while (sdr.Read())
                    {
                        supplier_DTO supp = new supplier_DTO(sdr["SuppID"].ToString()
                            , sdr["SuppName"].ToString()
                            , sdr["Address"].ToString()
                            , sdr["Email"].ToString()
                            , sdr["Phone"].ToString()
                            , sdr["ContactPerson"].ToString());

                        list.Add(supp);
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

        //add supplier
        public Boolean addSupplier(supplier_DTO supp)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "insert into Supplier values(@SuppID,@SuppName,@Address,1,@Email,@Phone,@ContactPerson)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@SuppID", "Sup" + (getAllSuppWithIsDeleted().Count + 1));
                    cm.Parameters.AddWithValue("@SuppName", supp.getSuppName());
                    cm.Parameters.AddWithValue("@Address", supp.getAddress());
                    cm.Parameters.AddWithValue("@Email", supp.getEmail());
                    cm.Parameters.AddWithValue("@Phone", supp.getPhone());
                    cm.Parameters.AddWithValue("@ContactPerson", supp.getContactPerson());

                    con.Open();
                    int n = cm.ExecuteNonQuery();
                    if (n > 0)
                    {
                        check = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            return check;
        }

        //delete supplier
        public Boolean deleteSupplier(supplier_DTO supp)
        {
            bool check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Supplier set isDeleted=0 where SuppID=@SuppID";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@SuppID", supp.getSuppID());
                    con.Open();
                    int n = cm.ExecuteNonQuery();
                    if (n > 0)
                    {
                        check = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            return check;
        }

        //update supplier
        public Boolean updateSupplier(supplier_DTO supp)
        {
            bool check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Supplier set SuppName=@SuppName,Address=@Address,Email=@Email,Phone=@Phone,ContactPerson=@ContactPerson where suppID=@suppID";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@SuppName", supp.getSuppName());
                    cm.Parameters.AddWithValue("@Address", supp.getAddress());
                    cm.Parameters.AddWithValue("@Email", supp.getEmail());
                    cm.Parameters.AddWithValue("@Phone", supp.getPhone());
                    cm.Parameters.AddWithValue("@ContactPerson", supp.getContactPerson());
                    cm.Parameters.AddWithValue("@SuppID", supp.getSuppID());

                    con.Open();
                    int n = cm.ExecuteNonQuery();
                    if (n > 0)
                    {
                        check = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

            }
            return check;
        }

        //search supplier by id
        public List<supplier_DTO> searchSupplierByID(String data)
        {
            List<supplier_DTO> list = new List<supplier_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select SuppID, SuppName, Address, Email, Phone, ContactPerson from Supplier where SuppID = '" + data + "' and isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        supplier_DTO supp = new supplier_DTO(sdr["SuppID"].ToString(),
                            sdr["SuppName"].ToString(),
                            sdr["Address"].ToString(),
                            sdr["Email"].ToString(),
                            sdr["Phone"].ToString(),
                            sdr["ContactPerson"].ToString());
                        list.Add(supp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            return list;
        }

        //search employee by name
        public List<supplier_DTO> searchSupplierByName(String data)
        {
            List<supplier_DTO> list = new List<supplier_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select SuppID, SuppName, Address, Email, Phone, ContactPerson from Supplier where SuppName like'%" + data + "%' and isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        supplier_DTO supp = new supplier_DTO(sdr["SuppID"].ToString(),
                            sdr["SuppName"].ToString(),
                            sdr["Address"].ToString(),
                            sdr["Email"].ToString(),
                            sdr["Phone"].ToString(),
                            sdr["ContactPerson"].ToString());
                        list.Add(supp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
