using Abp.Application.Services.Dto;

namespace Softify.Tourism.Rooms.Dto
{
    public class PagedRoomResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

