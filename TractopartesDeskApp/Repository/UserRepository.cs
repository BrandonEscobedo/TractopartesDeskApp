using System;
using System.Collections.Generic;
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

           await SaveData("crearClienteDatosPersonales", userModel);
        }

        public IEnumerable<UserModel> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserModel userModel)
        {
            throw new NotImplementedException();
        }
    }
}
