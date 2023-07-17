using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace phadec.Domain
{
    [Table("Drug")]
    public class Drug : FullAuditedEntity<int>
    {

        public Drug()
        {
        }

        [Column("Barcode")]
        public long Barcode { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("ActiveSubstance")]
        public string ActiveSubstance { get; set; }

        [Column("AtcCode")]
        public string AtcCode { get; set; }


    }
}
