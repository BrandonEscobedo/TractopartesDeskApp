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
        Task<int> AddUser(UserModel userModel);
        void RemoveUser(int idCliente);

        void UpdateUser(UserModel userModel);
          Task<ObservableCollection<UserModel>> GetAllUser();
    }
}
