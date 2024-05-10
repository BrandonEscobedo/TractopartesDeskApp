using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Repository;

namespace TractopartesDeskApp.Models
{
  public  static class Usermanager
    {
        public static ObservableCollection<UserModel> Users = new ObservableCollection<UserModel>();

         static Usermanager()
        {
            IUserRepository _userRepository = new UserRepository();
            Users = _userRepository.GetAllUser();
        }
        public static ObservableCollection<UserModel> GetUsers()
        {
            return Users;
        }
   
        public static void AddUsers(UserModel userModel)
        {
            Users.Add(userModel);
        }
    }
}
