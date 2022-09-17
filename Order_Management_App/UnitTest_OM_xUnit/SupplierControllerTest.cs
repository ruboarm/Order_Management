using API.Controllers;
using API.Data;
using API.Models;
using System;
using System.Linq;
using UnitTest_OM_xUnit.CustomOrderer;
using UnitTest_Order_Management;
using Xunit;

namespace UnitTest_OM_xUnit
{
    [TestCaseOrderer("UnitTest_OM_xUnit.Orderers.AlphabeticalOrderer", "UnitTest_OM_xUnit")]
    public class SupplierControllerTest : IClassFixture<TestDatabaseFixture>
    {
        public SupplierControllerTest(TestDatabaseFixture fixture)
            => Fixture = fixture;

        public TestDatabaseFixture Fixture { get; }


        [Fact]
        //[TestPriority(1)]
        public void Test1Post()
        {
            using var context = Fixture.CreateContext();
            var controller = new SuppliersController(context);

            var supplier = new Supplier()
            {
                SupplierName = "xUnitTest",
                AddressLine1 = "489 Ayre str",
                AddressLine2 = "apt 2",
                City = "Yerevan",
                PostalCode = 777,
                State = "Available",
            };
            var createdSupplier = controller.Post(supplier).Result;

            Assert.Equal("Yerevan", createdSupplier.City);
        }

        [Fact]
        //[TestPriority(2)]
        public void Test2Get()
        {
            using var context = Fixture.CreateContext();
            var controller = new SuppliersController(context);

            var suppliers = controller.Get().Result;

            Assert.Equal(1, suppliers.Count(s => s.SupplierName.Equals("xUnitTest")));
        }

        [Fact]
        //[TestPriority(3)]
        public void Test3GetById()
        {
            using var context = Fixture.CreateContext();
            var controller = new SuppliersController(context);

            var suppliers = controller.Get().Result;
            var id = suppliers.FirstOrDefault(s => s.SupplierName == "xUnitTest").Id;
            var supplier = controller.Get(id).Result;

            Assert.Equal("xUnitTest", supplier.SupplierName);
        }

        [Fact]
        //[TestPriority(4)]
        public void Test4Put()
        {
            using var context = Fixture.CreateContext();
            var controller = new SuppliersController(context);

            var suppliers = controller.Get().Result;
            var supplier = suppliers.FirstOrDefault(s => s.SupplierName == "xUnitTest");
            supplier.City = "Armavir";
            var updatedSupplier = controller.Put(supplier.Id, supplier).Result;

            Assert.Equal("Armavir", updatedSupplier.City);
        }

        [Fact]
        //[TestPriority(5)]
        public void Test5Delete()
        {
            using var context = Fixture.CreateContext();
            var controller = new SuppliersController(context);

            var suppliers = controller.Get().Result;
            var supplier = suppliers.FirstOrDefault(s => s.SupplierName == "xUnitTest");
            var code = controller.Delete(supplier.Id).Result;

            Assert.True(true, code.ToString());
        }
    }
}
