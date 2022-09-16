using API.Models;
using API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UnitTest_Order_Management
{
    // Document: https://docs.microsoft.com/en-us/ef/core/testing/testing-with-the-database
    public class TestDatabaseFixture
    {
        private const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=OrderManagementAPIDB;Trusted_Connection=True;MultipleActiveResultSets=true";

        private static readonly object _lock = new();
        private static bool _databaseInitialized;

        public TestDatabaseFixture()
        {
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    using (var context = CreateContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();

                        context.AddRange(
                            new Supplier
                            {
                                SupplierName = "Supplier1",
                                AddressLine1 = "132 Ride str",
                                AddressLine2 = "apt 3",
                                City = "Yerevan",
                                PostalCode = 111,
                                State = "Available",
                            },
                            new Supplier
                            {
                                SupplierName = "Supplier2",
                                AddressLine1 = "132 Ride str",
                                AddressLine2 = "apt 3",
                                City = "Yerevan",
                                PostalCode = 111,
                                State = "Available",
                            });
                        context.SaveChanges();
                    }

                    _databaseInitialized = true;
                }
            }
        }

        public ApplicationDbContext CreateContext()
            => new ApplicationDbContext(
                new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlServer(ConnectionString)
                    .Options);
    }
}
