using InvoiceManagement.Domain.Entities;
using InvoiceManagement.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<EntityEntry<BaseEntity>> datas = ChangeTracker.Entries<BaseEntity>();

            foreach (EntityEntry<BaseEntity> data in datas)
            {
                if (data.State == EntityState.Added)
                {
                    data.Entity.CreatedDate = DateTime.UtcNow;
                    data.Entity.IsActive = true;
                }
                else if (data.State == EntityState.Modified)
                    data.Entity.UpdatedDate = DateTime.UtcNow;
            }


            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
