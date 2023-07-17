using System.Threading.Tasks;
using phadec.Configuration.Dto;

namespace phadec.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
