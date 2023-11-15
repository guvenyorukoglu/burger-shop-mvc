using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;

namespace BurgerShop.Domain.Entities.Abstract
{
    public interface IBaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public AppUser? CreatedBy { get; set; }
        public Status Status { get; set; }
    }
}
