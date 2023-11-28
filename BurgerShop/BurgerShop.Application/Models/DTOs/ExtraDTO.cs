using BurgerShop.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Models.DTOs
{
    public class ExtraDTO
    {
        public Guid Id { get; set; }
        [Required] 
        public string ExtraName { get; set; }
        public string? ExtraImageUrl { get; set; }
        public decimal ExtraPrice { get; set; }
        public Status Status { get; set; }
        
        public IFormFile? ExtraUploadPath { get; set; }
    }
}
