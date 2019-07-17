using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    public class FlightDAO
    {

        public void InsertTicket()
        {
            Console.WriteLine("Inserted ticket");
        }

        public void GetTickets()
        {
            Console.WriteLine("Got tickets");
        }
        public void InsertFlight()
        {
            Console.WriteLine("Inserted flight");
        }
        public void RemoveFlight()
        {
            Console.WriteLine("Removed flight");
        }
        public void InsertCostumer()
        {
            Console.WriteLine("Inserted costumer");
        }
        public void InsertCompany()
        {
            Console.WriteLine("Inserted company");
        }
    }
}
