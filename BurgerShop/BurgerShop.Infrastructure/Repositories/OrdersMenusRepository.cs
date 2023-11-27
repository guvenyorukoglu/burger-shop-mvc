using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;

namespace BurgerShop.Infrastructure.Repositories
{
    public class OrdersMenusRepository : BaseRepository<OrdersMenus>
    {
        public OrdersMenusRepository(AppDbContext context) : base(context)
        {
        }
    }
}
