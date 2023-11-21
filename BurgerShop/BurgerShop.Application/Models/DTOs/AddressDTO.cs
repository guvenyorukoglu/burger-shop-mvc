using System.ComponentModel.DataAnnotations;

namespace BurgerShop.Application.Models.DTOs
{
    public class AddressDTO
    {
        [Required]
        public string FullAddress { get; set; }

        public Guid Id { get; set; }

    }
}
