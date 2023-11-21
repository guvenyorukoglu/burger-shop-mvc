using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class AddressManager : BaseManager<Address> 
    {

        private readonly IBaseRepository<Address> _repository;


        public AddressManager(IBaseRepository<Address> repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
