using BurgerShop.Application.Models.DTOs;
using BurgerShop.Application.Services.Abstract;
using BurgerShop.Application.Services.AdressServices;
using BurgerShop.Application.Services.OrderServices;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BurgerShop.Presentation.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IBaseService<Order> _baseOrderService;

        public OrderController(IOrderService orderService, IBaseService<Order> baseOrderService)
        {
            _orderService = orderService;
            _baseOrderService = baseOrderService;
        }


        public async Task<IActionResult> Index()
        {
            var orders = await _baseOrderService.GetFilteredList(
                select: x => new OrderDTO()
                {
                    Id = x.Id,
                    OrderDate = x.OrderDate,
                    Notes = x.Notes,
                    Quantity = x.OrderQuantity
                    
                    
                },
                where: x => x.AppUserId == Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value) && x.Status == Status.Active,
                orderBy: x => x.OrderBy(x => x.OrderDate)
            );

            return View(orders);
        }
    }
}
