using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Create class AirlineManagmentContext.
    /// This class impliments Dbcontext.
    /// </summary>
    public class AirlineManagmentContext : DbContext
    {
       /// <summary>
       /// Create a constructor.
       /// This constructor impliments base.
       /// </summary>
        public AirlineManagmentContext()
            : base("name=AirlineManagmentContextProject")
        {

        }

        /// <summary>
        /// Create an object from a Dbcontext using DbContext.Set method for clients.
        /// Create a properties.
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// Create an object from a Dbcontext using DbContext.Set method for tickets.
        /// Create a properties.
        /// </summary>
        public DbSet<Ticket> Tickets { get; set; }

        /// <summary>
        /// Create an object from a Dbcontext using Dbcontext.Set method for flights.
        /// Create a properties.
        /// </summary>
        public DbSet<Flight> Flights { get; set; }

        /// <summary>
        /// Create an object from Dbcontext using Dbcontext.Set method for pilots.
        /// Create a properties.
        /// </summary>
        public DbSet<Pilot> Pilots { get; set; }

       
    }
}
