using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Create class Client.
    /// This class contains objects with their properties.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Create an object with properties.
        /// <param name="Id">Name for the variable for the id input.</param>
        /// </summary>
        public int Id { get; set; }
       
        /// <summary>
        /// Create an object with properties.
        /// <param name="Name">Name for variable for the name input.</param>
        /// </summary>
        public string Name { get; set; }
      
        /// <summary>
        /// Create an object with properties.
        /// <param name="PhoneNumber">Name for variable for the phone number input.</param>
        /// </summary>
        public string PhoneNumber { get; set; }
       
        /// <summary>
        /// Create an object with properties.
        /// <param name="Nationality">Name for variable for the nationality input.</param>
        /// </summary>
        public string Nationality { get; set; }
        
        /// <summary>
        /// Create an object with properties.
        /// <param name="PassportNumber">Name for variable passport number input.</param>
        /// </summary>
        public string PassportNumber { get; set; }
    }
}
