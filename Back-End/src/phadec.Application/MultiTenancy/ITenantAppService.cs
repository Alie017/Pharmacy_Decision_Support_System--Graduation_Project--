using Abp.Application.Services;
using phadec.MultiTenancy.Dto;

namespace phadec.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

