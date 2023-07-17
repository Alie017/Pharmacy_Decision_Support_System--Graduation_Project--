using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Prescription))]
    public class PrescriptionDto : FullAuditedEntityDto
    {
        public int DrugId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string ElecNo { get; set; }        
        
    }
}
