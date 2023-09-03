using InvoiceManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceManagement.Persistence.EntitiesMapping
{
    public class ElectricityBillMapping : IEntityTypeConfiguration<ElectricityBill>
    {
        public void Configure(EntityTypeBuilder<ElectricityBill> builder)
        {
            builder.ToTable("ElectricityBills");
        }
    }
}
