using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IFoodInteractionAppService
    {
        Task InsertFoodInteraction(FoodInteractionDto input);
        Task UpdateFoodInteraction(FoodInteractionDto input);
        Task<FoodInteractionDto> FindFoodInteraction(int id);
        Task DeleteFoodInteraction(int id);
        Task<List<FoodInteractionDto>> GetListFoodInteraction();



    }
}

