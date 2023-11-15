using BurgerShop.Domain.Entities.Abstract;

namespace BurgerShop.Domain.Entities.Concrete
{
    public class Address : BaseEntity, IEntity<int>
    {
        public int Id { get; set; }
        public string FullAddress { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
