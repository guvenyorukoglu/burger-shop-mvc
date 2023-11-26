using BurgerShop.Domain.Enums;

namespace BurgerShop.Application.Models.VMs
{
    public class MenuVM
    {

        public Guid MenuId { get; set; }
        public string MenuName { get; set; }
        public decimal MenuPrice { get; set; }
        public MenuSize MenuSize { get; set; }
        public string MenuImagePath { get; set; }

    }
}