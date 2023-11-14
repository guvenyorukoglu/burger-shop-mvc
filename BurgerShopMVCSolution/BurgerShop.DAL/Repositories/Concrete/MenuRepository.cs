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
    public class MenuRepository : BaseRepository<Menu>, ISoftDeletable
    {
        private readonly AppDbContext _context;
        public MenuRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public bool SoftDelete(object id)
        {
            Menu menuToSoftDelete = _context.Menus.Find((int)id);
            if (menuToSoftDelete.Status == Entities.Enums.Status.Active)
            {
                menuToSoftDelete.Status = Entities.Enums.Status.Inactive;
                return true;
            }
            else
                return false;
        }
    }
}
