using InvoiceManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceManagement.Persistence.EntitiesMapping
{
    public class HomeMapping : IEntityTypeConfiguration<Home>
    {
        public void Configure(EntityTypeBuilder<Home> builder)
        {
            builder.Property(h => h.DoorNumber).HasMaxLength(10);
            builder.Property(h => h.FloorNumber).HasMaxLength(3);
            builder.Property(h => h.RoomCount).HasMaxLength(2);
            builder.Property(h => h.FullAddress).HasMaxLength(1000);


            builder.HasOne(h => h.LandLord)
                   .WithMany(h => h.LandlordHomes)
                   .HasForeignKey(h => h.LandlordId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(h => h.Resident)
                   .WithOne(h => h.ResidentHome)
                   .HasForeignKey<Home>(h => h.ResidentId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Homes");
        }
    }
}


