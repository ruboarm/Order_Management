using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Order_Management_Blazor_Server.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order_Management_Blazor_Server.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<IdentityUser>()
            //    .ToTable("AspNetUsers", t => t.ExcludeFromMigrations());
            modelBuilder.Entity<Supplier>().ToTable("Suppliers");
        }
    }
}
