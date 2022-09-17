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
                    #region In case of database recreation and direct data filling
                    using (var context = CreateContext())
                    {
                        // Ensure database created with migration
                        context.Database.Migrate();

                        var existing = context.Suppliers.FirstOrDefault(s => s.SupplierName == "xUnitTest");
                        if(existing != null)
                            context.Remove(existing);

                        context.SaveChanges();
                    }
                    #endregion

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
