using BurgerShop.Domain.Entities.Abstract;
using BurgerShop.Domain.Enums;

namespace BurgerShop.Domain.Entities.Concrete
{
    public abstract class BaseEntity : IBaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
