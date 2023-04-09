using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Roles;
using Abp.AutoMapper;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Project;

namespace Softify.Tourism.AttributesServices.Dto
{
    public class AttributeServiceDto : EntityDto<int>
    {
        public string AttributeName { get; set; }
        public string Value { get; set; }
        public int AttributeId { get; set; }
        public int ServiceId { get; set; }

    }
}