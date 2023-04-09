using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Softify.Tourism.MultiTenancy;

namespace Softify.Tourism.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
