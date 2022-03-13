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
        /// <param name="Id">Name for variale id input.</param>
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="Destination"> Name for variable destination input.</param>
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="Data">Name for variable data input.</param>
        /// </summary>
        public DateTime Date { get; set; }
        
        /// <summary>
        /// Create an object and properties.
        /// <param name="SeatCount">Name for variable seat count input.</param>
        /// </summary>
        public int SeatCount { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="TakenSeats">Nmae for variable taken seats count input.</param>
        /// </summary>
        public int TakenSeats { get; set; }
    }
}
