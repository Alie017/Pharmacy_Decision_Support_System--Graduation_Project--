using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phadec.Domain;

namespace phadec.MultiTenancy
{
    public class DrugInteractionAppService: ApplicationService, IDrugInteractionAppService
    {

        private readonly IRepository<DrugInteraction, int> _DrugInteractionRepository;

        public DrugInteractionAppService(
            IRepository<DrugInteraction, int> DrugInteractionRepository
        )
        {
            _DrugInteractionRepository = DrugInteractionRepository;

        }

        public async Task InsertDrugInteraction(DrugInteractionDto input)
        {
            DrugInteraction drugInteraction = new DrugInteraction();

            drugInteraction.DrugId = input.DrugId;
            drugInteraction.ActiveSubstance = input.ActiveSubstance;
            drugInteraction.ActiveSubstanceInteract = input.ActiveSubstanceInteract;
            drugInteraction.Description = input.Description;
            _DrugInteractionRepository.Insert(drugInteraction);

        }

        public async Task UpdateDrugInteraction(DrugInteractionDto input)
        {
            DrugInteraction drugInteraction = _DrugInteractionRepository.FirstOrDefault(input.Id);

            drugInteraction.DrugId = input.DrugId;
            drugInteraction.ActiveSubstance = input.ActiveSubstance;
            drugInteraction.ActiveSubstanceInteract = input.ActiveSubstanceInteract;
            drugInteraction.Description = input.Description;
        }

        public async Task<DrugInteractionDto> FindDrugInteraction(int id)
        {
            var result = _DrugInteractionRepository.FirstOrDefault(id);
            return ObjectMapper.Map<DrugInteractionDto>(result);
        }

        public async Task DeleteDrugInteraction(int id)
        {

            _DrugInteractionRepository.Delete(id);
        }

        public async Task<List<DrugInteractionDto>> GetListDrugInteraction()
        {

            var result = _DrugInteractionRepository.GetAll().ToList();
            return ObjectMapper.Map<List<DrugInteractionDto>>(result);
        }
    }
}

