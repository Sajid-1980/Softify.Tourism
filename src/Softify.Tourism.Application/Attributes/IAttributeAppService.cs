using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using Softify.Tourism.Attributes.Dto;
using Softify.Tourism.Rooms.Dto;
using Softify.Tourism.Services.Dto;

namespace Softify.Tourism.Attributes
{
    public interface IAttributeAppService : IAsyncCrudAppService<AttributeDto, int, PagedAttributeResultRequestDto, CreateAttributeDto, AttributeDto>
    {
         
    }
}
