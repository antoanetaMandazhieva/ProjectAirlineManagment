using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AirlineManagmentContext : DbContext
    {
        public AirlineManagmentContext()
            : base("name=AirlineManagmentContextProject")
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
    }
}
