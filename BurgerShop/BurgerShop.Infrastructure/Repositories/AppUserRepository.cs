using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;

namespace BurgerShop.Infrastructure.Repositories
{
    public class AppUserRepository : BaseRepository<AppUser>
    {
        private readonly AppDbContext _context;
        public AppUserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
