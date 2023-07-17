using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Doctor))]
    public class DoctorDto : FullAuditedEntityDto
    {
        public string Name { get; set; }

        public string SurName { get; set; }        
        
    }
}
