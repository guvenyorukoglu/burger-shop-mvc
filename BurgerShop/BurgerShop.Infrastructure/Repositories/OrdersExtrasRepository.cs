using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Infrastructure.Repositories
{
    public class OrdersExtrasRepository : BaseRepository<OrdersExtras>
    {
        public OrdersExtrasRepository(AppDbContext context) : base(context)
        {
        }
    }
}
