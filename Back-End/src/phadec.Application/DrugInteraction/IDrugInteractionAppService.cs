using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IDrugInteractionAppService
    {
        Task InsertDrugInteraction(DrugInteractionDto input);
        Task UpdateDrugInteraction(DrugInteractionDto input);
        Task<DrugInteractionDto> FindDrugInteraction(int id);
        Task DeleteDrugInteraction(int id);
        Task<List<DrugInteractionDto>> GetListDrugInteraction();



    }
}

