using BurgerShop.Entities.Concrete;
using BurgerShop.Entities.Enums;

namespace BurgerShop.Entities.Abstract
{
    public interface IBaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public AppUser CreatedBy { get; set; }
        public Status Status { get; set; }
    }
}
