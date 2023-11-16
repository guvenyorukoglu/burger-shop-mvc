using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class OrderDetailManager : BaseManager<OrderDetail>
    {
        public OrderDetailManager(IBaseRepository<OrderDetail> repository) : base(repository)
        {
        }
    }
}
