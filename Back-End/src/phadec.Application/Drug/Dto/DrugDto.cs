using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Drug))]
    public class DrugDto : FullAuditedEntityDto
    {
        public long Barcode { get; set; }

        public string Name { get; set; }
        
        public string ActiveSubstance { get; set; }
        
    }
}
