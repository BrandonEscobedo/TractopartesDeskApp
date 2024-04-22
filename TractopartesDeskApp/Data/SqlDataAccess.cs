using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Npgsql.Internal;
using System.Windows;
using System.Data;
using Dapper;
using System.Text.RegularExpressions;
using TractopartesDeskApp.Models;
namespace TractopartesDeskApp.Data
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;
        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string ConnectionString = "server=localhost;port=5432;user id=postgres;password=1234;database=tractopartesdb;";
        public void LoadDataAsync()
        {
            using (IDbConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                MessageBox.Show("hola");
            }
        }
        public async Task<bool> SaveData<T>(string sql,T parameters)
        {
            using (IDbConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                  await   connection.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure);
                return true;
            }

        }   
    }
}
