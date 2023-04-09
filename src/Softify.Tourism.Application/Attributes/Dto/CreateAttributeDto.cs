using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Project;

namespace Softify.Tourism.Attributes.Dto
{
    public class CreateAttributeDto
    {
        public string AttributeName { get; set; }
        public string AttributeDescription { get; set; }
    }
}
