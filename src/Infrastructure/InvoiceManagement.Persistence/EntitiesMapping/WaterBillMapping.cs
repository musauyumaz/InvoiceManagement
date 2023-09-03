using InvoiceManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceManagement.Persistence.EntitiesMapping
{
    public class WaterBillMapping : IEntityTypeConfiguration<WaterBill>
    {
        public void Configure(EntityTypeBuilder<WaterBill> builder)
        {
            builder.ToTable("WaterBills");
        }
    }


}


