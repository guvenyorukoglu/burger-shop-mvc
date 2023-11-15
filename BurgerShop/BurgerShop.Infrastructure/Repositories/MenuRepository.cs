using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;

namespace BurgerShop.Infrastructure.Repositories
{
    public class MenuRepository : BaseRepository<Menu>
    {
        private readonly AppDbContext _context;
        public MenuRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
