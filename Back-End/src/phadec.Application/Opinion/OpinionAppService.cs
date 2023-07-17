using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phadec.Domain;

namespace phadec.MultiTenancy
{
    public class OpinionAppService: ApplicationService, IOpinionAppService
    {

        private readonly IRepository<Opinion, int> _OpinionRepository;

        public OpinionAppService(
            IRepository<Opinion, int> OpinionRepository
        )
        {
            _OpinionRepository = OpinionRepository;

        }

        public async Task InsertOpinion(OpinionDto input)
        {
            Opinion opinion = new Opinion();

            opinion.UserId = input.UserId;
            opinion.Description = input.Description;

            _OpinionRepository.Insert(opinion);
        }

        public async Task UpdateOpinion(OpinionDto input)
        {
            Opinion opinion = _OpinionRepository.FirstOrDefault(input.Id);

            opinion.UserId = input.UserId;
            opinion.Description = input.Description;
        }

        public async Task<OpinionDto> FindOpinion(int id)
        {
            var result = _OpinionRepository.FirstOrDefault(id);
            return ObjectMapper.Map<OpinionDto>(result);
        }

        public async Task DeleteOpinion(int id)
        {

            _OpinionRepository.Delete(id);
        }

        public async Task<List<OpinionDto>> GetListOpinion()
        {

            var result = _OpinionRepository.GetAll().ToList();
            return ObjectMapper.Map<List<OpinionDto>>(result);
        }
    }
}

