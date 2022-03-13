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
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public int FlightId { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public string Seat { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public string TypeTicket { get; set; }
    }
}
