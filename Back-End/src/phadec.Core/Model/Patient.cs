using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
namespace phadec.Domain
{
    [Table("Patient")]
    public class Patient : FullAuditedEntity<int>
    {

        public Patient()
        {
        }

        [Column("Name")]
        public string Name { get; set; }

        [Column("SurName")]
        public string SurName { get; set; }

        [Column("Info")]
        public string Info { get; set; }

    }
}
