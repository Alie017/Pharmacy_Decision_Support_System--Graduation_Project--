using Abp.Domain.Entities.Auditing;
using phadec.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;
namespace phadec.Domain
{
    [Table("Document")]
    public class Document : FullAuditedEntity<int>
    {

        public Document()
        {
        }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Descripton")]
        public string Descripton { get; set; }

        [Column("Type")]
        public string Type { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public long UserId { get; set; }
    }
}
