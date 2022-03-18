using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsBusiness
{
   
    public class ClientBusiness
    {
       
        public ClientBusiness()
        {
            airlineManagmentContext = new AirlineManagmentContext();
        }

       
        private AirlineManagmentContext airlineManagmentContext;
        
    
        public List<Client> ClientGetAll() => airlineManagmentContext.Clients.ToList();

    
        public Client GetClient(int id) => airlineManagmentContext.Clients.Find(id);

        public int AddClient(Client client)
        {
            if (this.airlineManagmentContext.Clients.Any
                (x => x.Name == client.Name 
                && x.PhoneNumber == client.PhoneNumber
                && x.PassportNumber == client.PassportNumber 
                && x.Nationality == client.Nationality))
            {
                return 1;
                //ima go
            }
            else
            {
                airlineManagmentContext.Clients.Add(client);
                airlineManagmentContext.SaveChanges();
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
