namespace BurgerShop.DAL.Repositories.Abstract
{
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// Insert the entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns true if the insert operation is succeeded. If not, returns false.</returns>
        bool Insert(T entity);

        /// <summary>
        /// Makes hard deletion the entity by it's identifier from database forever.
        /// </summary>
        /// <param name="id">Identifier as int or Guid</param>
        /// <returns>Returns true if the hard delete operation is succeeded. If not, returns false.</returns>
        bool HardDelete(object id);

        /// <summary>
        /// Update the entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns true if the update operation is succeeded. If not, returns false.</returns>
        bool Update(T entity);

        /// <summary>
        /// Gets all entities. 
        /// </summary>
        /// <returns>Returns list of the entities.</returns>
        List<T> GetAll();

        /// <summary>
        /// Gets the entity by it's identifier.
        /// </summary>
        /// <param name="id">Identifier as int or Guid</param>
        /// <returns>Returns the entity.</returns>
        T GetById(object id);
    }
}
