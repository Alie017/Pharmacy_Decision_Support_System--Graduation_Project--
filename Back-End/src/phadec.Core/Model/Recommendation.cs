using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
namespace phadec.Domain
{
    [Table("Recommendation")]
    public class Recommendation : FullAuditedEntity<int>
    {

        public Recommendation()
        {
        }
        [Column("Indication")]
        public string Indication { get; set; }

        [Column("Contraindication")]
        public string Contraindication { get; set; }

        [Column("SideEffect")]
        public string SideEffect { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("DrugId")]
        public Drug Drug { get; set; }
        public int ProductId { get; set; }
        public int DrugId { get; set; }
    }
}
