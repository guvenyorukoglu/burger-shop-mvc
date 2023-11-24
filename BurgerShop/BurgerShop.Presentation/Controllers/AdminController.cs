
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
        private static IBaseService<Menu> _menuService;

        public AdminController(IBaseService<Menu> menuService)
        {
            _menuService = menuService;
        }

        public async Task<IActionResult> Menus()
        {
            return View(await _menuService.GetAll());

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
            return View();            
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
