using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IRegisterAppService
    {
        Task InsertRegisterAccount(RegisterDto input);
        Task<List<RegisterDto>> GetListRegisterAccount();

    }
}

