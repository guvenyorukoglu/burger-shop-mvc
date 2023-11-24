using BurgerShop.Domain.Entities.Abstract;

namespace BurgerShop.Application.Models.VMs
{
    public class CartItemVM
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        private decimal _SubTotal;
        public decimal SubTotal
        {
            get { return _SubTotal; }
            set { _SubTotal = Price * Quantity; }
        }

    }
}
