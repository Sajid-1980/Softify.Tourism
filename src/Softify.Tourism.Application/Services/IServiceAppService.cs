using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using Softify.Tourism.AttributesServices.Dto;
using Softify.Tourism.Project;
using Softify.Tourism.Services.Dto;

namespace Softify.Tourism.Services
{
    public interface IServiceAppService : IAsyncCrudAppService<ServiceDto, int, PagedServiceResultRequestDto, CreateServiceDto, ServiceDto>, IApplicationService, IHasSelectList
    {
        // SelectList GetSelectList(object slected);

        Task<IEnumerable<AttributeServiceDto>> GetServiceAttributes(int serviceId);
    }
}
