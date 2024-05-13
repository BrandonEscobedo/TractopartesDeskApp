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
        public static ObservableCollection<UserModel> Users = new();
      static  IUserRepository _userRepository;
         static Usermanager()
        {
             _userRepository = new UserRepository();
             SetUsers();
            
        }
        public static ObservableCollection<UserModel> GetUsers()
        {
            return Users;
        }
        public static async void SetUsers()
        {
            Users.Clear();
           
        }
        public static void UpdateUserList(UserModel user)
        {
            var cliente = Users.Where(x => x.idclientedp == user.idclientedp).FirstOrDefault();
            if (cliente != null)
                Users.Remove(cliente);
            Users.Add(user);
        }
        public static  void RemoveUserList(int idcliente)
        {
           var user = Users.Where(x=>x.idclientedp==idcliente).FirstOrDefault();
            if (user != null)
            {
                Users.Remove(user);
            }
        }
        public static void AddUsers(UserModel userModel)
        {
            var newUsers = _userRepository.GetAllUser();
            Users.Add(userModel);
        }
    }
}
