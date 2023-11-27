using BurgerShop.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurgerShop.Application.Models.VMs
{
    public class MenuVM
    {

        public Guid MenuId { get; set; }
        public string MenuName { get; set; }
        public decimal MenuPrice { get; set; }
        public MenuSize MenuSize { get; set; }
        public string MenuImagePath { get; set; }
       

    }
}