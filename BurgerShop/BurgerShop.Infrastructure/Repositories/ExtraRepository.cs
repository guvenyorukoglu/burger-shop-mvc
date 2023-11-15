using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;

namespace BurgerShop.Infrastructure.Repositories
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
