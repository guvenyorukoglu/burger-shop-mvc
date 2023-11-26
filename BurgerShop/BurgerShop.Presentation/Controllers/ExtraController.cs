using BurgerShop.Application.Models.VMs;
using BurgerShop.Application.Services.Abstract;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShop.Presentation.Controllers
{
    public class ExtraController : Controller
    {
        private static IBaseService<Extra> _extraService;

        public ExtraController(IBaseService<Extra> extraService)
        {
            _extraService = extraService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _extraService.GetFilteredList(
                    select: x => new ExtraVM()
                    {
                        Id = x.Id,
                        ExtraName = x.ExtraName,
                        ExtraPrice = x.ExtraPrice,
                        ExtraImageUrl = x.ExtraImageUrl
                    },
                    where: x => x.Status == Status.Active,
                    orderBy: x => x.OrderBy(x => x.ExtraName))
            );
        }
    }
}
