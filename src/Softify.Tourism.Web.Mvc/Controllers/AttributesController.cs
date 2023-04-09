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
using Softify.Tourism.Attributes;
using Softify.Tourism.Web.Models.Attributes;

namespace Softify.Tourism.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Attributes)]
    public class AttributesController : TourismControllerBase
    {
        private readonly IAttributeAppService _attributeAppService;

        public AttributesController(IAttributeAppService attributeAppService)
        {
            _attributeAppService = attributeAppService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<ActionResult> EditModal(int attributeId)
        {
            var atrributesData = await _attributeAppService.GetAsync(new EntityDto(attributeId));
            var model = new EditAttributeModalViewModel { Attributes = atrributesData };
            return PartialView("_EditModal", model);
        }

    }
}
