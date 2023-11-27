using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;

namespace BurgerShop.Infrastructure.Repositories
{
    public class ExtraRepository : BaseRepository<Extra>
    {
        public ExtraRepository(AppDbContext context) : base(context)
        {
        }

    }
}
