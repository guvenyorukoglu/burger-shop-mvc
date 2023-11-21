using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Models.VMs
{
    public class MenuVM
    {
        //public Menu Menu { get; set; }
        public List<Menu> MenuList { get; set; }

        private readonly AppDbContext _context;

    


        public MenuVM(AppDbContext context)
        {
           _context = context;
            MenuList = _context.Menus.ToList();

        }

        public List<Menu> AddedMenus { get; set; }

        public List<Extra> Extras { get; set; }
    }
}
