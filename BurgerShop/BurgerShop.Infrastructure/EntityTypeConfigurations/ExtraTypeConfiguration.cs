using BurgerShop.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerShop.Infrastructure.EntityTypeConfigurations
{
    public class ExtraTypeConfiguration : IEntityTypeConfiguration<Extra>
    {
        public void Configure(EntityTypeBuilder<Extra> builder)
        {
            builder.Property(e => e.ExtraName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ExtraPrice)
                .IsRequired()
                .HasColumnType("decimal(4,2)")
                .HasPrecision(4, 2);
        }
    }
}
