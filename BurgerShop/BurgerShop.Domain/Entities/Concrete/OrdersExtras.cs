namespace BurgerShop.Domain.Entities.Concrete
{
    public class OrdersExtras
    {
        private decimal _extraPrice;
        public decimal ExtraPrice
        {
            get { return _extraPrice; }
            set { _extraPrice = (decimal)((value < 0) ? 0 : value); }
        }

        private short _extraQuantity;
        public short ExtraQuantity
        {
            get { return _extraQuantity; }
            set { _extraQuantity = (short)((value < 0) ? 0 : value); }
        }

        public decimal ExtraTotalPrice
        {
            get
            {
                return ExtraPrice * ExtraQuantity;
            }
            private set { }
        }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public Guid ExtraId { get; set; }
        public Extra Extra { get; set; }
    }
}
