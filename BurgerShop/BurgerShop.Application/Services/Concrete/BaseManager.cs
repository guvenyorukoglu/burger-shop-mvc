using BurgerShop.Application.Services.Abstract;
using BurgerShop.Domain.Entities.Abstract;
using BurgerShop.Domain.Enums;
using BurgerShop.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace BurgerShop.Application.Services.Concrete
{
    public class BaseManager<T> : IBaseService<T> where T : class, IBaseEntity, new()
    {
        private readonly IBaseRepository<T> _repository;

        public BaseManager(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Any(Expression<Func<T, bool>> expression)
        {
            return await _repository.Any(expression);
        }

        public Task Delete(Guid id)
        {
            T entity = _repository.GetById(id);
            entity.Status = Status.Deleted;
            entity.DeletedDate = DateTime.Now;
            return _repository.Delete(id);
        }

        public Task<List<T>> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public async Task<T> GetDefault(Expression<Func<T, bool>> expression)
        {
            return await _repository.GetDefault(expression);
        }

        public Task<List<T>> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _repository.GetDefaults(expression);
        }

        public async Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await _repository.GetFilteredFirstOrDefault(select, where, orderBy, include);
        }

        public async Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await _repository.GetFilteredList(select, where, orderBy, include);
        }

        public async Task<T> GetSingleDefault(Expression<Func<T, bool>> expression)
        {
            return await _repository.GetSingleDefault(expression);
        }

        public Task Insert(T entity)
        {
            return _repository.Insert(entity);
        }

        public Task Update(T entity)
        {
            entity.ModifiedDate = DateTime.Now;
            return _repository.Update(entity);
        }
    }
}
