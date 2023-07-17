using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
namespace phadec.Domain
{
    [Table("Prescription")]
    public class Prescription : FullAuditedEntity<int>
    {

        public Prescription()
        {
        }

        [Column("ElecNo")]
        public string ElecNo { get; set; }

        [ForeignKey("DrugId")]
        public Drug Drug { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
    }
}
