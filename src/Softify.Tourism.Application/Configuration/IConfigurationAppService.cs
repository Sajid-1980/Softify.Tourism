using System.Threading.Tasks;
using Softify.Tourism.Configuration.Dto;

namespace Softify.Tourism.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
