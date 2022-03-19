using Moq;
using NUnit.Framework;
using System.Data.Entity;
using Data.Models;
using Data;
using Business.ModelsBusiness;
using System.Collections.Generic;
using System.Linq;

namespace Business.Tests
{
    public class ClientBusinessTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void AddClient()
        //{
        //    var mockSet = new Mock<DbSet<Client>>();

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(m => m.Clients).Returns(mockSet.Object);

        //    var service = new ClientBusiness(mockSet.Object);
        //    service.AddClient(new Client());

        //    mockSet.Verify(x => x.Add(It.IsAny<Client>()), Times.Once());
        //    mockContext.Verify(m => m.SaveChanges(), Times.Once());
        //}
        //[Test]
        //public void GetAllClients()
        //{
        //    var data = new List<Client>
        //    {
        //        new Client{ Name = "Client1"},
        //        new Client{ Name = "Client2"},
        //        new Client{ Name= "Client3"},
        //    }.AsQueryable();

        //    var mockSet = new Mock<DbSet<Client>>();
        //    mockSet.As<IQueryable<Client>>().Setup(x => x.Provider).Returns(data.Provider);
        //    mockSet.As<IQueryable<Client>>().Setup(x => x.Expression).Returns(data.Expression);
        //    mockSet.As<IQueryable<Client>>().Setup(x => x.ElementType).Returns(data.ElementType);
        //    mockSet.As<IQueryable<Client>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(x => x.Clients).Returns(mockSet.Object);

        //    var service = new ClientBusiness(mockContext.Object);
        //    var clientsFound = service.ClientGetAll();

        //    Assert.AreEqual(3, clientsFound.Count());
        //    Assert.AreEqual("Client1", clientsFound[0].Name);
        //    Assert.AreEqual("Client2", clientsFound[1].Name);
        //    Assert.AreEqual("Client3", clientsFound[2].Name);
        //}
        //[Test]
        //public void GetCllient()
        //{
        //    var data = new List<Client>
        //    {
        //        new Client{ Name = "Client1", Id = 1},
        //        new Client{ Name = "Client2", Id = 2},
        //    }.AsQueryable();

        //    var mockSet = new Mock<DbSet<Client>>();
        //    mockSet.As<IQueryable<Client>>().Setup(x => x.Provider).Returns(data.Provider);
        //    mockSet.As<IQueryable<Client>>().Setup(x => x.Expression).Returns(data.Expression);
        //    mockSet.As<IQueryable<Client>>().Setup(x => x.ElementType).Returns(data.ElementType);
        //    mockSet.As<IQueryable<Client>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(x => x.Clients).Returns(mockSet.Object);

        //    var service = new ClientBusiness(mockContext.Object);
        //    var clientsFound = service.GetClient(1);

        //    Assert.AreEqual(1, clientsFound[0].Id, clientsFound[0].Name);
        //}
    }
}