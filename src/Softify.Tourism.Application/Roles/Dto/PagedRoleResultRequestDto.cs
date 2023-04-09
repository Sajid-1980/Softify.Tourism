using Abp.Application.Services.Dto;

namespace Softify.Tourism.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

