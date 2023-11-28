using BurgerShop.Application.Models.DTOs;
using BurgerShop.Application.Models.VMs;

namespace BurgerShop.Application.Services.OrderServices
{
    public interface IOrderService
    {
        Task<List<OrderVM>> GetAll();

        Task Create(OrderDTO model);

        Task Update(OrderDTO model);

        Task Delete(Guid orderId);

        Task<List<CustomerOrdersVM>> GetCustomerOrders(Guid customerId);


    }
}
