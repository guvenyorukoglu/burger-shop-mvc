using BurgerShop.DAL.Context;
using BurgerShop.DAL.Repositories.Abstract;
using BurgerShop.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.DAL.Repositories.Concrete
{
    public class AddressRepository : BaseRepository<Address>, ISoftDeletable
    {
        private readonly AppDbContext _context;
        public AddressRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public bool SoftDelete(object id)
        {
            Address addressToSoftDelete = _context.Addresses.Find((int)id);
            if (addressToSoftDelete.Status == Entities.Enums.Status.Active)
            {
                addressToSoftDelete.Status = Entities.Enums.Status.Inactive;
                return true;
            }
            else
                return false;
        }
    }
}
