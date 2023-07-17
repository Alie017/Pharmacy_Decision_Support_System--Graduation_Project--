using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IOpinionAppService
    {
        Task InsertOpinion(OpinionDto input);
        Task UpdateOpinion(OpinionDto input);
        Task<OpinionDto> FindOpinion(int id);
        Task DeleteOpinion(int id);
        Task<List<OpinionDto>> GetListOpinion();



    }
}

