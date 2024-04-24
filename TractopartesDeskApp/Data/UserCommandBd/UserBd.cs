using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Data.UserCommandBd
{
    public class UserBd : IUserBd
    {
        private readonly ISqlDataAccess sqlDataAccess;

        public UserBd(ISqlDataAccess sqlDataAccess)
        {
            this.sqlDataAccess = sqlDataAccess;
        }

        public void AddUser(UserModel user)
        {
            sqlDataAccess.SaveData("public.crearusuariosdatospersonales", user);
        }
    }
}
