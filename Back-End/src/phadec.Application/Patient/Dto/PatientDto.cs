using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Patient))]
    public class PatientDto : FullAuditedEntityDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Info { get; set; }
        
    }
}
