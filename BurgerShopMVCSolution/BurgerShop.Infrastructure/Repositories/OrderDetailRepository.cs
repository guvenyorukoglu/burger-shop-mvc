using BurgerShop.DAL.Context;
using BurgerShop.DAL.Repositories.Concrete;
using BurgerShop.Entities.Concrete;

namespace BurgerShop.DAL.Repositories.Concrete
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>
    {
        private readonly AppDbContext _context;
        public OrderDetailRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
