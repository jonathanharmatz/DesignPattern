using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    class AdminProxy : ClientProxy, IAdmin
    {
        public void CreateComapny()
        {
            this.facade.CreateComapny();
        }

        public void CreateCostumer()
        {
            this.facade.CreateCostumer();
        }
    }
}
