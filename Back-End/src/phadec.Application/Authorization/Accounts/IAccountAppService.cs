using System.Threading.Tasks;
using Abp.Application.Services;
using phadec.Authorization.Accounts.Dto;

namespace phadec.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
