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

            bool response = await ExecuteGenericScalar("select * from usuarios where nombreusuario=@nombreusuario  and password=@Password", new
            {
                nombreusuario = credential.UserName,
                Password
                = credential.Password
            });
            return response;       
        }
    }
}