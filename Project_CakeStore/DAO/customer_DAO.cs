using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class customer_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<customer_DTO> getAllCusName()
        {
            List<customer_DTO> list = new List<customer_DTO>();

            if (con != null)
            {
                try
                {
                    String sql = "select CusID, Name, DoB, Phone, Sex, Address from Customer where isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();

                    while (sdr.Read())
                    {
                        customer_DTO cus = new customer_DTO(sdr["CusID"].ToString()
                            , sdr["Name"].ToString()
                            , sdr["DoB"].ToString()
                            , sdr["Phone"].ToString()
                            , sdr["Sex"].ToString()
                            , sdr["Address"].ToString());

                        list.Add(cus);
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


        //add Customer
        public Boolean addCustomer(customer_DTO cus)
        {
            bool check = false;
            if (con != null)
            {
                try
                {
                    String sql = "insert into Customer values(@CusID,@CusName,@CusDoB,@CusPhone,@CusSex,@CusAddress,1)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@CusID", cus.getCusID());
                    cm.Parameters.AddWithValue("@CusName", cus.getCusName());
                    cm.Parameters.AddWithValue("@CusDoB", cus.getDoB());
                    cm.Parameters.AddWithValue("@CusPhone", cus.getPhone());
                    cm.Parameters.AddWithValue("@CusSex", cus.getSex());
                    cm.Parameters.AddWithValue("@CusAddress", cus.getAddress());
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


        //update Customer
        public Boolean updateCustomer(customer_DTO cus)
        {
            bool check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Customer set Name=@CusName, DoB=@CusDoB, Phone=@CusPhone, Sex=@CusSex,Address=@CusAddress where CusID=@CusID and isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("CusName", cus.getCusName());
                    cm.Parameters.AddWithValue("CusDoB", cus.getDoB());
                    cm.Parameters.AddWithValue("CusPhone", cus.getPhone());
                    cm.Parameters.AddWithValue("CusSex", cus.getSex());
                    cm.Parameters.AddWithValue("CusAddress", cus.getAddress());
                    cm.Parameters.AddWithValue("CusID", cus.getCusID());
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

        //delete Customer
        public Boolean deleteCustomer(customer_DTO cus)
        {
            bool check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Customer set isDeleted=0 where CusID=@CusID";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@CusID", cus.getCusID());
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


        //search customer by ID
        public List<customer_DTO> searchCustomerByID(String data)
        {
            List<customer_DTO> list = new List<customer_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select CusID, Name, DoB, Phone, Sex, Address from Customer where CusID='" + data + "' and isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        customer_DTO cus = new customer_DTO(sdr["CusID"].ToString()
                            , sdr["Name"].ToString()
                            , sdr["DoB"].ToString()
                            , sdr["Phone"].ToString()
                            , sdr["Sex"].ToString()
                            , sdr["Address"].ToString());

                        list.Add(cus);

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

        //search customer by Name
        public List<customer_DTO> searchCustomerByName(String data)
        {
            List<customer_DTO> list = new List<customer_DTO>();
            if (con != null)
            {
                try
                {
                    String sql= "select CusID, Name, DoB, Phone, Sex, Address from Customer where Name like '%"+data+"%' and isDeleted=1";
                    SqlCommand cm=new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        customer_DTO cus = new customer_DTO(sdr["CusID"].ToString()
                            , sdr["Name"].ToString()
                            , sdr["DoB"].ToString()
                            , sdr["Phone"].ToString()
                            , sdr["Sex"].ToString()
                            , sdr["Address"].ToString());

                        list.Add(cus);
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

        //find newest CusID
        public List<customer_DTO> searchNewestCusID()
        {
            List<customer_DTO> list = new List<customer_DTO>();
            try
            {
                String sql = "select TOP 1 CusID, Name, DoB, Phone, Sex, Address from Customer ORDER BY CusID DESC";
                SqlCommand cm = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    customer_DTO cus = new customer_DTO(sdr["CusID"].ToString()
                            , sdr["Name"].ToString()
                            , sdr["DoB"].ToString()
                            , sdr["Phone"].ToString()
                            , sdr["Sex"].ToString()
                            , sdr["Address"].ToString());

                    list.Add(cus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return list;

        }
    }
}
