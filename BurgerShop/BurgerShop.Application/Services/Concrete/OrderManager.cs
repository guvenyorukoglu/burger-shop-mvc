using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class OrderManager : BaseManager<Order>
    {
        private readonly IBaseRepository<Order> _repository;
        public OrderManager(IBaseRepository<Order> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
