using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
namespace phadec.Domain
{
    [Table("DrugInteraction")]
    public class DrugInteraction : FullAuditedEntity<int>
    {

        public DrugInteraction()
        {
        }

        [Column("ActiveSubstance")]
        public string ActiveSubstance { get; set; }

        [Column("ActiveSubstanceInteract")]
        public string ActiveSubstanceInteract { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [ForeignKey("DrugId")]
        public Drug Drug { get; set; }
        public int DrugId { get; set; }
    }
}
