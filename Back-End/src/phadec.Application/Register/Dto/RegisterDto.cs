using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using phadec.Domain;

namespace phadec.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(RegisterAccount))]
    public class RegisterDto : FullAuditedEntityDto
    {

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Username { get; set; }

        public string EmailAdress { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

    }
}
