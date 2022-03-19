using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    /// <summary>
    /// Business class for tickets.
    /// </summary>
    public class TicketBusiness
    {
        /// <summary>
        /// Create an constructor.
        /// </summary>
        public TicketBusiness()
        {
            airlineManagmentContext = new AirlineManagmentContext();
            flightBusiness = new FlightBusiness();
            clientBusiness = new ClientBusiness();
        }

        /// <summary>
        /// Create an object from AirlineManagmentContext.
        /// </summary>
        private AirlineManagmentContext airlineManagmentContext;
        /// <summary>
        /// Create an object from FlightBusiness.
        /// </summary>
        private FlightBusiness flightBusiness;
        /// <summary>
        /// Create an object from ClientBusiness.
        /// </summary>
        private ClientBusiness clientBusiness;

        /// <summary>
        /// This method take all information about ticket.
        /// </summary>
        /// <returns>Return list of tickets.</returns>
        public List<Ticket> TicketGetAll() => airlineManagmentContext.Tickets.ToList();

        /// <summary>
        /// This method take information about one ticket by his id.
        /// </summary>
        /// <param name="id">Name for variable id input.</param>
        /// <returns>Return information about ticket by his id.</returns>
        public Ticket GetTicket(int id) => airlineManagmentContext.Tickets.Find(id);

        /// <summary>
        /// This method add tickets.
        /// </summary>
        /// <param name="ticket">Name for object of Ticket.</param>
        /// <returns>Return number.</returns>
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

        /// <summary>
        /// This method delete tickets.
        /// </summary>
        /// <param name="id">Name for variable id input.</param>
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

        /// <summary>
        /// This method update tickets.
        /// </summary>
        /// <param name="ticket">Name for object of Ticket.</param>
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
