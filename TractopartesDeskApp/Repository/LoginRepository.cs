using Dapper;
using Npgsql;
using System.Data;
using System.Net;
using System.Windows;
using TractopartesDeskApp.Data;

namespace TractopartesDeskApp.Repository
{
       public class LoginRepository :SqlDataAccess, ILoginRepository
    {
        public async Task<bool> AuthenticateUser(NetworkCredential credential)
        {;
         

            using (IDbConnection connection = new NpgsqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                    var result=    await connection.ExecuteScalarAsync<bool>("select * from usuarios where nombreusuario=@nombreusuario  and password=@Password", new
                        {
                            nombreusuario = credential.UserName,
                            Password
                = credential.Password
                        });

                        return result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            
        }
    }
}