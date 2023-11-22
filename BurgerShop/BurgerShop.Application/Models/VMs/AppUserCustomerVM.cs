using BurgerShop.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Models.VMs
{
    public class AppUserCustomerVM
    {
        public AppUser AppUserCustomer { get; set; }
        public List<AppUser> AppUserCustomers { get; set; }
    }
}
