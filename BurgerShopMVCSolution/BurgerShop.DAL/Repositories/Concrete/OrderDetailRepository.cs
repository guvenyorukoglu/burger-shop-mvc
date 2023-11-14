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
    public class OrderDetailRepository : BaseRepository<OrderDetail>, ISoftDeletable
    {
        private readonly AppDbContext _context;
        public OrderDetailRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public bool SoftDelete(object id)
        {
            OrderDetail orderDetailToSoftDelete = _context.OrderDetails.Find((Guid)id);
            Order orderToSoftDelete = _context.Orders.Find(orderDetailToSoftDelete.OrderId);
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
