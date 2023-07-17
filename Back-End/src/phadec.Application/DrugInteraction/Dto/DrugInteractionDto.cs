using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(DrugInteraction))]
    public class DrugInteractionDto : FullAuditedEntityDto
    {
        public int DrugId { get; set; }
        public string ActiveSubstance {get; set;}
        public string ActiveSubstanceInteract { get; set;}
        public string Description { get; set;}
        public string InteractionDescription { get; internal set; }
    }
}
