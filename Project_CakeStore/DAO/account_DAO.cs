﻿using System;
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

        public int checkLogin(String userName, String password)
        {
            int check = -1;
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
                        if (sdr["Permission"].Equals(0))
                        {
                            return 0;
                        }
                        else if (sdr["Permission"].Equals(1))
                        {
                            return 1;
                        }
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

        public List<account_DTO> getAllAccount()
        {
            List<account_DTO> list = new List<account_DTO>();

            if (con != null)
            {
                try
                {
                    String sql = "select * from Account where isDeleted = 1";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        account_DTO account = new account_DTO(sdr["AccID"].ToString(), sdr["EmpID"].ToString(), sdr["UserName"].ToString(), sdr["Password"].ToString(), (int)sdr["Permission"]);
                        list.Add(account);
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

        public List<account_DTO> getAllAccountWithIsDeleted()
        {
            List<account_DTO> list = new List<account_DTO>();

            if (con != null)
            {
                try
                {
                    String sql = "select * from Account";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        account_DTO account = new account_DTO(sdr["AccID"].ToString(), sdr["EmpID"].ToString(), sdr["UserName"].ToString(), sdr["Password"].ToString(), (int)sdr["Permission"]);
                        list.Add(account);
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

        public bool AddAccount(account_DTO account)
        {
            Boolean check = false;
            if (con != null)
            {
                try
                {
                    string sql = "insert into Account (AccID, EmpID, UserName, Password, Permission, isDeleted) " +
                    "values (@AccID, @EmpID, @UserName, @Password, @Permission, 1)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@AccID", "Acc"+(getAllAccountWithIsDeleted().Count+1));
                    cm.Parameters.AddWithValue("@EmpID", account.EmpID);
                    cm.Parameters.AddWithValue("@UserName", account.UserName);
                    cm.Parameters.AddWithValue("@Password", account.Password);
                    cm.Parameters.AddWithValue("@Permission", account.Permission);
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

        public bool DeleteAccount(String ID)
        {
            Boolean check = false;
            try
            {
                string sql = "Update Account set isDeleted=0 Where AccID='"+ID+"'";
                SqlCommand cm = new SqlCommand(sql, con);
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
            finally { 
                con.Close();
            }
            return check;
        }

        public List<account_DTO> SearchAccount(String column, String data)
        {
            List<account_DTO> list = new List<account_DTO>();

            if (con != null)
            {
                try
                {
                    string sql = "Select * Account  Where "+column+"='"+data+"' "+" and isDeleted=1";
                    SqlCommand cm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader sdr = cm.ExecuteReader();

                    while (sdr.Read())
                    {
                        account_DTO account = new account_DTO(sdr["AccID"].ToString(), sdr["EmpID"].ToString(), sdr["UserName"].ToString(), sdr["Password"].ToString(), (int)sdr["Permission"]);
                        list.Add(account);
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

        public bool UpdateAccount(account_DTO account)
        {
            bool check = false;
            if (con != null)
            {
                try
                {
                    String sql = "Update Account set EmpID=@EmpID,UserName=@UserName,Password=@Password,Permission=@Permission where AccID=@AccID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@EmpID", account.EmpID);
                    cmd.Parameters.AddWithValue("@UserName", account.UserName);
                    cmd.Parameters.AddWithValue("@Password", account.Password);
                    cmd.Parameters.AddWithValue("@Permission", account.Permission);
                    cmd.Parameters.AddWithValue("@AccID", account.AccID);

                    con.Open();

                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                        check = true;
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
