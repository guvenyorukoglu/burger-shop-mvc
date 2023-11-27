using BurgerShop.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Models.VMs
{
    public class OrderVM
    {
   
       
        public Menu Menu { get; set; }

        public List<Menu> Menus { get; set; }

        public OrdersMenus OrdersMenus { get; set; }

        public AppUser AppUser { get; set; }



    }
}
