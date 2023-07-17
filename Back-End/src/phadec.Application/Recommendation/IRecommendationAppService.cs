using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IRecommendationAppService
    {
        Task InsertRecommendation(RecommendationDto input);
        Task UpdateRecommendation(RecommendationDto input);
        Task<RecommendationDto> FindRecommendation(int id);
        Task DeleteRecommendation(int id);
        Task<List<RecommendationDto>> GetListRecommendation();



    }
}

