using InvoiceManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceManagement.Persistence.EntitiesMapping
{
    public class NaturalGasBillMapping : IEntityTypeConfiguration<NaturalGasBill>
    {
        public void Configure(EntityTypeBuilder<NaturalGasBill> builder)
        {
            builder.ToTable("NaturalGasBills");
        }
    }
}
