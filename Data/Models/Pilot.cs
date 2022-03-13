using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Create class Pilot.
    /// This class contain an object and properties for the table in FormPilot.
    /// </summary>
    public class Pilot
    {
        /// <summary>
        /// Create an object and properties.
        /// <param name="Id">Name variable for id input.</param>
        /// </summary>
        public int Id { get; set; }
       
        /// <summary>
        /// Create an object and properties.
        /// <param name="Name">Name variable for name input</param>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Create an object an properties
        /// <param name="PhoneNumer">Name for variable phone number input.</param>
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="Age">Name for variable age input.</param>
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="TypePilot">Name for variable type of pilot input.</param>
        /// </summary>
        public string TypePilot { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// <param name="FlightId">Name for variable flight id input.</param>
        /// </summary>
        public int FlightId { get; set; }
    }
}
