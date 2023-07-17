using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto : FullAuditedEntityDto
    {
        public string Name { get; set; }
        public long Barcode { get; set; }
        public long Purchase { get; set; }
        public long Sales { get; set; }

    }
}
