using Abp.Application.Services.Dto;

namespace Softify.Tourism.AttributesServices.Dto
{
    public class PagedAttributeServiceResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

