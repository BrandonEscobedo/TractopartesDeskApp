using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
      ObservableCollection<UserModel> GetAllUser();
    }
}
