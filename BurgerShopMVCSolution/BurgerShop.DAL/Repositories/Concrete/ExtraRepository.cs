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
    public class ExtraRepository : BaseRepository<Extra>, ISoftDeletable
    {
        private readonly AppDbContext _context;
        public ExtraRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public bool SoftDelete(object id)
        {
            Extra extraToSoftDelete = _context.Extras.Find((int)id);
            if (extraToSoftDelete.Status == Entities.Enums.Status.Active)
            {
                extraToSoftDelete.Status = Entities.Enums.Status.Inactive;
                return true;
            }
            else
                return false;
        }
    }
}
