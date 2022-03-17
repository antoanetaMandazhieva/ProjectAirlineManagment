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
        public Pilot()
        {
        }

        public Pilot(string name, string phoneNumber, int age, int flightId)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
            this.FlightId = flightId;
        }

        public Pilot(int id, string name, string phoneNumber, int age, int flightId)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
            this.FlightId = flightId;
        }

        /// <summary>
        /// Create an object and properties.
        /// /// </summary>
        public int Id { get; set; }
       
        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Create an object an properties.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public string TypePilot { get; set; }

        /// <summary>
        /// Create an object and properties.
        /// </summary>
        public int FlightId { get; set; }
    }
}
