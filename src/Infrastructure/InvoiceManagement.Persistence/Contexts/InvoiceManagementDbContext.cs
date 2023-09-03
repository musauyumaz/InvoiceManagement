using InvoiceManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InvoiceManagement.Persistence.Contexts
{
    public class InvoiceManagementDbContext : DbContext
    {
        public InvoiceManagementDbContext(DbContextOptions<InvoiceManagementDbContext> options) : base(options) { }

        public DbSet<Home> Homes { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<ElectricityBill> ElectricityBills { get; set; }
        public DbSet<NaturalGasBill> NaturalGasBills { get; set; }
        public DbSet<WaterBill> WaterBills { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
