using BurgerShop.Application.Models.DTOs;
using BurgerShop.Application.Models.VMs;
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

        private readonly AppDbContext _context;
        private static List<Menu> menuList = new List<Menu>();
        private static List<Menu> addedMenus = new List<Menu>();
        private static List<Extra> extras = new List<Extra>();


        public HomeController(AppDbContext context)
        {
            _context = context;



        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Menu()
        {
            //ViewBag.AddedMenus = addedMenus;

            var menuVM = new MenuVM(_context);
            return View(menuVM);
        }




        [HttpPost]
        public IActionResult AddToCart(Menu menu)
        {


            if (menu != null)
            {
                addedMenus.Add(menu);

               
                var menuVM = new MenuVM(_context)
                {
                    AddedMenus = addedMenus

                };

               
                return View("Menu", menuVM);
            }

            return RedirectToAction("Menu");
        }


        public IActionResult GetCart()
        {

            var menuVM = new MenuVM(_context)
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

            var menuVM = new MenuVM(_context)
            {
                AddedMenus = addedMenus,
                Extras = extras

            };

            return View("Menu", menuVM);
        }


        [HttpPost]
        public IActionResult GetPriceBySize(Guid id, MenuSize menuSize)
        {
            var menu = _context.Menus.FirstOrDefault(m => m.Id == id);

            if (menu == null)
            {
                return NotFound();
            }

            var price = _context.Menus
                .FirstOrDefault(p => p.Id == id && p.MenuSize == menuSize);

            if (price == null)
            {
                return NotFound();
            }

            return Ok(price);
        }

    }
}