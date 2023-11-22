
using Bogus.DataSets;
using BurgerShop.Application.Models.VMs;
using BurgerShop.Application.Services.Abstract;
using BurgerShop.Application.Services.Concrete;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;
using BurgerShop.Infrastructure.Repositories;

using Microsoft.AspNetCore.Mvc;

namespace BurgerShop.Presentation.Controllers
{
    public class AdminController : Controller
    {
        private static List<Menu> menuList = new List<Menu>();
       
        private static List<Extra> extras = new List<Extra>();
        private static IBaseService<Menu> _menuManager;

        public AdminController(IBaseService<Menu> menuManager)
        {
            _menuManager = menuManager;
        }

        public IActionResult Menus()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }


        public async Task<IActionResult> GetMenus()
        {
            
            var menuVM = new MenuVM()
            {
                MenuList = await _menuManager.GetFilteredList(
                    select: x => new Menu()
                    {
                        Id = x.Id,
                        MenuName = x.MenuName,
                        MenuPrice = x.MenuPrice,
                        MenuSize = x.MenuSize,
                        MenuImagePath = x.MenuImagePath
                    },
                    where: x => x.Status == Status.Active)

            };

            return View(menuVM);
        }


        public IActionResult AddMenu()
        {
            return View();
        }

        public IActionResult DeleteMenu()
        {
            return View();
        }

        public IActionResult UploadPicture()
        {
            return View();
        }

        public IActionResult DeletePicture()
        {
            return View();
        }
    }
}
