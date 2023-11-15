using BurgerShop.Entities.Abstract;
using BurgerShop.Entities.Enums;

namespace BurgerShop.Entities.Concrete
{
    public class Order : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid AppUserId { get; set; }
        public short OrderQuantity { get; set; } = 1;
        public OrderStatus OrderStatus { get; set; } = OrderStatus.OrderPlaced;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime? ShippedDate { get; set; }
        public string? Notes { get; set; }
        public string ShippedAddress { get; set; }

        //Navigation Property
        public AppUser AppUser { get; set; }
        public OrderDetail OrderDetail { get; set; }

    }
}
