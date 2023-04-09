using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using Softify.Tourism.Rooms.Dto;
using Softify.Tourism.Services.Dto;

namespace Softify.Tourism.Rooms
{
    public interface IRoomAppService : IAsyncCrudAppService<RoomDto, int, PagedRoomResultRequestDto, CreateRoomDto, RoomDto>
    {
        Task<SelectList> GetSelectList(object selectedValue = null);
        Task<SelectList> GetSelectList1(object selectedValue = null);
    }
}
