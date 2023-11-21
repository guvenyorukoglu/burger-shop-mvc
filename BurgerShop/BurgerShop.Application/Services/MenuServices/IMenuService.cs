using BurgerShop.Application.Models.DTOs;
using BurgerShop.Application.Services.Abstract;
using BurgerShop.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Services.MenuServices
{
    public interface IMenuService
    {
        Task Create(MenuDTO model);

        Task Delete(Guid id);

        Task Update(MenuDTO model);

        Task<List<MenuDTO>> GetAll();
    }
}
