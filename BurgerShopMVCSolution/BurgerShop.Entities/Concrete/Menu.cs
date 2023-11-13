using BurgerShop.Entities.Abstract;
using BurgerShop.Entities.Enums;

namespace BurgerShop.Entities.Concrete
{
    public class Menu : BaseEntity, IEntity<int>
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public string? MenuPhotoUrl { get; set; }
        private decimal _menuPrice;

        public decimal MenuPrice
        {
            get { return _menuPrice; }
            set { _menuPrice = (value < 0) ? 0: value; }
        }
        public MenuSize MenuSize { get; set; } = MenuSize.Small;
        public Guid? OrderDetailId { get; set; }

        //Navigation Property
        public OrderDetail? OrderDetail { get; set; }
    }
}
