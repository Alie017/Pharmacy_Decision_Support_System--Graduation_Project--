using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
namespace phadec.Domain
{
    [Table("RegisterAccount")]
    public class RegisterAccount : FullAuditedEntity<int>
    {

        public RegisterAccount()
        {
        }

        [Column("Name")]
        public string Name { get; set; }

        [Column("SurName")]
        public string SurName { get; set; }

        [Column("Username")]
        public string Username { get; set; }

        [Column("EmailAdress")]
        public string EmailAdress { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("Role")]
        public string Role { get; set; }



    }
}
