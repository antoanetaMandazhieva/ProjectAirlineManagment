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
    /// Create business clas for Pilot.
    /// </summary>
    public class PilotBusiness
    {
        /// <summary>
        /// Create a constructor.
        /// </summary>
        public PilotBusiness()
        {
            airlineManagmentContext = new AirlineManagmentContext();
        }
        /// <summary>
        /// Create an obgect of AirlineManagmentContext.
        /// </summary>
        private AirlineManagmentContext airlineManagmentContext;
        /// <summary>
        /// Create list of pilots.
        /// </summary>
        private List<Pilot> pilots;

        /// <summary>
        /// This method taka all information about pilots.
        /// </summary>
        /// <returns>Return list of pilots.</returns>
        public List<Pilot> PilotGetAll() => airlineManagmentContext.Pilots.ToList();

        /// <summary>
        /// This method take all information about one pilot by his id.
        /// </summary>
        /// <param name="id">Name for the variable id input.</param>
        /// <returns>Return information about pilot by his id.</returns>
        public Pilot GetPilot(int id) => airlineManagmentContext.Pilots.Find(id);

        /// <summary>
        /// This method add pilots.
        /// </summary>
        /// <param name="pilot">Name for an object of Pilot.</param>
        /// <returns>Returns number.</returns>
        public int AddPilot(Pilot pilot)
        {
            if (!(this.airlineManagmentContext.Flights.Any(x => x.Id == pilot.FlightId)))
            {
                return 2;
                // not exist
            }
            if (this.airlineManagmentContext.Pilots.Any(x => x.FlightId == pilot.FlightId
                && x.TypePilot == pilot.TypePilot))
            {
                return 2;
            }
            if (this.airlineManagmentContext.Pilots.Any
                (x => x.Name == pilot.Name 
                && x.FlightId == pilot.FlightId 
                && x.PhoneNumber == pilot.PhoneNumber
                && x.TypePilot == pilot.TypePilot))
            {
                return 1;
               
            }
            else
            {
                airlineManagmentContext.Pilots.Add(pilot);
                airlineManagmentContext.SaveChanges();
                return 0;
              
            }
        }

        /// <summary>
        /// This method delete pilots.
        /// </summary>
        /// <param name="id">Name for the variable id input.</param>
        public void DeletePilot(int id)
        {
            Pilot pilot = airlineManagmentContext.Pilots.Find(id);
            if (pilot != null)
            {
                airlineManagmentContext.Pilots.Remove(pilot);
                airlineManagmentContext.SaveChanges();
            }
        }

        /// <summary>
        /// This method update pilots.
        /// </summary>
        /// <param name="pilot">Name for an object of Pilot.</param>
        public void UpdatePilot(Pilot pilot)
        {
            Pilot updatePilot = airlineManagmentContext.Pilots.Find(pilot.Id);
            if (updatePilot != null)
            {
                airlineManagmentContext.Entry(updatePilot).CurrentValues.SetValues(pilot);
                airlineManagmentContext.SaveChanges();
            }
        }
    }
}
