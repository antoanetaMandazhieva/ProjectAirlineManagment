using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    /// <summary>
    /// Create an interface IClientBusiness.
    /// </summary>
    interface IClientBusiness
    {
        List<Client> ClientGetAll();
        Client GetClient(int id);
        int AddClient(Client client);
        void UpdateClient(Client client);
    }
}
