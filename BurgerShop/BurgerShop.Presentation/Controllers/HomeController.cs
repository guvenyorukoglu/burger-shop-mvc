using BurgerShop.Application.Models.DTOs;
using BurgerShop.Application.Models.VMs;
using BurgerShop.Application.Services.Abstract;
using BurgerShop.Application.Services.Concrete;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;
using BurgerShop.Infrastructure.Context;
using BurgerShop.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json;

namespace BurgerShop.Presentation.Controllers
{


    public class HomeController : Controller
    {
        private static List<Menu> menuList = new List<Menu>();
        private static List<Menu> addedMenus = new List<Menu>();
        private static List<Extra> extras = new List<Extra>();
        private static IBaseService<Menu> _menuManager;

        public HomeController(IBaseService<Menu> menuManager)
        {
            _menuManager = menuManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Menu()
        {
            //ViewBag.AddedMenus = addedMenus;

            var menuVM = new MenuVM()
            {
                MenuList = await _menuManager.GetFilteredList(
                    select: x => new Menu(){ 
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

        [HttpPost]
        public IActionResult AddToCart(Menu menu)
        {
            if (menu != null)
            {
                addedMenus.Add(menu);
               
                var menuVM = new MenuVM()
                {
                    AddedMenus = addedMenus
                };

                return View("Menu", menuVM);
            }

            return RedirectToAction("Menu");
        }


        public IActionResult GetCart()
        {

            var menuVM = new MenuVM()
            {
                AddedMenus = addedMenus
            };

            return View("Menu", menuVM);
        }

        public IActionResult RemoveFromCart(Menu menu)
        {
            if (menu != null)
            {
                addedMenus.Remove(menu);
            }

            var menuVM = new MenuVM()
            {
                AddedMenus = addedMenus,
                Extras = extras

            };

            return View("Menu", menuVM);
        }


        [HttpPost]
        public async Task<IActionResult> GetPriceBySize(string name, MenuSize menuSize)
        {
            Menu menuSelected = await _menuManager.GetDefault(x => x.MenuName == name && x.MenuSize == menuSize);

            if (menuSelected == null)
            {
                return NotFound();
            }

            decimal price = menuSelected.MenuPrice;

            if (price == null)
            {
                return NotFound();
            }

            return Ok(price);
        }


    }
}