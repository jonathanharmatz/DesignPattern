using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory proxyFactory = new ProxyFactory();

            ClientProxy myProxy1 = proxyFactory.Login("Jonathan", "1234");

            CostumerProxy costumerProxy = (CostumerProxy) myProxy1;

            costumerProxy.BuyTicket();


            ClientProxy myProxy2 = proxyFactory.Login("ELAL", "4321");

            CompanyProxy companyProxy = (CompanyProxy)myProxy2;

            companyProxy.CreateFlight();


            ClientProxy myProxy3 = proxyFactory.Login("admin", "admin");

            AdminProxy adminProxy = (AdminProxy)myProxy3;

            adminProxy.CreateCostumer();
        }
    }
}
