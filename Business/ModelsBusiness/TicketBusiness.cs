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
            tickets = new List<Ticket>();
            airlineManagmentContext = new AirlineManagmentContext();
            flightBusiness = new FlightBusiness();
        }

        private AirlineManagmentContext airlineManagmentContext;
        private List<Ticket> tickets;
        private FlightBusiness flightBusiness;

        public List<Ticket> TicketGetAll() => airlineManagmentContext.Tickets.ToList();

        public Ticket GetTicket(int id) => airlineManagmentContext.Tickets.Find(id);

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

        public void DeleteTicket(int id)
        {
            Ticket ticket = airlineManagmentContext.Tickets.Find(id);
            Flight flight = flightBusiness.GetFlight(ticket.FlightId);
            if (ticket != null)
            {
                flight.TakenSeats--;
                this.tickets.Remove(ticket);
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
