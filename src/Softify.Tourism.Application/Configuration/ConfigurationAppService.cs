using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Softify.Tourism.Configuration.Dto;

namespace Softify.Tourism.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TourismAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
