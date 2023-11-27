using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class OrdersExtrasManager : BaseManager<OrdersExtras>
    {
        public OrdersExtrasManager(IBaseRepository<OrdersExtras> repository) : base(repository)
        {
        }
    }
}
