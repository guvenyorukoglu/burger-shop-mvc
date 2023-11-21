using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.Concrete
{
    public class ExtraManager : BaseManager<Extra>
    {
        private readonly IBaseRepository<Extra> _repository;
        public ExtraManager(IBaseRepository<Extra> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
