using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class AppUserManager : BaseManager<AppUser>
    {
        public AppUserManager(IBaseRepository<AppUser> repository) : base(repository)
        {
        }
    }
}
