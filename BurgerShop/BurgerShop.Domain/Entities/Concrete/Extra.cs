using BurgerShop.Domain.Entities.Abstract;

namespace BurgerShop.Domain.Entities.Concrete
{
    public class Extra : BaseEntity, IEntity<Guid>, IProduct
    {
        public Extra()
        {
            OrdersExtras = new List<OrdersExtras>();
        }
        public Guid Id { get; set; }
        public string ExtraName { get; set; }
        public string? ExtraImageUrl { get; set; }
        private decimal _extraPrice;

        public decimal ExtraPrice
        {
            get { return _extraPrice; }
            set { _extraPrice = (value < 0) ? 0 : value; }
        }

        //Navigation Property
        public ICollection<OrdersExtras>? OrdersExtras { get; set; }
    }
}
