﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class DBConnection
    {
        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
       
        public static SqlConnection GetDBConnection()
        {
            //Data Source=VOTRANTANLOC\SQLEXPRESS;Initial Catalog=QuanLyCuaHangBanh;Persist Security Info=True;User ID=sa;Password=***********
            string datasource = @"VIBOT\VI";
            string database = "ok";
            string username = "sa";
            string password = "123456";
            return GetDBConnection(datasource, database, username, password);
        }
    }
}
