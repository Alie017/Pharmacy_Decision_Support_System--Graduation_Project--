using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phadec.Domain;

namespace phadec.MultiTenancy
{
    public class RecommendationAppService: ApplicationService, IRecommendationAppService
    {

        private readonly IRepository<Recommendation, int> _RecommendationRepository;

        public RecommendationAppService(
            IRepository<Recommendation, int> RecommendationRepository
        )
        {
            _RecommendationRepository = RecommendationRepository;

        }

        public async Task InsertRecommendation(RecommendationDto input)
        {
            Recommendation recommendation = new Recommendation();

            recommendation.Indication =input.Indication;
            recommendation.Contraindication =input.Contraindication;
            recommendation.SideEffect =input.SideEffect;
            recommendation.ProductId =input.ProductId;
            recommendation.DrugId =input.DrugId;
            _RecommendationRepository.Insert(recommendation);

        }

        public async Task UpdateRecommendation(RecommendationDto input)
        {
            Recommendation recommendation = _RecommendationRepository.FirstOrDefault(input.Id);
            recommendation.Indication = input.Indication;
            recommendation.Contraindication = input.Contraindication;
            recommendation.SideEffect = input.SideEffect;
            recommendation.ProductId = input.ProductId;
            recommendation.DrugId = input.DrugId;
        }

        public async Task<RecommendationDto> FindRecommendation(int id)
        {
            var result = _RecommendationRepository.FirstOrDefault(id);
            return ObjectMapper.Map<RecommendationDto>(result);
        }

        public async Task DeleteRecommendation(int id)
        {

            _RecommendationRepository.Delete(id);
        }

        public async Task<List<RecommendationDto>> GetListRecommendation()
        {

            var result = _RecommendationRepository.GetAll().ToList();
            return ObjectMapper.Map<List<RecommendationDto>>(result);
        }
    }
}

