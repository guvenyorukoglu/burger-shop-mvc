using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class MenuManager : BaseManager<Menu>
    {
        private readonly IBaseRepository<Menu> _repository;
        public MenuManager(IBaseRepository<Menu> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
