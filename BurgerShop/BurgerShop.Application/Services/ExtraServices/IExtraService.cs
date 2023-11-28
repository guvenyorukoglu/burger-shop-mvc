using BurgerShop.Application.Models.DTOs;

namespace BurgerShop.Application.Services.ExtraServices
{
    public interface IExtraService
    {
        Task<List<ExtraDTO>> GetAll();

        Task Create(ExtraDTO model);

        Task Update(ExtraDTO model);

        Task Delete(Guid id);
    }
}
