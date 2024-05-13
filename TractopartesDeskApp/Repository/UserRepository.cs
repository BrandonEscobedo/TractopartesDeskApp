using Dapper;
using Npgsql;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using TractopartesDeskApp.Data;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public class UserRepository : SqlDataAccess, IUserRepository
    {
    

        public async Task<int> AddUser(UserModel userModel )
        {
            var parmetrs = new
            {
                apellidomaterno = userModel.apellidopaterno,
                apellidopaterno = userModel.apellidopaterno,
                nombres = userModel.nombres,
                genero = userModel.genero,
                email = userModel.email,
                telefono1 = userModel.telefono1,
                telefono2 = userModel.telefono2,
            };
           return await ExecuteGenericWithDynamicParameters("crearclientedatospersonales", parmetrs);
          
        }
      

        public   async Task< ObservableCollection<UserModel>> GetAllUser()
        {
           
               
           
            var users = LoadDataObservable<UserModel>("select * from clientedatospersonales");
            return users;

        }

        public async void RemoveUser(int idCliente)
        {
            await ExecuteGeneric("SP_RemoveUser", new { idcliente =idCliente} );
        }

    

        public async void UpdateUser(UserModel userModel)
        {

            var parameters = new
            {
                p_nombres = userModel.nombres,
                p_idcliente=userModel.idclientedp,
                p_apellidomaterno=userModel.apellidomaterno,
                p_apellidopaterno = userModel.apellidopaterno,
                p_genero=userModel.genero,
                p_telefono1=userModel.telefono1,
                p_telefono2=userModel.telefono2,
                p_email=userModel.email,
            };

            await ExecuteGeneric("updatecliente", parameters);

        }
    }
}
