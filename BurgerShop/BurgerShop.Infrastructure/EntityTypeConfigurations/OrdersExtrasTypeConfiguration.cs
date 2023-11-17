using BurgerShop.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerShop.Infrastructure.EntityTypeConfigurations
{
    public class OrdersExtrasTypeConfiguration : IEntityTypeConfiguration<OrdersExtras>
    {
        public void Configure(EntityTypeBuilder<OrdersExtras> builder)
        {
            builder.HasKey(oe => new { oe.OrderId, oe.ExtraId });
            builder.HasOne(oe => oe.Order).WithMany(o => o.OrdersExtras).HasForeignKey(oe => oe.OrderId);
            builder.HasOne(oe => oe.Extra).WithMany(m => m.OrdersExtras).HasForeignKey(oe => oe.ExtraId);

            builder.Property(oe => oe.ExtraPrice)
                .IsRequired()
                .HasColumnType("decimal(4,2)")
                .HasPrecision(4, 2);

            builder.Property(oe => oe.ExtraTotalPrice)
                .IsRequired()
                .HasColumnType("decimal(18,2)")
                .HasPrecision(18, 2);
        }
    }
}
