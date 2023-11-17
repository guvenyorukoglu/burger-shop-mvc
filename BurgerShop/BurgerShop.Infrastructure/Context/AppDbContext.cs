using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.EntityTypeConfigurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BurgerShop.Infrastructure.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrdersMenus> OrdersMenus { get; set; }
        public DbSet<OrdersExtras> OrdersExtras { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AddressTypeConfiguration())
                .ApplyConfiguration(new AppUserTypeConfiguration())
                .ApplyConfiguration(new ExtraTypeConfiguration())
                .ApplyConfiguration(new MenuTypeConfiguration())
                .ApplyConfiguration(new OrderTypeConfiguration())
                .ApplyConfiguration(new OrdersMenusTypeConfiguration())
                .ApplyConfiguration(new OrdersExtrasTypeConfiguration());
        }
    }
}
