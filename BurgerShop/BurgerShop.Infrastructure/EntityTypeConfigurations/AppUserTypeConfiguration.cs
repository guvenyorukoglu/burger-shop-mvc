using BurgerShop.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerShop.Infrastructure.EntityTypeConfigurations
{
    public class AppUserTypeConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasMany(u => u.Orders).WithOne(o => o.AppUser).HasForeignKey(o => o.AppUserId);

            builder.HasMany(u => u.Addresses).WithOne(a => a.AppUser).HasForeignKey(a => a.AppUserId);
        }
    }
}
