using System.Collections.Generic;
using Softify.Tourism.Attributes.Dto;
using Softify.Tourism.Roles.Dto;
using Softify.Tourism.Services.Dto;

namespace Softify.Tourism.Web.Models.Attributes
{
    public class AttributeListViewModel
    {

        public IReadOnlyList<AttributeDto>  Attributes { get; set; }

    }
}
