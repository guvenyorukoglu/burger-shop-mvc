using BurgerShop.Application.Models.VMs;
using BurgerShop.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Services.CartServices
{
    public interface ICartServices
    {
        Task AddMenuToCart(MenuVM menuVM);
        Task AddExtraToCart(ExtraVM extraVM);
        Task<CartItemVM> GetCart();
    }

}
