using BurgerShop.DAL.Context;
using BurgerShop.DAL.Repositories.Abstract;
using BurgerShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.DAL.Repositories.Concrete
{
    public class OrderRepository : BaseRepository<Order>, ISoftDeletable
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public bool SoftDelete(object id)
        {
            Order orderToSoftDelete = _context.Orders.Find((Guid)id);
            if (orderToSoftDelete.Status == Entities.Enums.Status.Active)
            {
                orderToSoftDelete.Status = Entities.Enums.Status.Inactive;
                return true;
            }
            else
                return false;
        }
    }
}
