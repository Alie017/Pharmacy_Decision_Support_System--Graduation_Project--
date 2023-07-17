using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IDrugAppService
    {
        Task InsertDrug(DrugDto input);
        Task UpdateDrug(DrugDto input);
        Task<DrugDto> FindDrug(int id);
        Task DeleteDrug(int id);
        Task<List<DrugDto>> GetListDrug();



    }
}

