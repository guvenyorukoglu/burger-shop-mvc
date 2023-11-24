using BurgerShop.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Models.VMs
{
    public class ExtrasVM
    {
        public List<Extra> Extras { get; set; }
        public List<Extra> AddedExtras { get; set; }
    }
}
