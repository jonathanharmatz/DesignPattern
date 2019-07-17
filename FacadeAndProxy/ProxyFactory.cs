using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    class ProxyFactory
    {

        public ClientProxy Login(string username, string password)
        {
            if (username == "Jonathan" && password == "1234")
            {
                return new CostumerProxy();
            }
            else if (username == "ELAL" && password == "4321")
            {
                return new CompanyProxy();
            }
            else if (username == "admin" && password == "admin")
            {
                return new AdminProxy();
            }
            else
            {
                return null;
            }
        }
    }
}
