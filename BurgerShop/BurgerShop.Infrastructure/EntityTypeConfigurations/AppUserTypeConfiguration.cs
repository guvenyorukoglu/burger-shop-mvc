using BurgerShop.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerShop.Infrastructure.EntityTypeConfigurations
{
    public class AppUserTypeConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            

            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(20);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(30);

            builder.HasMany(u => u.Orders).WithOne(o => o.AppUser).HasForeignKey(o => o.AppUserId);
            builder.HasMany(u => u.Addresses).WithOne(a => a.AppUser).HasForeignKey(a => a.AppUserId);
        }
    }
}
