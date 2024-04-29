using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using Dapper;
namespace TractopartesDeskApp.Data
{
    public class SqlDataAccess :ISqlDataAccess
    {
        public string ConnectionString = "server=localhost;port=5432;user id=postgres;password=1234;database=tractopartesdb;";

        public void LoadDataAsync()
        {
            throw new NotImplementedException();
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
