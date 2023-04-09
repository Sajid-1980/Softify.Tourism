using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Softify.Tourism.Authorization;
using Softify.Tourism.Controllers;
using Softify.Tourism.Web.Models.Roles;
using Softify.Tourism.Services;
using Softify.Tourism.Web.Models.Services;
using System.Security.AccessControl;
using Softify.Tourism.AttributesServices;
using Softify.Tourism.Project;
using Abp.Extensions;

namespace Softify.Tourism.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Services)]
    public class ServicesController : TourismControllerBase
    {
        private readonly IServiceAppService _serviceAppService;

        public ServicesController(IServiceAppService serviceAppService)
        {
            _serviceAppService = serviceAppService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.ServiceType = await _serviceAppService.GetSelectList();

            return View();
        }

        public async Task<ActionResult> EditModal(int serviceId)
        {
            var service = await _serviceAppService.GetAsync(new EntityDto(serviceId));
            ViewBag.ServiceType = await _serviceAppService.GetSelectList(service.Id);
            var serAttr = await _serviceAppService.GetServiceAttributes(serviceId);
            var model = new EditServiceModalViewModel
            {
                Service = service

            };
            return PartialView("_EditModal", model);
        }

    }
}
