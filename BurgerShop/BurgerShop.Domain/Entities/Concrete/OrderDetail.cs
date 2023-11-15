using BurgerShop.Domain.Entities.Abstract;

namespace BurgerShop.Domain.Entities.Concrete
{
    public class OrderDetail : BaseEntity, IEntity<Guid>
    {
        public OrderDetail()
        {
            Menus = new List<Menu>();
            Extras = new List<Extra>();
        }
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public int MenuId { get; set; }
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

        public int? ExtraId { get; set; }

        private decimal _extraPrice;
        public decimal? ExtraPrice
        {
            get { return _extraPrice; }
            set { _extraPrice = (decimal)((value < 0) ? 0 : value); }
        }
        public short? ExtraQuantity { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return MenuPrice * MenuQuantity + (ExtraPrice ?? 0) * (ExtraQuantity ?? 0);
            }
        }

        //Navigation Property
        public Order Order { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<Extra>? Extras { get; set; }
    }
}
