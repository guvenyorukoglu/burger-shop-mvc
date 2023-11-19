using BurgerShop.Application.Models.DTOs;
using Microsoft.AspNetCore.Identity;

namespace BurgerShop.Application.Services.AppUserServices
{
    public interface IAppUserService
    {
        Task<IdentityResult> Register(RegisterDTO model);

        Task<SignInResult> Login(LoginDTO model);

        Task<UpdateProfileDTO> GetByUserName(string userName);

        Task UpdateUser(UpdateProfileDTO model);

        Task Logout();
    }
}
