using BurgerShop.DAL.Context;
using BurgerShop.DAL.Repositories.Concrete;
using BurgerShop.Entities.Concrete;

namespace BurgerShop.DAL.Repositories
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
