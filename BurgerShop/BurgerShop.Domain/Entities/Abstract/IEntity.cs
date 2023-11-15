namespace BurgerShop.Domain.Entities.Abstract
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
