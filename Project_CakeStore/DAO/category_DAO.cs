using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class category_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();

        public List<category_DTO> getAllCategory()
        {
            List<category_DTO> list = new List<category_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select CategoryID, CategoryName from Category where isDeleted = 1";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        category_DTO cate = new category_DTO(sdr["CategoryID"].ToString(), sdr["CategoryName"].ToString());
                        list.Add(cate);
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

        public Boolean addCate(category_DTO cate)
        {
            Boolean check = false;
            List<category_DTO> list = getAllCategory();
            if (con != null)
            {
                try
                {
                    String sql = "insert into Category values (@cateID, @cateName, 1)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@cateID", "L" + (list.Count + 1));
                    cm.Parameters.AddWithValue("@cateName", cate.getCategoryName());
                    con.Open();

                    int n = cm.ExecuteNonQuery();
                    if (n > 0)
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

        public Boolean deleteCate(String cateID)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Category set isDeleted = 0 where CategoryID = @cateID";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@cateID", cateID);
                    con.Open();

                    int n = cm.ExecuteNonQuery();
                    if (n > 0)
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

        public Boolean editCate(category_DTO cate)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Category set CategoryName = @cateName where CategoryID = @categoryID and isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@categoryID", cate.getCategoryID());
                    cm.Parameters.AddWithValue("@cateName", cate.getCategoryName());
                    con.Open();

                    int n = cm.ExecuteNonQuery();
                    if (n > 0)
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

        public List<category_DTO> searchCate(String column, String data)
        {
            List<category_DTO> list = new List<category_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select * from Category where " + column + " = '" + data + "' and isDeleted = 1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        category_DTO cate = new category_DTO(sdr["CategoryID"].ToString(), sdr["CategoryName"].ToString());
                        list.Add(cate);
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
    }
}
