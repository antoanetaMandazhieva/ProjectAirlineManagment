using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    /// <summary>
    /// Create interface IPilotBusiness.
    /// </summary>
    interface IPilotBusiness
    {
        List<Pilot> PilotGetAll();
        Pilot GetPilot(int id);
        int AddPilot(Pilot pilot);
        void DeletePilot(int id);
        void UpdatePilot(Pilot pilot);
    }
}
