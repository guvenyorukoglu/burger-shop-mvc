using BurgerShop.Entities.Abstract;
using BurgerShop.Entities.Enums;

namespace BurgerShop.Entities.Concrete
{
    public abstract class BaseEntity : IBaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public AppUser? CreatedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
