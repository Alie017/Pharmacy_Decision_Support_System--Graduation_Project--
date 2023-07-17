using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(FoodInteraction))]
    public class FoodInteractionDto : FullAuditedEntityDto
    {
        public int DrugId { get; set; }

        public string Description { get; set; }        
        
    }
}
