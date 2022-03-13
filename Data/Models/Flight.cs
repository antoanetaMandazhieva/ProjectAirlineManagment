using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Create class Flight.
    /// This class contains an objects and properties for the table in FormFlight.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Create an object and properties.
       /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public DateTime Date { get; set; }
        
        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public int SeatCount { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public int TakenSeats { get; set; }
    }
}
