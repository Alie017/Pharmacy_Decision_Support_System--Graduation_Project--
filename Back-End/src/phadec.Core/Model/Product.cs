using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
namespace phadec.Domain
{
    [Table("Product")]
    public class Product : FullAuditedEntity<int>
    {

        public Product()
        {
        }

        [Column("Barcode")]
        public long Barcode { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Purchase")]
        public long Purchase { get; set; }

        [Column("Sales")]
        public long Sales { get; set; }

    }
}
