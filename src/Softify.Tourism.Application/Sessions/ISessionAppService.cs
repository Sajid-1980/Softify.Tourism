using System.Threading.Tasks;
using Abp.Application.Services;
using Softify.Tourism.Sessions.Dto;

namespace Softify.Tourism.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
