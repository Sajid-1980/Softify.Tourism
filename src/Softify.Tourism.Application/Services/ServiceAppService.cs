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
using Softify.Tourism.AttributesServices.Dto;

namespace Softify.Tourism.Services
{
    [AbpAuthorize(PermissionNames.Pages_Services)]
    public class ServiceAppService : AsyncCrudAppService<Service, ServiceDto, int, PagedServiceResultRequestDto, CreateServiceDto, ServiceDto>, IServiceAppService
    {
        //    private readonly RoleManager _roleManager;
        //    private readonly UserManager _userManager;
        private readonly IRepository<AttributeService> _attributeRepo;

        public ServiceAppService(IRepository<Service> repository, IRepository<AttributeService> attributeRepo)
            : base(repository)
        {
            _attributeRepo = attributeRepo;
        }
        //public SelectList GetSelectList(object slected)
        //{

        //    var data = Repository.GetAll().Select(s => new { s.Id, s.Name }).ToList();
        //    return new SelectList(data, "Id", "Name", slected);
        //}
        public override Task<PagedResultDto<ServiceDto>> GetAllAsync(PagedServiceResultRequestDto input)
        {

            return base.GetAllAsync(input);
        }

        public async Task<SelectList> GetSelectList(object selectedValue = null)
        {
            return new SelectList(await Repository.GetAll().Select(s => new { s.Id, s.ServiceType }).ToListAsync(), "Id", "ServiceType", selectedValue);
        }
        public async Task<IEnumerable<AttributeServiceDto>> GetServiceAttributes(int serviceId)
        {
            var data = _attributeRepo.GetAllIncluding(i => i.Attribute).Where(w => w.ServiceId == serviceId);
            var d = data.Select(s => new AttributeServiceDto { ServiceId = s.ServiceId, AttributeId = s.AttributeId, AttributeName = s.Attribute.AttributeName, Value = s.Value, Id = s.Id });
            return d;
        }

        public override Task<ServiceDto> CreateAsync(CreateServiceDto input)
        {
            Service model = new Service();
            model = ObjectMapper.Map(input, model);
            foreach (var m in input.Attributes)
            {
                if (string.IsNullOrEmpty(m.Value))
                    model.AttributeServices.Add(new AttributeService { AttributeId = m.AttributeId, Value = m.Value });
            }

            var saved = Repository.Insert(model);

            return Task.FromResult(ObjectMapper.Map<ServiceDto>(saved));
        }

        public override Task<ServiceDto> UpdateAsync(ServiceDto input)
        {

            return base.UpdateAsync(input);
        }
    }
}

