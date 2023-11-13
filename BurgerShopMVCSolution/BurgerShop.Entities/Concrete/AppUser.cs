using BurgerShop.Entities.Abstract;
using BurgerShop.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace BurgerShop.Entities.Concrete
{
    public class AppUser : IdentityUser<Guid>, IBaseEntity
    {
        public AppUser()
        {
            Addresses = new List<Address>();
            Orders = new List<Order>();
        }
        public DateTime CreatedDate { get; set; } = DateTime.Now; 
        public DateTime? ModifiedDate { get; set; }
        public AppUser? CreatedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Order>? Orders { get; set; }

    }


    
}
