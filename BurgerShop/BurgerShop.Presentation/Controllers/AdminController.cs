
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
        private static IBaseService<AppUser> _appUserService;

        public AdminController(IBaseService<Menu> menuService, IBaseService<AppUser> appUserService)
        {
            _menuService = menuService;
            _appUserService = appUserService;

        }


        // Menus Actions

        public async Task<IActionResult> Menus()
        {
            return View(await _menuService.GetAll());

        }

        //TODO Create Metotları Servisten Getirilecek
        public async Task<IActionResult> AddMenu()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> AddMenu(Menu menu)
        //{
        //    await _menuService.Create(menu);
        //    return RedirectToAction("Menus");
        //}




        [HttpPost]
        public async Task<IActionResult> DeleteMenu(Menu menu)
        {
            await _menuService.Delete(menu.Id);
            return RedirectToAction("Menus");
        }


        public IActionResult DeleteMenu(Guid id)
        {
            return View(_menuService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditMenu(Menu menu)
        {
            await _menuService.Update(menu);
            return RedirectToAction("Menus");
        }



        public IActionResult EditMenu(Guid id)
        {
            return View(_menuService.GetById(id));
        }



        // Customers Actions
        public async Task<IActionResult> Customers()
        {
            return View(await _appUserService.GetAll());
        }

        //TODO Create Metotları Servisten Getirilecek
        public async Task<IActionResult> AddCustomer()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> AddCustomer(AppUser appUser)
        //{
        //    await _appUserService.Create(appUser);
        //    return RedirectToAction("Customers");
        //}

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

        [HttpPost]
        public async Task<IActionResult> EditCustomer(AppUser appUser)
        {
            await _appUserService.Update(appUser);
            return RedirectToAction("Menus");
        }


        public IActionResult EditCustomer(Guid id)
        {
            return View(_appUserService.GetById(id));
        }





        public IActionResult Orders()
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
