using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
namespace phadec.Domain
{
    [Table("Doctor")]
    public class Doctor : FullAuditedEntity<int>
    {

        public Doctor()
        {
        }

        [Column("Name")]
        public string Name { get; set; }

        [Column("SurName")]
        public string SurName { get; set; }

    }
}
