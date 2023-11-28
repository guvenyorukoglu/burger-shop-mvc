using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;

namespace BurgerShop.Application.Models.VMs
{
    public class CustomerOrdersVM
    {
        public Guid OrderId { get; set; }
        public string CustomerFullName { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string? Notes { get; set; }
        public string ShippedAddress { get; set; }
        public int Quantity { get; set; }

    }
}
