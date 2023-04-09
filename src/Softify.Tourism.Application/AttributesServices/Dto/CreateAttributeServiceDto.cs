using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Project;

namespace Softify.Tourism.AttributesServices.Dto
{
    public class CreateAttributeServiceDto
    {
        public string Value { get; set; }
        public int AttributeId { get; set; }
        public int ServiceId { get; set; }

        public Service Service { get; set; }
        public Attribute Attribute { get; set; }

    }
}
