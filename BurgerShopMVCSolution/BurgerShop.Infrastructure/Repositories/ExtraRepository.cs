using BurgerShop.DAL.Context;
using BurgerShop.DAL.Repositories.Concrete;
using BurgerShop.Entities.Concrete;

namespace BurgerShop.DAL.Repositories
{
    public class ExtraRepository : BaseRepository<Extra>
    {
        private readonly AppDbContext _context;
        public ExtraRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
