using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractopartesDeskApp.VIewModel
{
    public class MainClientesViewModel:ViewModelBase
    {
        public MainClientesViewModel(AddUserByViewModel createUserViewModel, UserByViewModel userByViewModel)
        {
            CreateUserViewModel = createUserViewModel;
            UserByViewModel = userByViewModel;
        }

        public AddUserByViewModel CreateUserViewModel { get; set; }
       public UserByViewModel UserByViewModel { get; set; }
            

    }
}
