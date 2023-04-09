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

namespace Softify.Tourism.Attributes
{
   [AbpAuthorize(PermissionNames.Pages_Attributes)]
    public class AttributeAppService : AsyncCrudAppService<Attribute, AttributeDto, int, PagedAttributeResultRequestDto, CreateAttributeDto, AttributeDto>, IAttributeAppService
    {
        public AttributeAppService(IRepository<Attribute> repository)
            : base(repository)
        {
            
        }
        

    }
}

