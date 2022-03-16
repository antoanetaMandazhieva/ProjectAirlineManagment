using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    interface IFlightBusiness
    {
        Flight GetFlight(int id);
        List<Flight> FlightGetAll();
        int AddFlight(Flight flight);
        void UpdateFlight(Flight flight);
        void DeleteFlight(int id);
    }
}
