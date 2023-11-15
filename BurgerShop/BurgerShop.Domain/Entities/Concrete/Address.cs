using BurgerShop.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Domain.Entities.Concrete
{
    public class Address : BaseEntity, IEntity<int>
    {
        public int Id { get; set; }
        public string FullAddress { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
