using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Opinion))]
    public class OpinionDto : FullAuditedEntityDto
    {
        public long UserId { get; set; }

        public string Description { get; set; }        
        
    }
}
