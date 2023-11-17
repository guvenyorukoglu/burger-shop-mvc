namespace BurgerShop.Domain.Entities.Concrete
{
    public class OrdersMenus
    {
        private decimal _menuPrice;

        public decimal MenuPrice
        {
            get { return _menuPrice; }
            set { _menuPrice = (value < 0) ? 0 : value; }
        }

        private short _menuQuantity;
        public short MenuQuantity
        {
            get { return _menuQuantity; }
            set { _menuQuantity = (short)((value < 0) ? 0 : value); }
        }

        public decimal MenuTotalPrice
        {
            get
            {
                return MenuPrice * MenuQuantity;
            }
            private set { }
        }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }


    }
}
