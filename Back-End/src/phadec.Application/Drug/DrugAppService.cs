using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.CustomDto;
using phadec.Domain;
using phadec.MultiTenancy.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phadec.MultiTenancy;
public class DrugAppService : ApplicationService, IDrugAppService
{

    private readonly IRepository<Drug, int> _DrugRepository;
    private readonly IRepository<DrugInteraction, int> _DrugInteractionRepository;
    private readonly IRepository<FoodInteraction, int> _FoodInteractionRepository;
    private readonly IRepository<Recommendation, int> _RecommendatitonRepository;

    public DrugAppService(
        IRepository<Drug, int> DrugRepository,
        IRepository<DrugInteraction, int> DrugInteractionRepository,
        IRepository<FoodInteraction, int> FoodInteractionRepository,
        IRepository<Recommendation, int> RecommendatitonRepository
    )
    {
        _DrugRepository = DrugRepository;
        _DrugInteractionRepository = DrugInteractionRepository;
        _FoodInteractionRepository = FoodInteractionRepository;
        _RecommendatitonRepository = RecommendatitonRepository;

    }

    public async Task InsertDrug(DrugDto input)
    {
        Drug drug = new Drug();

        drug.Barcode = input.Barcode;
        drug.Name = input.Name;
        _DrugRepository.Insert(drug);
    }

    public async Task UpdateDrug(DrugDto input)
    {
        Drug drug = _DrugRepository.FirstOrDefault(input.Id);

        drug.Barcode = input.Barcode;
        drug.Name = input.Name;
    }

    public async Task<DrugDto> FindDrug(int id)
    {
        var result = _DrugRepository.FirstOrDefault(id);
        return ObjectMapper.Map<DrugDto>(result);
    }

    public async Task DeleteDrug(int id)
    {

        _DrugRepository.Delete(id);
    }

    public async Task<List<DrugDto>> GetListDrug()
    {

        var result = _DrugRepository.GetAll().ToList();
        return ObjectMapper.Map<List<DrugDto>>(result);
    }

    public async Task<DrugInformationDto> GetDrugInformation(long drugId)
    {
        var drugResult = _DrugRepository.GetAsync((int)drugId).Result;
        var drugInteractionResult = _DrugInteractionRepository.FirstOrDefaultAsync(x => x.DrugId == drugId).Result;
        var foodInteraction = _FoodInteractionRepository.FirstOrDefaultAsync(x => x.DrugId == drugId).Result;
        var recResult = _RecommendatitonRepository.FirstOrDefaultAsync(x => x.DrugId == drugId).Result;

        DrugInformationDto drugInformationDto = new DrugInformationDto();
        drugInformationDto.Drug = ObjectMapper.Map<DrugDto>(drugResult);
        drugInformationDto.DrugInteraction = ObjectMapper.Map<DrugInteractionDto>(drugInteractionResult);
        drugInformationDto.FoodInteraction = ObjectMapper.Map<FoodInteractionDto>(foodInteraction);
        drugInformationDto.Recommendation = ObjectMapper.Map<RecommendationDto>(recResult);

        return drugInformationDto;
    }

    public async Task<List<DrugInformationDto>> CheckInteraction(List<long> barcodes)


    {
        var drugResult = _DrugRepository.GetAll().Where(x => barcodes.Contains(x.Barcode)).ToList();
        var drugIds = drugResult.Select(x => x.Id).ToList(); // Extract drug IDs from the drugResult

        
        var drugInteractionResult = _DrugInteractionRepository.GetAll().Where(x => drugIds.Contains(x.DrugId)).ToList();
        var foodInteraction = _FoodInteractionRepository.GetAll().Where(x => drugIds.Contains(x.DrugId)).ToList();
        var recResult = _RecommendatitonRepository.GetAll().Where(x => drugIds.Contains(x.DrugId)).ToList();

        List<DrugInformationDto> drugInformationList = new List<DrugInformationDto>();
        for (int i = 0; i < drugResult.Count; i++)
        {
            DrugInformationDto drugInformation = new DrugInformationDto();
            drugInformation.Drug = ObjectMapper.Map<DrugDto>(drugResult[i]);
            drugInformation.FoodInteraction = ObjectMapper.Map<FoodInteractionDto>(foodInteraction[i]);
            drugInformation.Recommendation = ObjectMapper.Map<RecommendationDto>(recResult[i]);
            drugInformationList.Add(drugInformation);
        }

        return drugInformationList;
    }

    public async Task<List<string>> CheckDrugInteraction(List<long> barcodes)
    {
        var drugResult = _DrugRepository.GetAll().Where(x => barcodes.Contains(x.Barcode)).ToList();
        var drugIds = drugResult.Select(x => x.Id).ToList(); // Extract drug IDs from the drugResult

        var drugInteractionResult = _DrugInteractionRepository.GetAll().Where(x => drugIds.Contains(x.DrugId)).ToList();

        List<string> ActiveSubstanceInteract = new List<string>();
        for (int i = 0; i < drugResult.Count; i++)
        {
                if (drugResult.ToList().Select(x => x.ActiveSubstance).Contains(drugInteractionResult[i].ActiveSubstanceInteract))
                {
                    DrugInformationDto drugInformation = new DrugInformationDto();
                    drugInformation.Drug = ObjectMapper.Map<DrugDto>(drugResult[i]);
                    drugInformation.DrugInteraction = ObjectMapper.Map<DrugInteractionDto>(drugInteractionResult[i]);

                    ActiveSubstanceInteract.Add(drugInformation.DrugInteraction.Description);
                }
        }

        return ActiveSubstanceInteract;
    }
}
