using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class ExtraManager : BaseManager<Extra>
    {
        public ExtraManager(IBaseRepository<Extra> repository) : base(repository)
        {
        }
    }
}
