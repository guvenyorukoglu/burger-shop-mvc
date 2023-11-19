using BurgerShop.Domain.Entities.Abstract;
using BurgerShop.Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurgerShop.Domain.Entities.Concrete
{
    public class AppUser : IdentityUser<Guid>, IBaseEntity
    {
        public AppUser()
        {
            Addresses = new List<Address>();
            Orders = new List<Order>();
        }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Status Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public string? ProfileImagePath { get; set; }

        [NotMapped]
        public IFormFile ProfileUploadPath { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
