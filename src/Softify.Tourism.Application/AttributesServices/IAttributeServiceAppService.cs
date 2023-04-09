using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using Softify.Tourism.Attributes.Dto;
using Softify.Tourism.AttributesServices.Dto;
using Softify.Tourism.Roles.Dto;
using Softify.Tourism.Rooms.Dto;
using Softify.Tourism.Services.Dto;

namespace Softify.Tourism.AttributesServices
{
    public interface IAttributeServiceAppService : IAsyncCrudAppService<AttributeServiceDto, int, PagedAttributeServiceResultRequestDto, CreateAttributeServiceDto, AttributeServiceDto>
    {
 
    }
}
