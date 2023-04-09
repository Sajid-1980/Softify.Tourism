using Abp.Application.Services.Dto;

namespace Softify.Tourism.Attributes.Dto
{
    public class PagedAttributeResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

