using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    interface ITicketBusiness
    {
        List<Ticket> TicketGetAll();
        Ticket GetTicket(int id);
        int AddTicket(Ticket ticket);
        void DeleteTicket(int id);

        void UpdateTicket(Ticket ticket);
    }
}
