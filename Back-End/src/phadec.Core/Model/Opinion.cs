using Abp.Domain.Entities.Auditing;
using phadec.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;
namespace phadec.Domain
{
    [Table("Opinion")]
    public class Opinion : FullAuditedEntity<int>
    {

        public Opinion()
        {
        }

        [Column("Description")]
        public string Description { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public long UserId { get; set; }
    }
}
