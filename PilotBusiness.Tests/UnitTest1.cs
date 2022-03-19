using Business.ModelsBusiness;
using Data;
using Data.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Pilots.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void AddPilot()
        //{
        //    var mockSet = new Mock<DbSet<Pilot>>();

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(m => m.Pilots).Returns(mockSet.Object);

        //    var service = new PilotBusiness(mockSet.Object);
        //    service.AddPilot(new Pilot());

        //    mockSet.Verify(x => x.Add(It.IsAny<Pilot>()), Times.Once());
        //    mockContext.Verify(m => m.SaveChanges(), Times.Once());
        //}
        //[Test]
        //public void GetAllPilots()
        //{
        //    var data = new List<Pilot>
        //    {
        //        new Pilot{ Name = "Pilot1"},
        //        new Pilot{ Name = "Pilot2"},
        //        new Pilot{ Name = "Pilot3"},
        //    }.AsQueryable();

        //    var mockSet = new Mock<DbSet<Pilot>>();
        //    mockSet.As<IQueryable<Pilot>>().Setup(x => x.Provider).Returns(data.Provider);
        //    mockSet.As<IQueryable<Pilot>>().Setup(x => x.Expression).Returns(data.Expression);
        //    mockSet.As<IQueryable<Pilot>>().Setup(x => x.ElementType).Returns(data.ElementType);
        //    mockSet.As<IQueryable<Pilot>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(x => x.Pilots).Returns(mockSet.Object);

        //    var service = new PilotBusiness(mockContext.Object);
        //    var pilotsFound = service.PilotGetAll();

        //    Assert.AreEqual(3, pilotsFound.Count());
        //    Assert.AreEqual("Pilot1", pilotsFound[0].Name);
        //    Assert.AreEqual("Pilot2", pilotsFound[1].Name);
        //    Assert.AreEqual("Pilot3", pilotsFound[2].Name);
        //}
        //[Test]
        //public void GetPilot()
        //{
        //    var data = new List<Pilot>
        //    {
        //        new Pilot{ Name = "Pilot1"},
        //        new Pilot{ Name = "Pilot2"},
        //        new Pilot{ Name = "Pilot3"},
        //    }.AsQueryable();

        //    var mockSet = new Mock<DbSet<Pilot>>();
        //    mockSet.As<IQueryable<Pilot>>().Setup(x => x.Provider).Returns(data.Provider);
        //    mockSet.As<IQueryable<Pilot>>().Setup(x => x.Expression).Returns(data.Expression);
        //    mockSet.As<IQueryable<Pilot>>().Setup(x => x.ElementType).Returns(data.ElementType);
        //    mockSet.As<IQueryable<Pilot>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<AirlineManagmentContext>();
        //    mockContext.Setup(x => x.Pilots).Returns(mockSet.Object);

        //    var service = new PilotBusiness(mockContext.Object);
        //    var pilotsFound = service.GetPilot(1);

        //    Assert.AreEqual(1, pilotsFound.Count());
        //    Assert.AreEqual(1, pilotsFound[0].Id);
        //}
    }
}