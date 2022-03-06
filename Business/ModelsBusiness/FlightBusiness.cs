using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    class FlightBusiness
    {
        public Flight GetFlight(int id) => airlineManagmentContext.Flights.Find(id);
    }
}
