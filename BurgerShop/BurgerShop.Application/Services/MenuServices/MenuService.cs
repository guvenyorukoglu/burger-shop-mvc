﻿using BurgerShop.Application.Models.DTOs;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.MenuServices
{
    public class MenuService : IMenuService
    {
        private readonly IBaseRepository<Menu> _menuRepository;

        public MenuService(IBaseRepository<Menu> menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public async Task Delete(Guid id)
        {
            Menu menu = await _menuRepository.GetDefault(x => x.Id == id);

        }

        public async Task<List<MenuDTO>> GetAll()
        {
            List<Menu> menus = await _menuRepository.GetAll();
            List<MenuDTO> menuDTOs = new List<MenuDTO>();

            foreach (Menu menu in menus)
            {
                MenuDTO menuDTO = new MenuDTO
                {

                    Id = menu.Id,
                    MenuName = menu.MenuName,
                    MenuPrice = menu.MenuPrice,
                    MenuSize = menu.MenuSize,
                    MenuImagePath = menu.MenuImagePath,
                    Status = menu.Status,
                };

                menuDTOs.Add(menuDTO);
            }
            return menuDTOs;
        }

        public async Task Create(MenuDTO model)
        {
            Menu menu = new Menu()
            {
                MenuName = model.MenuName,
                MenuPrice = model.MenuPrice,
                MenuSize = model.MenuSize,
                MenuImagePath = model.MenuImagePath
            };

            await _menuRepository.Insert(menu);
        }

        public async Task Update(MenuDTO model)
        {
            Menu menu = await _menuRepository.GetDefault(x => x.Id == model.Id);
            menu.MenuPrice = model.MenuPrice;
            menu.MenuImagePath = model.MenuImagePath;
            menu.ModifiedDate = DateTime.Now;

            await _menuRepository.Update(menu);
        }
    }
}
