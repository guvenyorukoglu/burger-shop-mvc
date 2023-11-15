using BurgerShop.DAL.Context;
using BurgerShop.DAL.Repositories.Concrete;
using BurgerShop.Entities.Concrete;

namespace BurgerShop.DAL.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
