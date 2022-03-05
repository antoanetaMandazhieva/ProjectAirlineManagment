using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
    class ClientBusiness
    {
        public ClientBusiness()
        {
            clients = new List<Client>();
            airlineManagmentContext = new AirlineManagmentContext();
        }

        private List<Client> clients;
        private AirlineManagmentContext airlineManagmentContext;
        
        public List<Client> ClientGetAll() => airlineManagmentContext.Clients.ToList();

        public Client GetClient(int id) => airlineManagmentContext.Clients.Find(id);

        public int AddClient(Client client)
        {
            if (this.clients.Contains(client))
            {
                return 1;
                //ima go
            }
            else
            {
                airlineManagmentContext.Clients.Add(client);
                airlineManagmentContext.SaveChanges();
                this.clients.Add(client);
                return 0;
                // vs top
            }
        }
        public void UpdateClient(Client client)
        {
            Client updatedClient = airlineManagmentContext.Clients.Find(client.Id);
            if (updatedClient != null)
            {
                airlineManagmentContext.Entry(updatedClient).CurrentValues.SetValues(client);
                airlineManagmentContext.SaveChanges();
            }
        }
    }
}
