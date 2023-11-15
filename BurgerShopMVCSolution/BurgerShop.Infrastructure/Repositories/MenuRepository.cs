using BurgerShop.DAL.Context;
using BurgerShop.DAL.Repositories.Concrete;
using BurgerShop.Entities.Concrete;

namespace BurgerShop.DAL.Repositories
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
