using BurgerShop.Application.Models.VMs;
using BurgerShop.Application.Services.Abstract;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShop.Presentation.Controllers
{
    public class MenuController : Controller
    {
        private static IBaseService<Menu> _menuService;

        public MenuController(IBaseService<Menu> menuService)
        {
            _menuService = menuService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _menuService.GetFilteredList(
                     select: x => new MenuVM()
                     {
                         MenuId = x.Id,
                         MenuName = x.MenuName,
                         MenuPrice = x.MenuPrice,
                         MenuSize = x.MenuSize,
                         MenuImagePath = x.MenuImagePath
                     },
                     where: x => x.Status == Status.Active,
                     orderBy: x => x.OrderBy(x => x.MenuName).ThenBy(x => x.MenuSize)));
        }
    }
}
