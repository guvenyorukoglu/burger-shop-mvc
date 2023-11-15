using BurgerShop.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerShop.Infrastructure.EntityTypeConfigurations
{
    public class OrderDetailTypeConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Property(od => od.MenuPrice)
                .IsRequired()
                .HasColumnType("decimal(4,2)")
                .HasPrecision(4, 2);

            builder.Property(od => od.ExtraPrice)
                .IsRequired(false)
                .HasColumnType("decimal(4,2)")
                .HasPrecision(4, 2);

            builder.Property(od => od.TotalPrice)
                .IsRequired(true)
                .HasColumnType("decimal(18,2)")
                .HasPrecision(18, 2);

            builder.HasMany(od => od.Menus).WithOne(m => m.OrderDetail).HasForeignKey(m => m.OrderDetailId);

            builder.HasMany(od => od.Extras).WithOne(e => e.OrderDetail).HasForeignKey(e => e.OrderDetailId);
        }
    }
}
