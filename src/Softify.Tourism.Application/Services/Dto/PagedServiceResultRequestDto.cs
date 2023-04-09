using Abp.Application.Services.Dto;

namespace Softify.Tourism.Services.Dto
{
    public class PagedServiceResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

