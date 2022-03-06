using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    public class FlightBusiness
    {
        public FlightBusiness()
        {
            flights = new List<Flight>();
            airlineManagmentContext = new AirlineManagmentContext();
        }

        private AirlineManagmentContext airlineManagmentContext;
        public List<Flight> flights;

        public Flight GetFlight(int id) => airlineManagmentContext.Flights.Find(id);

        public List<Flight> FlightGetAll() => airlineManagmentContext.Flights.ToList();

        public int AddFlight(Flight flight)
        {
            if (flights.Contains(flight))
            {
                return 1;
                //ima go
            }
            else
            {
                airlineManagmentContext.Flights.Add(flight);
                airlineManagmentContext.SaveChanges();
                this.flights.Add(flight);
                return 0;
                //vsichko top
            }

        }
        public void DeleteFlight(int id)
        {
            Flight flight = airlineManagmentContext.Flights.Find(id);
            if (flight != null)
            {
                airlineManagmentContext.Flights.Remove(flight);
                this.flights.Remove(flight);
                airlineManagmentContext.SaveChanges();
            }
        }
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
