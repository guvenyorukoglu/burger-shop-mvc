using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;

namespace BurgerShop.Infrastructure.Repositories
{
    public class AddressRepository : BaseRepository<Address>
    {
        public AddressRepository(AppDbContext context) : base(context)
        {
        }
    }
}
