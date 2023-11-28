using BurgerShop.Domain.Entities.Abstract;
using BurgerShop.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurgerShop.Domain.Entities.Concrete
{
    public class Menu : BaseEntity, IEntity<Guid>
    {
        public Menu()
        {
            OrdersMenus = new List<OrdersMenus>();
        }
        public Guid Id { get; set; }
        public string MenuName { get; set; }

        private decimal _menuPrice;

        public decimal MenuPrice
        {
            get { return _menuPrice; }
            set { _menuPrice = (value < 0) ? 0 : value; }
        }
        public MenuSize MenuSize { get; set; } = MenuSize.Small;
        public string? MenuImagePath { get; set; }

        [NotMapped]
        public IFormFile MenuUploadPath { get; set; }

        //Navigation Property
        public ICollection<OrdersMenus>? OrdersMenus { get; set; }
    }
}
