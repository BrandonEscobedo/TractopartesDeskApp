using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TractopartesDeskApp.Repository
{
  public  interface ILoginRepository
    {
      Task< bool> AuthenticateUser(NetworkCredential credential);

    }

}
