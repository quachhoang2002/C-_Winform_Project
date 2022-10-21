using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class employee_DAO
    {
        SqlConnection con = DBConnection.GetDBConnection();
        
        
        //get all employee in database
        public List<employee_DTO> getAllEmployee()
        {
            List<employee_DTO> list = new List<employee_DTO>();

            if (con != null)
            {
                try
                {
                    String sql = "select EmpID, EmpName, Position, Sex, Phone, Address from Employee where isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    //Have data in the database
                    while (sdr.Read())
                    {
                 
                        //initialize object transmitting parameters as database's table values
                        employee_DTO emp = new employee_DTO(sdr["EmpID"].ToString()
                            , sdr["EmpName"].ToString()
                            , sdr["Position"].ToString()
                            , sdr["Sex"].ToString()
                            , sdr["Phone"].ToString()
                            , sdr["Address"].ToString());
                        list.Add(emp);

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //close database connection
                    con.Close(); 

                }
            }
            return list;
        }

        //add employee
        public Boolean addEmployee(employee_DTO emp)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "insert into Employee values(@EmpID,@EmpName,@Position,@Sex,@Phone,@Address,1)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@EmpID", emp.getEmpID());
                    cm.Parameters.AddWithValue("@EmpName", emp.getEmpName());
                    cm.Parameters.AddWithValue("@Position", emp.getPosition());
                    cm.Parameters.AddWithValue("@Sex", emp.getSex());
                    cm.Parameters.AddWithValue("@Phone", emp.getPhone());
                    cm.Parameters.AddWithValue("@Address", emp.getAddress());

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

        //delete employee
        public Boolean deleteEmployee(employee_DTO emp)
        {
            bool check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Employee set isDeleted=0 where EmpID=@EmpID";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@EmpID", emp.getEmpID());
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



        //update employee
        public Boolean updateEmployee(employee_DTO emp)
        {
            bool check = false;
            if (con != null)
            {
                try
                {
                    String sql = "update Employee set EmpName=@EmpName, Position=@Position,Sex=@Sex,Phone=@Phone,Address=@Address where EmpID=@EmpID";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@EmpName", emp.getEmpName());
                    cm.Parameters.AddWithValue("@Position", emp.getPosition());
                    cm.Parameters.AddWithValue("@Sex", emp.getSex());
                    cm.Parameters.AddWithValue("@Phone", emp.getPhone());
                    cm.Parameters.AddWithValue("@Address", emp.getAddress());
                    cm.Parameters.AddWithValue("@EmpID", emp.getEmpID());
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


        //check if id is exist
        


        //search employee by id
        public List<employee_DTO> searchEmployeeByID(String data)
        {
            List<employee_DTO> list = new List<employee_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select EmpID, EmpName, Position, Sex, Phone, Address from Employee where EmpID = '" + data + "' and isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        employee_DTO emp = new employee_DTO(sdr["EmpID"].ToString(),
                            sdr["EmpName"].ToString(),
                            sdr["Position"].ToString(),
                            sdr["Sex"].ToString(),
                            sdr["Phone"].ToString(),
                            sdr["Address"].ToString());
                        list.Add(emp);
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
        public List<employee_DTO> searchEmployeeByName(String data)
        {
            List<employee_DTO> list = new List<employee_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "select EmpID, EmpName, Position, Sex, Phone, Address from Employee where EmpName like'%" + data + "%' and isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        employee_DTO emp = new employee_DTO(sdr["EmpID"].ToString(),
                            sdr["EmpName"].ToString(),
                            sdr["Position"].ToString(),
                            sdr["Sex"].ToString(),
                            sdr["Phone"].ToString(),
                            sdr["Address"].ToString());
                        list.Add(emp);
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

        //find newest employee id
        public List<employee_DTO> SearchNewestEmpID()
        {
            List<employee_DTO> list = new List<employee_DTO>();
            if (con != null)
            {
                try
                {
                    String sql = "SELECT TOP 1 EmpID,EmpName,Position,Sex,Phone,Address FROM Employee ORDER BY EmpID DESC";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        employee_DTO emp = new employee_DTO(sdr["EmpID"].ToString(),
                            sdr["EmpName"].ToString(),
                            sdr["Position"].ToString(),
                            sdr["Sex"].ToString(),
                            sdr["Phone"].ToString(),
                            sdr["Address"].ToString());
                        list.Add(emp);
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
            }
            return list;
        }

    }
}
