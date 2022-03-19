using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    /// <summary>
    /// Business class for Flight.
    /// </summary>
    public class FlightBusiness
    {
        /// <summary>
        /// Create a constructor.
        /// </summary>
        public FlightBusiness()
        {
            airlineManagmentContext = new AirlineManagmentContext();
        }

        /// <summary>
        /// Create object from class AirLineManagmentContext.
        /// </summary>
        private AirlineManagmentContext airlineManagmentContext;

        /// <summary>
        /// This method take information for one fligt about his id.
        /// </summary>
        /// <param name="id">Name for the variable id input.</param>
        /// <returns>Return flights with his id.</returns>
        public Flight GetFlight(int id) => airlineManagmentContext.Flights.Find(id);

        /// <summary>
        /// This method take all information about flights.
        /// </summary>
        /// <returns>Returns list of flights.</returns>
        public List<Flight> FlightGetAll() => airlineManagmentContext.Flights.ToList();

        /// <summary>
        /// This methods add flights.
        /// </summary>
        /// <param name="flight">Name for object of Flight.</param>
        /// <returns>Return number.</returns>
        public int AddFlight(Flight flight)
        {
            if (this.airlineManagmentContext.Flights.Any(x => x.Destination == flight.Destination && x.Date == flight.Date))
            {
                return 1;
               
            }
            else
            {
                airlineManagmentContext.Flights.Add(flight);
                airlineManagmentContext.SaveChanges();
                return 0;
               
            }

        }

        /// <summary>
        /// This method delete flights.
        /// </summary>
        /// <param name="id">Name for variable id input.</param>
        public void DeleteFlight(int id)
        {
            Flight flight = airlineManagmentContext.Flights.Find(id);
            if (flight != null)
            {
                airlineManagmentContext.Flights.Remove(flight);
                airlineManagmentContext.Flights.Remove(flight);
                airlineManagmentContext.SaveChanges();
            }
        }
        
        /// <summary>
        /// This method update flights.
        /// </summary>
        /// <param name="flight"> Name for an object of Flight.</param>
        public void UpdateFlight(Flight flight)
        {
            Flight updatedFlight = airlineManagmentContext.Flights.Find(flight.Id);
            if (updatedFlight != null)
            {
                airlineManagmentContext.Entry(updatedFlight).CurrentValues.SetValues(flight);
                airlineManagmentContext.SaveChanges();
            }
        }
    }
}
