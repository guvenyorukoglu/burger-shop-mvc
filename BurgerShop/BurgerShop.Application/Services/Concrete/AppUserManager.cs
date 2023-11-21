using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Services.Concrete
{
    public class AppUserManager : BaseManager<AppUser>
    {
        private readonly IBaseRepository<AppUser> _baseRepository;
        public AppUserManager(Domain.Repositories.IBaseRepository<AppUser> repository) : base(repository)
        {
            _baseRepository = repository;
        }
    }
}
