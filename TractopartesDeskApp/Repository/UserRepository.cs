using System.Collections.ObjectModel;
using TractopartesDeskApp.Data;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public class UserRepository : SqlDataAccess, IUserRepository
    {

        public async void AddUser(UserModel userModel )
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
            await ExecuteGeneric ("crearclientedatospersonales", parmetrs);
        }
        public    ObservableCollection<UserModel> GetAllUser()
        {
        var users = LoadDataObservable<UserModel>("select * from clientedatospersonales");
            return users;

        }

        public void RemoveUser(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public async void UpdateUser(UserModel userModel)
        {

            await ExecuteGeneric("updatecliente",userModel);
        }
    }
}
