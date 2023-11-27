using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;

namespace BurgerShop.Infrastructure.Repositories
{
    public class MenuRepository : BaseRepository<Menu>
    {
        public MenuRepository(AppDbContext context) : base(context)
        {
        }
    }
}
