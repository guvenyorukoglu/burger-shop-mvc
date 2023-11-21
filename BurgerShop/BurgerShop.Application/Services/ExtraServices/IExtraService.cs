using BurgerShop.Application.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Services.ExtraDervices
{
    public interface IExtraService
    {
        Task<List<ExtraDTO>> GetAll();

        Task Create(ExtraDTO model);

        Task Update(ExtraDTO model);

        Task Delete(Guid id);
    }
}
