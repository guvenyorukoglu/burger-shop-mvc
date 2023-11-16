using BurgerShop.Domain.Entities.Abstract;

namespace BurgerShop.Domain.Entities.Concrete
{
    public class Address : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string FullAddress { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public static implicit operator Task<object>(Address v)
        {
            throw new NotImplementedException();
        }
    }
}
