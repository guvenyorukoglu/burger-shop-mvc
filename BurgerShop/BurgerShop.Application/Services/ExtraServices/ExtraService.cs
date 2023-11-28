using BurgerShop.Application.Models.DTOs;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;
using BurgerShop.Domain.Repositories;

namespace BurgerShop.Application.Services.ExtraServices
{
    public class ExtraService : IExtraService
    {
        private readonly IBaseRepository<Extra> _repository;

        public ExtraService(IBaseRepository<Extra> repository)
        {
            _repository = repository;
        }

        public Task Create(ExtraDTO model)
        {
            Extra extra = new Extra()
            {
                ExtraName = model.ExtraName,
                ExtraPrice = model.ExtraPrice,
                ExtraImageUrl = model.ExtraImageUrl,
                Status = Status.Active,
                CreatedDate = DateTime.Now
            };
            return _repository.Insert(extra);
        }

        public async Task Delete(Guid id)
        {
            Extra extra = await _repository.GetDefault(x => x.Id == id);
            extra.Status = Domain.Enums.Status.Deleted;
            await _repository.Delete(extra.Id);
        }

        public async Task<List<ExtraDTO>> GetAll()
        {
            List<Extra> extras = await _repository.GetAll();
            List<ExtraDTO> extraDTOs = extras.Select(extra => new ExtraDTO
            {
                Id = extra.Id,
                ExtraName = extra.ExtraName,
                ExtraPrice = extra.ExtraPrice,
                ExtraImageUrl = extra.ExtraImageUrl,
                Status = extra.Status,
            }).ToList();

            return extraDTOs;
        }

        public async Task Update(ExtraDTO model)
        {
            Extra extra = await _repository.GetDefault(x => x.Id == model.Id);
            extra.ExtraName = model.ExtraName;
            extra.ExtraPrice = model.ExtraPrice;
            extra.ExtraImageUrl = model.ExtraImageUrl;
            extra.Status = model.Status;
            extra.ModifiedDate = DateTime.Now;

            await _repository.Update(extra);
        }
    }
}
