namespace BurgerShop.Entities.Abstract
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
