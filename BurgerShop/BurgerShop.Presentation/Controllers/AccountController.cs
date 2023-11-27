﻿using BurgerShop.Application.Models.DTOs;
using BurgerShop.Application.Services.Abstract;
using BurgerShop.Application.Services.AppUserServices;
using BurgerShop.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BurgerShop.Presentation.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IPasswordHasher<AppUser> _passwordHasher;
        private readonly IBaseService<AppUser> _appUserService;
        private readonly IAppUserService _userService;

        public AccountController(UserManager<AppUser> userManager, IPasswordHasher<AppUser> passwordHasher, IBaseService<AppUser> appUserService, IAppUserService userService)
        {
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _appUserService = appUserService;
            _userService = userService;
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO model)
        {
            if (ModelState.IsValid)
            {
                IdentityResult identityResult = await _userService.Register(model);

                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (IdentityError error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            returnUrl = returnUrl is null ? "/Home/Index" : returnUrl;
            return View(new LoginDTO() { ReturnUrl = returnUrl });
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.Login(model);
                if (result.Succeeded)
                {
                    AppUser appUser = await _appUserService.GetSingleDefault(x => x.Email == model.Email);

                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, appUser.Id.ToString()));
                    claims.Add(new Claim("UserName", appUser.UserName));

                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return Redirect(model.ReturnUrl ?? "/");
                }
                ModelState.AddModelError("", "Wrong credential information..");
            }

            return View(model);
        }


        public async Task<IActionResult> Logout()
        {
            await _userService.Logout();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Edit()
        {
            //TODO: Kontrol et çalışıp çalışmadığını. User.Identity.Name ile username kullanmak zorunda kalabiliriz.
            AppUser appUser = await _userManager.FindByNameAsync(User.FindFirstValue("UserName"));

            UpdateProfileDTO userUpdateDTO = new UpdateProfileDTO()
            {
                Id = appUser.Id,
                FirstName = appUser.FirstName,
                LastName = appUser.LastName,
                Email = appUser.Email,
                Password = "",
                ConfirmedPassword = ""
                //TODO: ImagePath
            };

            return View(userUpdateDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProfileDTO model)
        {
            if (ModelState.IsValid)
            {
                //TODO: Kontrol et çalışıp çalışmadığını. User.Identity.Name ile username kullanmak zorunda kalabiliriz.
                AppUser appUser = await _userManager.FindByNameAsync(User.FindFirstValue("UserName"));

                appUser.FirstName = model.FirstName;
                appUser.LastName = model.LastName;
                appUser.Email = model.Email;

                if (model.Password != null)
                {
                    appUser.PasswordHash = _passwordHasher.HashPassword(appUser, model.Password);
                }

                appUser.ModifiedDate = DateTime.Now;
                IdentityResult result = await _userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                {
                    TempData["Success"] = "Your profile has been edited!";
                }
                else
                {
                    TempData["Error"] = "Your profile has not been edited!";
                }
            }
            return View(model);
        }

    }
}