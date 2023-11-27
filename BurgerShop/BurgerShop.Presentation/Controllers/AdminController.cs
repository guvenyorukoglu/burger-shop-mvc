
using Bogus.DataSets;
using BurgerShop.Application.Models.DTOs;
using BurgerShop.Application.Models.VMs;
using BurgerShop.Application.Services.Abstract;
using BurgerShop.Application.Services.AppUserServices;
using BurgerShop.Application.Services.Concrete;
using BurgerShop.Application.Services.MenuServices;
using BurgerShop.Application.Services.OrderServices;
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
        private static IMenuService _menuService;
        private static IOrderService _orderService;
     
       
    
        private static IBaseService<Menu> _baseService;
        private static IBaseService<AppUser> _appUserService;
    

        public AdminController(IMenuService menuService, IBaseService<AppUser> appUserService, IBaseService<Menu> baseService, IOrderService orderService )
        {
            _baseService = baseService;
            _menuService = menuService;
            _appUserService = appUserService;
            _orderService = orderService;
         

        }


        // MENU ACTIONS

        public IActionResult Index()
        {
            return RedirectToAction("Login","Account");
        }

        public async Task<IActionResult> Menus()
        {
            return View(await _menuService.GetAll());

        }

        //TODO Create Metotları Servisten Getirilecek
        public async Task<IActionResult> AddMenu()
        {
            return View(new MenuDTO());
        }


        [HttpPost]
        public async Task<IActionResult> AddMenu(MenuDTO menu)
        {
            await _menuService.Create(menu);
            return RedirectToAction("Menus");
        }


        public IActionResult DeleteMenu(Guid id)
        { 
            return View(_baseService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMenu(MenuDTO menu)
        {
            await _baseService.Delete(menu.Id);
            return RedirectToAction("Menus");
        }



        [HttpPost]
        public async Task<IActionResult> EditMenu(MenuDTO menu)
        {
            await _menuService.Update(menu);
            return RedirectToAction("Menus");
        }



        public IActionResult EditMenu(Guid id)
        {
            return View(_baseService.GetById(id));
        }



        // CUSTOMER ACTIONS
        public async Task<IActionResult> Customers()
        {
            return View(await _appUserService.GetAll());
        }

        //TODO Create Metotları Servisten Getirilecek
        public async Task<IActionResult> AddCustomer()
        {
            return View(new AppUser());
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(AppUser appUser)
        {
            await _appUserService.Insert(appUser);
            return RedirectToAction("Customers");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCustomer(AppUser appUser)
        {
            await _appUserService.Delete(appUser.Id);
            return RedirectToAction("Customers");
        }


        public IActionResult DeleteCustomer(Guid id)
        {
            return View(_appUserService.GetById(id));
        }


        public IActionResult EditCustomer(Guid id)
        {
            return View(_appUserService.GetById(id));
        }


        [HttpPost]
        public async Task<IActionResult> EditCustomer(AppUser appUser)
        {
            await _appUserService.Update(appUser);
            return RedirectToAction("Customers");
        }



        public async Task<IActionResult> Orders()
        {
            return View(await _orderService.GetAll());
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
