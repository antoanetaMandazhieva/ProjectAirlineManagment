using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Create class Client.
    /// This class contains objects with their properties for the table in FormClient.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Create an object with properties.
        /// </summary>
        public int Id { get; set; }
       
        /// <summary>
        /// Create an object with properties.
        /// </summary>
        public string Name { get; set; }
      
        /// <summary>
        /// Create an object with properties.
        /// </summary>
        public string PhoneNumber { get; set; }
       
        /// <summary>
        /// Create an object with properties.
        /// </summary>
        public string Nationality { get; set; }
        
        /// <summary>
        /// Create an object with properties.
        /// </summary>
        public string PassportNumber { get; set; }
    }
}
