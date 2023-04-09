using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using Softify.Tourism.Authorization;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Authorization.Users;
using Softify.Tourism.Roles.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Softify.Tourism.Project;
using Softify.Tourism.Services.Dto;
 using Microsoft.AspNetCore.Mvc.Rendering;
using Softify.Tourism.Attributes.Dto;
using Softify.Tourism.Rooms;
using Softify.Tourism.AttributesServices.Dto;

namespace Softify.Tourism.AttributesServices
{
   [AbpAuthorize(PermissionNames.Pages_Attributes)]
    public class AttributeServiceAppService : AsyncCrudAppService<AttributeService, AttributeServiceDto, int, PagedAttributeServiceResultRequestDto, CreateAttributeServiceDto, AttributeServiceDto>, IAttributeServiceAppService
    {
        public AttributeServiceAppService(IRepository<AttributeService> repository)
            : base(repository)
        {
            
        }

        

    }
}

