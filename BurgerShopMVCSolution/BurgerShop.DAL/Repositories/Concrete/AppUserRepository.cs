using BurgerShop.DAL.Context;
using BurgerShop.DAL.Repositories.Abstract;
using BurgerShop.Entities.Concrete;

namespace BurgerShop.DAL.Repositories.Concrete
{
    public class AppUserRepository : BaseRepository<AppUser>, ISoftDeletable
    {
        private readonly AppDbContext _context;
        public AppUserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public bool SoftDelete(object id)
        {
            AppUser userToSoftDelete = _context.Users.Find((Guid)id);
            if (userToSoftDelete.Status == Entities.Enums.Status.Active)
            {
                userToSoftDelete.Status = Entities.Enums.Status.Inactive;
                return true;
            }
            else
                return false;
        }
    }
}
