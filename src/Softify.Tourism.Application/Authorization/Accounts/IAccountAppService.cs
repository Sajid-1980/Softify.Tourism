using System.Threading.Tasks;
using Abp.Application.Services;
using Softify.Tourism.Authorization.Accounts.Dto;

namespace Softify.Tourism.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
