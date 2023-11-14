namespace BurgerShop.DAL.Repositories.Abstract
{
    public interface ISoftDeletable
    {
        /// <summary>
        /// Makes soft deletion the entity by it's identifier. Sets it's status to inactive. Does not delete the entity from database.
        /// </summary>
        /// <param name="id">Identifier as int or Guid</param>
        /// <returns>Returns true if the delete operation is succeeded. If not, returns false.</returns>
        bool SoftDelete(object id);
    }
}
