using BurgerShop.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerShop.Infrastructure.EntityTypeConfigurations
{
    public class OrderTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.Notes)
                .IsRequired(false)
                .HasMaxLength(100);

            builder.Property(o => o.ShippedAddress)
                .IsRequired()
                .HasMaxLength(200);

        }
    }
}
