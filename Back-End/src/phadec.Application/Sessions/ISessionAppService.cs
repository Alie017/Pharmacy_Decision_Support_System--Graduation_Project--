using System.Threading.Tasks;
using Abp.Application.Services;
using phadec.Sessions.Dto;

namespace phadec.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
