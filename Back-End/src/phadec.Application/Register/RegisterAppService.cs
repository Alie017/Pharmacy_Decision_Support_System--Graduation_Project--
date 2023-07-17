using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.Domain;
using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phadec.MultiTenancy;
public class RegisterAppService : ApplicationService,   IRegisterAppService

{

    private readonly IRepository<RegisterAccount, int> _RegisterAccountRepository;

    public RegisterAppService(
        IRepository<RegisterAccount, int> RegisterAccountRepository

    )
    {
        _RegisterAccountRepository = RegisterAccountRepository;
    }

    public async Task InsertRegisterAccount(RegisterDto input)
    {
        RegisterAccount register = new RegisterAccount();

        register.Name = input.Name;
        register.SurName = input.SurName;
        register.Username = input.Username;
        register.EmailAdress = input.EmailAdress;
        register.Password = input.Password;
        register.Role = input.Role;

    _RegisterAccountRepository.Insert(register);
    }

    public async Task<List<RegisterDto>> GetListRegisterAccount()
    {
        var result = _RegisterAccountRepository.GetAll().ToList();
        return ObjectMapper.Map<List<RegisterDto>>(result);
    }
}
