using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Configuration;
using Project_CakeStore.DTO;
using System.CodeDom.Compiler;

namespace Project_CakeStore.DAO
{
    internal class account_DAO
    {


        SqlConnection con = DBConnection.GetDBConnection();

        public Boolean checkLogin(String userName, String password)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    String sql = "select * from Account where UserName ='" + userName + "' and Password ='" + password + "' and isDeleted = 1";
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

        public employee_DTO getInfoEmp(String userName, String password)
        {
            
            String empId = ""
                , empname = ""
                , position = ""
                , sex = ""
                , phone = ""
                , address = "";  
            if(con != null)
            {
                try
                {
                    String sql = "select emp.EmpID, EmpName, Position, Sex, Phone, Address from Account as acc,Employee as emp where acc.EmpID = emp.EmpID and acc.UserName ='" + userName + "' and acc.Password ='" + password + "'";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        empId = sdr["EmpID"].ToString();
                        empname = sdr["EmpName"].ToString();
                        position = sdr["Position"].ToString();
                        sex = sdr["Sex"].ToString();
                        phone = sdr["Phone"].ToString();
                        address = sdr["Address"].ToString();

                    }

                } catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            employee_DTO emp = new employee_DTO(empId, empname, position, sex, phone, address);
            return emp;
        }
        
    }
}
