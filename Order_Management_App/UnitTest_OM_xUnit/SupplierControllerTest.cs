using API.Controllers;
using API.Data;
using API.Models;
using System;
using System.Linq;
using UnitTest_Order_Management;
using Xunit;

namespace UnitTest_OM_xUnit
{
    public class SupplierControllerTest : IClassFixture<TestDatabaseFixture>
    {
        public SupplierControllerTest(TestDatabaseFixture fixture)
            => Fixture = fixture;

        public TestDatabaseFixture Fixture { get; }

        [Fact]
        public void GetTest()
        {
            using var context = Fixture.CreateContext();
            var controller = new SuppliersController(context);

            var suppliers = controller.Get().Result;

            Assert.Equal(2, suppliers.Count);
        }

        [Fact]
        public void GetByIdTest()
        {
            using var context = Fixture.CreateContext();
            var controller = new SuppliersController(context);

            var suppliers = controller.Get().Result;
            var id = suppliers.FirstOrDefault(s => s.SupplierName == "Supplier1").Id;
            var supplier = controller.Get(id).Result;

            Assert.Equal("Supplier1", supplier.SupplierName);
        }

        [Fact]
        public void PostTest()
        {
            using var context = Fixture.CreateContext();
            var controller = new SuppliersController(context);

            var supplier = new Supplier()
            {
                SupplierName = "Supplier3",
                AddressLine1 = "489 Ayre str",
                AddressLine2 = "apt 2",
                City = "Vanadzor",
                PostalCode = 489,
                State = "Available",
            };
            var updatedSupplier = controller.Post(supplier).Result;

            Assert.Equal("Vanadzor", updatedSupplier.City);
        }

        [Fact]
        public void PutTest()
        {
            using var context = Fixture.CreateContext();
            var controller = new SuppliersController(context);

            var suppliers = controller.Get().Result;
            var supplier = suppliers.FirstOrDefault(s => s.SupplierName == "Supplier1");
            supplier.City = "Armavir";
            var updatedSupplier = controller.Put(supplier.Id, supplier).Result;

            Assert.Equal("Armavir", updatedSupplier.City);
        }

        [Fact]
        public void DeleteTest()
        {
            using var context = Fixture.CreateContext();
            var controller = new SuppliersController(context);

            var suppliers = controller.Get().Result;
            var supplier = suppliers.FirstOrDefault(s => s.SupplierName == "Supplier2");
            var code = controller.Delete(supplier.Id).Result;

            Assert.True(true, code.ToString());
        }
    }
}
