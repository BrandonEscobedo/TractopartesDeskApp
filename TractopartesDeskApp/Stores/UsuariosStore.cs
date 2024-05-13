using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Stores
{
    public class UsuariosStore
    {
        public event Action<UserModel> UserCreated;
         
        public void CreateUser(UserModel user)
        {
            UserCreated?.Invoke(user);
        }
            
    }
}
