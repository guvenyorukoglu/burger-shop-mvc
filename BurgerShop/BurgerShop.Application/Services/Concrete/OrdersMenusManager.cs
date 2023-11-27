using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class OrdersMenusManager : BaseManager<OrdersMenus>
    {
        public OrdersMenusManager(IBaseRepository<OrdersMenus> repository) : base(repository)
        {
        }
    }
}
