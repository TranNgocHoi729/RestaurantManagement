﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccess
{
    class Dao
    {
        public static SqlConnection GetConnection()
        {
            String ConnectString = ConfigurationManager.ConnectionStrings["my_RestaurantCStr"].ToString();
            SqlConnection Connection = new SqlConnection(ConnectString);
            return Connection;
        }

        public static DataTable GetDataBySQL(string sql)
        {
            SqlCommand Command = new SqlCommand(sql, GetConnection());
            DataTable dt = new DataTable();
            Command.Connection.Open();

            SqlDataReader Reader = Command.ExecuteReader();

            dt.Load(Reader);
            Command.Connection.Close();
            return dt;
        }

        public static DataTable GetDataBySQLWithParameters(string sql, params SqlParameter[] parameters)
        {
            SqlCommand Command = new SqlCommand(sql, GetConnection());
            DataTable dt = new DataTable();
            Command.Parameters.AddRange(parameters);
            Command.Connection.Open();

            SqlDataReader Reader = Command.ExecuteReader();

            dt.Load(Reader);
            Command.Connection.Close();
            return dt;
        }

        public static int ExecuteSQL(string sql)
        {
            SqlCommand Command = new SqlCommand(sql, GetConnection());
            Command.Connection.Open();
            int k = Command.ExecuteNonQuery();
            Command.Connection.Close();
            return k;
        }

        public static int ExecuteSQLWithParameters(string sql, params SqlParameter[] parameters)
        {
            SqlCommand Command = new SqlCommand(sql, GetConnection());
            Command.Connection.Open();
            Command.Parameters.AddRange(parameters);
            Console.WriteLine(Command.ToString());
            int k = Command.ExecuteNonQuery();
            Command.Connection.Close();
            return k;
        }
    }


}
