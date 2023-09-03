using InvoiceManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceManagement.Persistence.EntitiesMapping
{
    public class BlockMapping : IEntityTypeConfiguration<Block>
    {
        public void Configure(EntityTypeBuilder<Block> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(50);
            builder.Property(b => b.FloorCount).HasMaxLength(3);

            builder.ToTable("Blocks");
        }
    }
}
