using BurgerShop.Application.Services.Abstract;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;
using BurgerShop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
