using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using phadec.Configuration.Dto;

namespace phadec.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : phadecAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
