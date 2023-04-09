using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Softify.Tourism.Authorization;
using Softify.Tourism.Controllers;
using Softify.Tourism.Web.Models.Roles;
using Softify.Tourism.Services;
using Softify.Tourism.Web.Models.Services;
using Softify.Tourism.Rooms;
using Softify.Tourism.Web.Models.Rooms;
using Microsoft.AspNetCore.Mvc.Rendering;
using Abp.Domain.Repositories;

namespace Softify.Tourism.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Rooms)]
    public class RoomsController : TourismControllerBase
    {
        private readonly IRoomAppService _roomAppService;
        private readonly IServiceAppService _serviceAppService;

        public RoomsController(IRoomAppService  roomAppService, IServiceAppService serviceAppService)
        {
            _roomAppService = roomAppService;
            _serviceAppService= serviceAppService;
        }

        public async Task<IActionResult> Index()
        {
            //ViewBag.ServiceTypeList=new SelectList(_serviceAppService.)
            ViewBag.ServiceTypeList= (await _serviceAppService.GetSelectList());

            return View();
        }

        public async Task<ActionResult> EditModal(int roomId)
        {
            var rooms = await _roomAppService.GetAsync(new EntityDto(roomId));
            ViewBag.ServiceTypeList = (await _serviceAppService.GetSelectList());
            ViewBag.RoomTypeList = (await _roomAppService.GetSelectList());
            ViewBag.RoomNoList = (await _roomAppService.GetSelectList1());
           var model = new EditRoomModalViewModel { Rooms = rooms };
            return PartialView("_EditModal", model);
        }
    }
}
