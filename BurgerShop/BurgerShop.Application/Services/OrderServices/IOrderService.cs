using BurgerShop.Application.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Services.OrderServices
{
    public interface IOrderService
    {
        Task<List<OrderDTO>> GetAll();

        Task Create(OrderDTO model);

        Task Update(OrderDTO model);

        Task Delete(Guid orderId);
    }
}
