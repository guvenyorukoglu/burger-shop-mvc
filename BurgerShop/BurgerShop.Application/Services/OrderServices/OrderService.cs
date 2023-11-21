using BurgerShop.Application.Models.DTOs;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;
using BurgerShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        private readonly IBaseRepository<Order> _repository;

        public OrderService(IBaseRepository<Order> repository)
        {
            _repository = repository;
        }
        public async Task Create(OrderDTO model)
        {
            Order order = new Order()
            {
                
                OrderDate = model.OrderDate,
                Notes = model.Notes
            };

            await _repository.Insert(order);
        }

        public Task Delete(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderDTO>> GetAll()
        {
            List<Order> orders = await _repository.GetAll();
            List<OrderDTO> orderDTOs = new List<OrderDTO>();

            foreach (Order order in orders)
            {
                OrderDTO orderDTO = new OrderDTO
                {

                    Id = order.Id,
                    Quantity = order.OrderQuantity,
                    OrderDate = order.OrderDate,
                    Notes = order.Notes
                   
                };

                orderDTOs.Add(orderDTO);
            }
            return orderDTOs;
        }


        public async Task Update(OrderDTO model)
        {
            Order order = await _repository.GetDefault(x => x.Id == model.Id);
            await _repository.Update(order);
        }

    }
}
