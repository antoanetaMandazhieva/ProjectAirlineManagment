using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    public class TicketBusiness
    {
        public TicketBusiness() : base()
        {
            tickets = new List<Ticket>();
            airlineManagmentContext = new AirlineManagmentContext();
        }

        private AirlineManagmentContext airlineManagmentContext;
        private List<Ticket> tickets;
        public List<Ticket> TicketGetAll() => airlineManagmentContext.Tickets.ToList();
    

    }
}
