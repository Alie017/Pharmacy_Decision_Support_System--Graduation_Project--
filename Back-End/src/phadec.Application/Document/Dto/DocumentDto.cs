using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Document))]
    public class DocumentDto : FullAuditedEntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public long UserId { get; set; }

        
    }
}
