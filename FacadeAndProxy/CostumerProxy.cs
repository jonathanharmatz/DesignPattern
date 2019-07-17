using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
     class CostumerProxy : ClientProxy, ICostumer
    {

        public void BuyTicket()
        {
            this.facade.BuyTicket();
        }

        public void ShowMyTickets()
        {
            this.facade.ShowMyTickets();
        }
    }
}
