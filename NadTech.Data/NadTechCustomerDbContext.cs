using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NadTech.Core.Entities;

namespace NadTech.Data
{
    public class NadTechCustomerDbContext : DbContext
    {
        public NadTechCustomerDbContext(DbContextOptions<NadTechCustomerDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
