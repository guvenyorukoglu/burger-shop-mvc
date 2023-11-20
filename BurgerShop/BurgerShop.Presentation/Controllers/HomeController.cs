using BurgerShop.Application.Models.DTOs;
using BurgerShop.Application.Models.VMs;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;
using BurgerShop.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BurgerShop.Presentation.Controllers
{


    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        private List<Menu> menuList = new List<Menu>();

        public HomeController(AppDbContext context)
        {
            _context = context;
            menuList = _context.Menus.ToList();
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Menu()
        {
            MenuVM menuVM = new MenuVM(_context);
           
            return View(menuVM);
        }


        [HttpPost]
        public IActionResult AddToCart(Menu menu)
        {


            ViewBag.SelectedMenu = menu;
            menuList.Add(menu);

            return View("Menu");
        }


        public IActionResult GetCart(List<Menu> menuList)
        {
            ViewBag.MenuList = menuList;

            return View("Menu");
        }


    }
}
