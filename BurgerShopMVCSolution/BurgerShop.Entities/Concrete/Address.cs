using BurgerShop.Entities.Abstract;

namespace BurgerShop.Entities.Concrete
{
    public class Address : BaseEntity, IEntity<int>
    {
        public int Id { get; set; }
        public string FullAddress { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
