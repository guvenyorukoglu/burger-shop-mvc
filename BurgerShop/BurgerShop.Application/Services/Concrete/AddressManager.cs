using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class AddressManager : BaseManager<Address> 
    {
        public AddressManager(IBaseRepository<Address> repository) : base(repository)
        {
        }

    }
}
