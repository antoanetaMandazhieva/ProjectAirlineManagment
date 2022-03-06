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
            flightBusiness = new FlightBusiness();
        }

        private AirlineManagmentContext airlineManagmentContext;
        private FlightBusiness flightBusiness;
        private List<Ticket> tickets;
        public List<Ticket> TicketGetAll() => airlineManagmentContext.Tickets.ToList();

        public int AddTicket(Ticket ticket)
        {
            Flight flight = flightBusiness.GetFlight(ticket.FlightId);
            if (flight.SeatCount == flight.TakenSeats && flight.Id == ticket.FlightId)
            {
                return 1;
                // nqma mesta
            }
            if (flight.Id == ticket.FlightId)
            {
                airlineManagmentContext.Tickets.Add(ticket);
                airlineManagmentContext.SaveChanges();
                this.tickets.Add(ticket);
                flight.TakenSeats++;
                return 0;
                // wsichko top
            }
            else
            {
                return 2;
                //poletite ne syv
            }

        }


    }
}
