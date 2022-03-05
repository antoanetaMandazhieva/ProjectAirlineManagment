using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal Price { get; set; }
        public int FlightId { get; set; }
        public string Seat { get; set; }
        public bool IsOneWayTicket { get; set; }
    }
}
