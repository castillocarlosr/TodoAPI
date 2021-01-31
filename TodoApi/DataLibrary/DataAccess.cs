using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace DataLibrary
{
    public class DataAccess
    {
        public static List<T> LoadData<T, U>(string sql, U parameters, string connectionString) 
        {
            using (IDbConnection connection = new MySqlConnection(connectionString)) 
            {
                List<T> rows = connection.Query<T>(sql, parameters).ToList();
                return rows;
            }
        }
    }
}
