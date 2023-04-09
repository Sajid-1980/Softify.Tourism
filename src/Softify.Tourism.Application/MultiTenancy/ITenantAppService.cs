using Abp.Application.Services;
using Softify.Tourism.MultiTenancy.Dto;

namespace Softify.Tourism.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

