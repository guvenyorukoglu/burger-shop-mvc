using AutoMapper;
using BurgerShop.Application.Models.DTOs;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;
using BurgerShop.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using static System.Net.WebRequestMethods;

namespace BurgerShop.Application.Services.AppUserServices
{
    public class AppUserService : IAppUserService
    {
        private readonly IBaseRepository<AppUser> _repository;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AppUserService(IBaseRepository<AppUser> repository, IMapper mapper, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _repository = repository;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task<UpdateProfileDTO> GetByUserName(string userName)
        {
            UpdateProfileDTO result = await _repository.GetFilteredFirstOrDefault(
                select: x => new UpdateProfileDTO
                {
                   FirstName = x.FirstName,
                   LastName = x.LastName,
                    Id = x.Id,
                    Password = x.PasswordHash,
                    Email = x.Email

                },
                where: x => x.UserName == userName
                );
            return result;
        }

        public async Task<SignInResult> Login(LoginDTO model)
        {
           return await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
        }

        public Task Logout()
        {
            return _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> Register(RegisterDTO model)
        {
            AppUser newUser = new AppUser()
            {
                Email = model.Email,
                CreatedDate = model.CreatedDate

            };

            IdentityResult result = await _userManager.CreateAsync(newUser, model.Password);
            if(result.Succeeded)
            {
               await _signInManager.SignInAsync(newUser, isPersistent: false);
            }
            await _repository.Insert(newUser);
            return result;
        }

        public async Task UpdateUser(UpdateProfileDTO model)
        {
            AppUser user = await _repository.GetDefault(x => x.Id == model.Id);
            if(model.Password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);

                await _userManager.UpdateAsync(user);
            }

            if(model.Email != null)
            {
               AppUser isUserEmailExists = await _userManager.FindByEmailAsync(model.Email);
                if(isUserEmailExists != null)
                {
                    await _userManager.SetEmailAsync(user, model.Email);
                }
            }
        }
    }
}
