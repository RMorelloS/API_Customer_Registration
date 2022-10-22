using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Customer_Registration.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Customer_Registration.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {}

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().ToTable("Customers");
        }
    }
}
