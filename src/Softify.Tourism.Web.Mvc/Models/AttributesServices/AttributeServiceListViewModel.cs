using System.Collections.Generic;
using Softify.Tourism.Attributes.Dto;
using Softify.Tourism.AttributesServices.Dto;
using Softify.Tourism.Roles.Dto;
using Softify.Tourism.Services.Dto;

namespace Softify.Tourism.Web.Models.AttributesServices
{
    public class AttributeServiceListViewModel
    {

        public IReadOnlyList<AttributeServiceDto>  AttributeServices { get; set; }

    }
}
