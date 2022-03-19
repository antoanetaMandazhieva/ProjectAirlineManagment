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
    /// <PropertyGroup>
    /// <GenerateDocumentationFile>true<GenerateDocumentationFile>
    /// </PropertyGroup>
    /// <GenerateDocumentationFile>
    /// true
    /// </GenerateDocumentationFile>
    /// Business class for clients.
    /// </summary>

    public class ClientBusiness
    {

        /// <summary>
        /// Constructor for class ClientBusiness.
        /// </summary>
        public ClientBusiness()
        {
            airlineManagmentContext = new AirlineManagmentContext();
        }

        /// <summary>
        /// Create object from class AirLineManagmentContext.
        /// </summary>
        private AirlineManagmentContext airlineManagmentContext;

        /// <summary>
        /// This method take all information for clients.
        /// </summary>
        /// <returns>Return list of clients.</returns>
        public List<Client> ClientGetAll() => airlineManagmentContext.Clients.ToList();

        /// <summary>
        /// This method take information for one client about his id.
        /// </summary>
        /// <param name="id">Name for the variable id input.</param>
        /// <returns>Return clients with his id.</returns>
        public Client GetClient(int id) => airlineManagmentContext.Clients.Find(id);

        /// <summary>
        /// This method add clients.
        /// </summary>
        /// <param name="client">Name for the variable object of Client.</param>
        /// <returns>Return number.</returns>
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
       
        /// <summary>
        /// This method update cients.
        /// </summary>
        /// <param name="client">Name for the variable object of Client.</param>
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
