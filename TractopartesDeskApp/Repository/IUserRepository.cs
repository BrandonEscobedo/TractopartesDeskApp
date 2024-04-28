using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public interface IUserRepository
    {
        void AddUser(UserModel userModel);
        void UpdateUser(UserModel userModel);
        void RemoveUser(UserModel userModel);
       IEnumerable<UserModel> GetAllUser();
    }
}
