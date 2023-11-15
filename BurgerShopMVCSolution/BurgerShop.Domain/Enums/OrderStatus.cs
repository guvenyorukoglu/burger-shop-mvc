using System.ComponentModel.DataAnnotations;

namespace BurgerShop.Entities.Enums
{
    public enum OrderStatus
    {
        [Display(Name = "Order Placed")]
        OrderPlaced = 1,
        [Display(Name = "In The Kitchen")]
        InTheKitchen,
        [Display(Name = "On The Way")]
        OnTheWay,
        [Display(Name = "Delivered")]
        Delivered
    }
}
