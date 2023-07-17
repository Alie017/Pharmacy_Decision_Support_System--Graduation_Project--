using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phadec.Domain;

namespace phadec.MultiTenancy
{
    public class FoodInteractionAppService: ApplicationService, IFoodInteractionAppService
    {

        private readonly IRepository<FoodInteraction, int> _FoodInteractionRepository;

        public FoodInteractionAppService(
            IRepository<FoodInteraction, int> FoodInteractionRepository
        )
        {
            _FoodInteractionRepository = FoodInteractionRepository;

        }

        public async Task InsertFoodInteraction(FoodInteractionDto input)
        {
            FoodInteraction foodInteraction = new FoodInteraction();

            foodInteraction.Description = input.Description;
            foodInteraction.DrugId = input.DrugId;
            _FoodInteractionRepository.Insert(foodInteraction);


        }

        public async Task UpdateFoodInteraction(FoodInteractionDto input)
        {
            FoodInteraction foodInteraction = _FoodInteractionRepository.FirstOrDefault(input.Id);

            foodInteraction.Description = input.Description;
            foodInteraction.DrugId = input.DrugId;
        }

        public async Task<FoodInteractionDto> FindFoodInteraction(int id)
        {
            var result = _FoodInteractionRepository.FirstOrDefault(id);
            return ObjectMapper.Map<FoodInteractionDto>(result);
        }

        public async Task DeleteFoodInteraction(int id)
        {

            _FoodInteractionRepository.Delete(id);
        }

        public async Task<List<FoodInteractionDto>> GetListFoodInteraction()
        {

            var result = _FoodInteractionRepository.GetAll().ToList();
            return ObjectMapper.Map<List<FoodInteractionDto>>(result);
        }
    }
}

