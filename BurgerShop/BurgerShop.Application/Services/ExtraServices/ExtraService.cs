using Bogus.DataSets;
using BurgerShop.Application.Models.DTOs;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;
using BurgerShop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop.Application.Services.ExtraDervices
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
                ExtraName = model.ExtraName
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
                ExtraName = extra.ExtraName,
                ExtraPrice = extra.ExtraPrice,
                ExtraImageUrl = extra.ExtraImageUrl
            }).ToList();

            return extraDTOs;
        }

        public async Task Update(ExtraDTO model)
        {
            Extra extra = await _repository.GetDefault(x => x.Id == model.Id);
            await _repository.Update(extra);
        }
    }
}
