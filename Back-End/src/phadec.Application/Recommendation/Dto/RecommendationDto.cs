using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Recommendation))]
    public class RecommendationDto : FullAuditedEntityDto
    {
        public string Indication { get; set; }
        public string Contraindication { get; set; }
        public string SideEffect { get; set; }
        public int ProductId { get; set; }
        public int DrugId { get; set; }


    }
}
