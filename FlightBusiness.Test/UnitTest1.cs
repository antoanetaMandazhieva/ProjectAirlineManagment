using Business.ModelsBusiness;
using Data;
using Data.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Flights.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void AddFlight()
        //{
        //    var mockSet = new Mock<DbSet<Flight>>();

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(m => m.Flights).Returns(mockSet.Object);

        //    var service = new FlightBusiness(mockSet.Object);
        //    service.AddFlight(new Flight());

        //    mockSet.Verify(x => x.Add(It.IsAny<Flight>()), Times.Once());
        //    mockContext.Verify(m => m.SaveChanges(), Times.Once());
        //}
        //[Test]
        //public void GetAllFlights()
        //{
        //    var data = new List<Flight>
        //    {
        //        new Flight{ Destination = "Sofia, Bulgaria"},
        //        new Flight{ Destination = "Sarajevo, Bosnia and Herzegovina"},
        //        new Flight{ Destination= "Tirana, Albania"},
        //    }.AsQueryable();

        //    var mockSet = new Mock<DbSet<Flight>>();
        //    mockSet.As<IQueryable<Flight>>().Setup(x => x.Provider).Returns(data.Provider);
        //    mockSet.As<IQueryable<Flight>>().Setup(x => x.Expression).Returns(data.Expression);
        //    mockSet.As<IQueryable<Flight>>().Setup(x => x.ElementType).Returns(data.ElementType);
        //    mockSet.As<IQueryable<Flight>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(x => x.Flights).Returns(mockSet.Object);

        //    var service = new FlightBusiness(mockContext.Object);
        //    var flightsFound = service.FlightGetAll();

        //    Assert.AreEqual(3, flightsFound.Count());
        //    Assert.AreEqual("Sofia, Bulgaria", flightsFound[0].Destination);
        //    Assert.AreEqual("Sarajevo, Bosnia and Herzegovina", flightsFound[1].Destination);
        //    Assert.AreEqual("Tirana, Albania", flightsFound[2].Destination);
        //}
        //[Test]
        //public void GetFlight()
        //{
        //    var data = new List<Flight>
        //    {
        //        new Flight{ Id = 1, Destination = "Sofia, Bulgaria"},
        //        new Flight{ Destination = "Sarajevo, Bosnia and Herzegovina"},
        //        new Flight{ Destination= "Tirana, Albania"},
        //    }.AsQueryable();

        //    var mockSet = new Mock<DbSet<Flight>>();
        //    mockSet.As<IQueryable<Flight>>().Setup(x => x.Provider).Returns(data.Provider);
        //    mockSet.As<IQueryable<Flight>>().Setup(x => x.Expression).Returns(data.Expression);
        //    mockSet.As<IQueryable<Flight>>().Setup(x => x.ElementType).Returns(data.ElementType);
        //    mockSet.As<IQueryable<Flight>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(x => x.Flights).Returns(mockSet.Object);

        //    var service = new FlightBusiness(mockContext.Object);
        //    var flightsFound = service.GetFlight(1);

        //    Assert.AreEqual(1, flightsFound.Count());
        //    Assert.AreEqual(1, flightsFound[0].Id);
        //}
    }
}