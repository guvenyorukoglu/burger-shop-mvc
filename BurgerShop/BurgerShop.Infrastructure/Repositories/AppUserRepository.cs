using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;

namespace BurgerShop.Infrastructure.Repositories
{
    public class AppUserRepository : BaseRepository<AppUser>
    {
        public AppUserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
