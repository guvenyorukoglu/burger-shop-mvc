using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;

namespace BurgerShop.Infrastructure.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }
    }
}
