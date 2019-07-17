using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    public class FlightSystemFacade : ICompany, ICostumer, IAdmin
    {

        protected FlightDAO DAO = new FlightDAO();

        public void BuyTicket()
        {
            DAO.InsertTicket();
        }
        public void ShowMyTickets()
        {
            DAO.GetTickets();
        }
        public void CancelFlight()
        {
            DAO.RemoveFlight();
        }

        public void CreateComapny()
        {
            DAO.InsertCompany();
        }

        public void CreateCostumer()
        {
            DAO.InsertCostumer();
        }

        public void CreateFlight()
        {
            DAO.InsertFlight();
        }


    }
}
