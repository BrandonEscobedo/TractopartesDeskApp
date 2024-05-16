using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using Dapper;
using System.Collections.ObjectModel;
using TractopartesDeskApp.Models;
using System.Windows;
namespace TractopartesDeskApp.Data
{
    public class SqlDataAccess 
    {
        public string ConnectionString = "server=localhost;port=5432;user id=postgres;password=1234;database=tractopartesdb;";
        public     ObservableCollection<T> LoadDataObservable<T>(string sql)
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
                    return ObservableCollection;   
                }
                catch (Exception ex)
                {
                    MessageBox.Show ("Ocurrio un error al generar la consulta de bases de datos");
                    throw;
                }
            }
        }
        public async Task<ObservableCollection<T>> LoadDataWithRelations<T, TCategoria, TProveedor>(string sql, Func<T, TCategoria, TProveedor, T> mapFunction, string splitOn)
        {
            ObservableCollection<T> ObservableCollection = new ObservableCollection<T>();
            using (IDbConnection connection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
             var    results =  connection.Query(sql, mapFunction, splitOn: splitOn);

                    if (results.Any())
                    {
                        foreach (var row in results)
                        {
                            ObservableCollection.Add(row);
                        }
                        return ObservableCollection;
                    }
                    else
                    {
                        return ObservableCollection;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al generar la consulta de bases de datos");
                    throw;
                }
            }
        }
        public async Task<bool> ExecuteGeneric<T>(string sql,T parameters)
        {
            using (IDbConnection connection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                  connection.Open();
                  await connection.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure);

                    return true;
                }
                catch (Exception ex )
                {

                    MessageBox.Show(ex.Message);
                    return false ;
                }
            }
        }
        public async Task<int> ExecuteGenericWithDynamicParameters<T>(string sql, T parameters, string parameterOut)
        {
            using (IDbConnection connection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    var parameterss = new DynamicParameters(parameters);
                    parameterss.Add(parameterOut, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    await connection.ExecuteAsync(sql, parameterss, commandType: CommandType.StoredProcedure);

                    var newUserId = parameterss.Get<int>(parameterOut);
                    return newUserId;
                }
                catch (Exception ex) 
                {

                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }
    }
}
