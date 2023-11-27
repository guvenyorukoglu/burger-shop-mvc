using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class MenuManager : BaseManager<Menu>
    {
        public MenuManager(IBaseRepository<Menu> repository) : base(repository)
        {
        }
    }
}
