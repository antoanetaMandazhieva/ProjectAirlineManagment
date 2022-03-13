using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Create class Ticket.
    /// This class contains object and properties for the table in FormTickets.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Create an object and properties.
        /// <param name="Id">Name for variable id input.</param>
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="ClientId">Name for variable client id input.</param>
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="FlightId">Name for variable flight id input.</param>
        /// </summary>
        public int FlightId { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="Price">Name for variable price input.</param>
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="Seat">Nmae for variable seat input.</param>
        /// </summary>
        public string Seat { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="TypeTicket">Name for variable type of ticket input.</param>
        /// </summary>
        public string TypeTicket { get; set; }
    }
}
