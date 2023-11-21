using BurgerShop.Application.Services.Abstract;
using BurgerShop.Application.Services.AppUserServices;
using BurgerShop.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShop.Presentation.Controllers
{
    public class AppUserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IBaseService<AppUser> _appUserManager;

        public AppUserController(IAppUserService appUserService, IBaseService<AppUser> appUserManager)
        {
            _appUserService = appUserService;
            _appUserManager = appUserManager;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _appUserManager.GetAll());
        }
    }
}
