using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    public class PilotBusiness
    {
        public PilotBusiness()
        {
            airlineManagmentContext = new AirlineManagmentContext();
            pilots = new List<Pilot>();
        }
        private AirlineManagmentContext airlineManagmentContext;
        private List<Pilot> pilots;

        public List<Pilot> PilotGetAll() => airlineManagmentContext.Pilots.ToList();

        public Pilot GetPilot(int id) => airlineManagmentContext.Pilots.Find(id);

        public int AddPilot(Pilot pilot)
        {
            if (pilots.Contains(pilot))
            {
                return 1;
                //ima go
            }
            else
            {
                airlineManagmentContext.Pilots.Add(pilot);
                airlineManagmentContext.SaveChanges();
                this.pilots.Add(pilot);
                return 0;
                // vs top
            }
        }

        public void DeletePilot(int id)
        {
            Pilot pilot = airlineManagmentContext.Pilots.Find(id);
            if (pilot != null)
            {
                airlineManagmentContext.Pilots.Remove(pilot);
                this.pilots.Remove(pilot);
                airlineManagmentContext.SaveChanges();
            }
        }

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
