using BurgerShop.DAL.Context;
using BurgerShop.DAL.Repositories.Abstract;

namespace BurgerShop.DAL.Repositories.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }
        public bool Insert(T entity)
        {
            _context.Add(entity);
            return _context.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            _context.Update(entity);
            return _context.SaveChanges() > 0;
        }

        public bool HardDelete(object id)
        {
            var entityToHardDelete = _context.Set<T>().Find(id);
            if (entityToHardDelete != null)
            {
                _context.Remove(entityToHardDelete);
                return _context.SaveChanges() > 0;
            }
            return false;
        }
    }
}
