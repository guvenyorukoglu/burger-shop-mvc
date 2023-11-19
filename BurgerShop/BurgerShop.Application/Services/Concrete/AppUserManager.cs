using BurgerShop.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Services.Concrete
{
    public class AppUserManager : BaseManager<AppUser>
    {
        public AppUserManager(Domain.Repositories.IBaseRepository<AppUser> repository) : base(repository)
        {
        }
    }
}
