using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
namespace phadec.Domain
{
    [Table("FoodInteraction")]
    public class FoodInteraction : FullAuditedEntity<int>
    {

        public FoodInteraction()
        {
        }

        [Column("Description")]
        public string Description { get; set; }

        [ForeignKey("DrugId")]
        public Drug Drug { get; set; }
        public int DrugId { get; set; }
    }
}
