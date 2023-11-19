using BurgerShop.Application.Models.DTOs;
using Microsoft.AspNetCore.Identity;

namespace BurgerShop.Application.Services.AppUserServices
{
    public class AppUserService : IAppUserService
    {
        public Task<UpdateProfileDTO> GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<SignInResult> Login(LoginDTO model)
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> Register(RegisterDTO model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(UpdateProfileDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
