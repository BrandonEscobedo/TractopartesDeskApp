using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Data;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public class UserRepository : SqlDataAccess, IUserRepository
    {
 
        public async void AddUser(UserModel userModel)
        {

           await ExecuteGeneric("crearclientedatospersonales", userModel);
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
