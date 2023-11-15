using BurgerShop.DAL.Context;
using BurgerShop.DAL.Repositories.Concrete;
using BurgerShop.Entities.Concrete;

namespace BurgerShop.DAL.Repositories
{
    public class AddressRepository : BaseRepository<Address>
    {
        private readonly AppDbContext _context;
        public AddressRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
