using Business.ModelsBusiness;
using Data;
using Data.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TicketBusinessTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void AddTicket()
        //{
        //    var mockSet = new Mock<DbSet<Ticket>>();

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(m => m.Tickets).Returns(mockSet.Object);

        //    var service = new TicketBusiness(mockSet.Object);
        //    service.AddTicket(new Ticket());

        //    mockSet.Verify(x => x.Add(It.IsAny<Ticket>()), Times.Once());
        //    mockContext.Verify(m => m.SaveChanges(), Times.Once());
        //}
        //[Test]
        //public void GetAllFlights()
        //{
        //    var data = new List<Ticket>
        //    {
        //        new Ticket{ ClientId = 1},
        //        new Ticket{ ClientId = 2},
        //        new Ticket{ ClientId= 3},
        //    }.AsQueryable();

        //    var mockSet = new Mock<DbSet<Ticket>>();
        //    mockSet.As<IQueryable<Ticket>>().Setup(x => x.Provider).Returns(data.Provider);
        //    mockSet.As<IQueryable<Ticket>>().Setup(x => x.Expression).Returns(data.Expression);
        //    mockSet.As<IQueryable<Ticket>>().Setup(x => x.ElementType).Returns(data.ElementType);
        //    mockSet.As<IQueryable<Ticket>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(x => x.Tickets).Returns(mockSet.Object);

        //    var service = new TicketBusiness(mockContext.Object);
        //    var ticketsFound = service.TicketGetAll();

        //    Assert.AreEqual(3, ticketsFound.Count());
        //    Assert.AreEqual(1, ticketsFound[0].ClientId);
        //    Assert.AreEqual(2, ticketsFound[1].ClientId);
        //    Assert.AreEqual(3, ticketsFound[2].ClientId);
        //}
        //[Test]
        //public void GetTicket()
        //{
        //    var data = new List<Ticket>
        //    {
        //        new Ticket{ ClientId = 1},
        //        new Ticket{ ClientId = 2},
        //        new Ticket{ ClientId= 3},
        //    }.AsQueryable();

        //    var mockSet = new Mock<DbSet<Ticket>>();
        //    mockSet.As<IQueryable<Ticket>>().Setup(x => x.Provider).Returns(data.Provider);
        //    mockSet.As<IQueryable<Ticket>>().Setup(x => x.Expression).Returns(data.Expression);
        //    mockSet.As<IQueryable<Ticket>>().Setup(x => x.ElementType).Returns(data.ElementType);
        //    mockSet.As<IQueryable<Ticket>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(x => x.Tickets).Returns(mockSet.Object);

        //    var service = new TicketBusiness(mockContext.Object);
        //    var ticketsFound = service.GetTicket(1);

        //    Assert.AreEqual(1, ticketsFound.Count());
        //    Assert.AreEqual(1, ticketsFound[0].ClientId);
        //}
    }
}