using System.Collections.Generic;
using Softify.Tourism.Roles.Dto;
using Softify.Tourism.Services.Dto;

namespace Softify.Tourism.Web.Models.Services
{
    public class ServiceListViewModel
    {
       public IReadOnlyList<ServiceDto> Services { get; set; }

    }
}
