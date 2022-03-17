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
        public TicketBusiness()
        {
            airlineManagmentContext = new AirlineManagmentContext();
            flightBusiness = new FlightBusiness();
            clientBusiness = new ClientBusiness();
        }

        private AirlineManagmentContext airlineManagmentContext;
        private FlightBusiness flightBusiness;
        private ClientBusiness clientBusiness;

        public List<Ticket> TicketGetAll() => airlineManagmentContext.Tickets.ToList();

        public Ticket GetTicket(int id) => airlineManagmentContext.Tickets.Find(id);

        public int AddTicket(Ticket ticket)
        {
            Flight flight = flightBusiness.GetFlight(ticket.FlightId);
            Client client = clientBusiness.GetClient(ticket.ClientId);
            if (flight.SeatCount == flight.TakenSeats && flight.Id == ticket.FlightId)
            {
                return 1;
                // nqma mesta
            }
            //if (ticket.FlightId != flight.Id)
            //{
            //    return
            //}
            if (this.airlineManagmentContext.Tickets.Any(x => x.ClientId == client.Id && x.FlightId == flight.Id))
            {

                return 2;
            }
            else
            {
                airlineManagmentContext.Tickets.Add(ticket);
                this.airlineManagmentContext.Flights.FirstOrDefault(x => x.Id == ticket.FlightId).TakenSeats++;
                airlineManagmentContext.SaveChanges();
                return 0;
            }


        }

        public void DeleteTicket(int id)
        {
            Ticket ticket = airlineManagmentContext.Tickets.Find(id);
            Flight flight = flightBusiness.GetFlight(ticket.FlightId);
            if (ticket != null)
            {
                flight.TakenSeats--;
                airlineManagmentContext.Tickets.Remove(ticket);
                airlineManagmentContext.Tickets.Remove(ticket);
                airlineManagmentContext.SaveChanges();
            }
        }

        public void UpdateTicket(Ticket ticket)
        {
            Ticket updatedTicket = airlineManagmentContext.Tickets.Find(ticket.Id);
            if (updatedTicket != null)
            {
                airlineManagmentContext.Entry(updatedTicket).CurrentValues.SetValues(ticket);
                airlineManagmentContext.SaveChanges();
            }
        }
    }
}
