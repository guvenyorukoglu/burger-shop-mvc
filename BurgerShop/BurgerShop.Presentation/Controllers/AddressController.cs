using BurgerShop.Application.Models.DTOs;
using BurgerShop.Application.Services.Abstract;
using BurgerShop.Application.Services.AdressServices;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BurgerShop.Presentation.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAdressService _addressService;
        private readonly IBaseService<Address> _baseAddressService;


        public AddressController(IAdressService addresService, IBaseService<Address> baseAddressService)
        {
            _addressService = addresService;
            _baseAddressService = baseAddressService;
        }
        public async Task<IActionResult> Index()
        {
            var address = await _baseAddressService.GetFilteredList(
                select: x=>new AddressDTO()
                {
                    Id = x.Id,
                    FullAddress = x.FullAddress,
                },
                where: x=> x.AppUserId == Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value) && x.Status == Status.Active
                );
            return View(address);
        }
                             
                

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddressDTO model)
        {
            
                await _addressService.Create(model);
                return RedirectToAction("Index");
            
        }

        public async Task<IActionResult> Edit(Guid id)
        {
           await _addressService.GetById(id);
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Edit(AddressDTO model)
        {
            await _addressService.Update(model);
            return RedirectToAction("Index");
        }

        //public async Task<IActionResult> Delete(Guid id)
        //{
        //    await _addressService.GetById(id);
        //    return View();

        //}

        //[HttpPost]
        //public async Task<IActionResult> Delete(AddressDTO model)
        //{
        //    await _addressService.Delete(model);
        //    return RedirectToAction("Index");
        //}
    }
}

