using BurgerShop.Domain.Entities.Abstract;
using BurgerShop.Domain.Enums;

namespace BurgerShop.Domain.Entities.Concrete
{
    public class Menu : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string MenuName { get; set; }
        public string? MenuImageUrl { get; set; }
        private decimal _menuPrice;

        public decimal MenuPrice
        {
            get { return _menuPrice; }
            set { _menuPrice = (value < 0) ? 0 : value; }
        }
        public MenuSize MenuSize { get; set; } = MenuSize.Small;
        public Guid? OrderDetailId { get; set; }

        //Navigation Property
        public OrderDetail? OrderDetail { get; set; }
    }
}
