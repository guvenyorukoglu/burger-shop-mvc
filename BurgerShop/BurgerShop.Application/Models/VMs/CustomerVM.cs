using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;

namespace BurgerShop.Application.Models.VMs
{
    public class CustomerVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public string Phone { get; set; }
        public string? ProfileImagePath { get; set; }

        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Order>? Orders { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Status Status { get; set; }
    }
}
