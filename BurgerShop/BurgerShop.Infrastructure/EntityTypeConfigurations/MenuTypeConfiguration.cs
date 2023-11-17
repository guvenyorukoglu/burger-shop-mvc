using BurgerShop.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerShop.Infrastructure.EntityTypeConfigurations
{
    public class MenuTypeConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(m => m.MenuName)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(m => m.MenuPrice)
                .IsRequired()
                .HasColumnType("decimal(4,2)")
                .HasPrecision(4, 2);

            builder.HasAlternateKey(m => new { m.MenuName, m.MenuSize });
        }
    }
}
