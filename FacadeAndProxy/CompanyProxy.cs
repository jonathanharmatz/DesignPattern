using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
     class CompanyProxy : ClientProxy, ICompany
    {
        public void CancelFlight()
        {
            this.facade.CancelFlight();
        }

        public void CreateFlight()
        {
            this.facade.CreateFlight();
        }
    }
}
