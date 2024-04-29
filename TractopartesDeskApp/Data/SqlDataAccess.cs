﻿using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using Dapper;
using System.Collections.ObjectModel;
using TractopartesDeskApp.Models;
namespace TractopartesDeskApp.Data
{
    public class SqlDataAccess 
    {
        public string ConnectionString = "server=localhost;port=5432;user id=postgres;password=1234;database=tractopartesdb;";

        public ObservableCollection<T> LoadDataObservable<T>(string sql)
        {
            ObservableCollection<T> ObservableCollection=new ObservableCollection<T>();
            using (IDbConnection connection = new NpgsqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();
                    var rows = connection.Query<T>(sql);
                    foreach(var row in rows)
                    {
                        ObservableCollection.Add(row);
                    }
                    return ObservableCollection ;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public async Task<bool> SaveData<T>(string sql,T parameters)
        {
            using (IDbConnection connection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    await connection.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {

                    throw  ;
                }
            }
        }   
    }
}
