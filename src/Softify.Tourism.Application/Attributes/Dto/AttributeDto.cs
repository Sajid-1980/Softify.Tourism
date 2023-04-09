using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Roles;
using Abp.AutoMapper;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Project;

namespace Softify.Tourism.Attributes.Dto
{
    public class AttributeDto : EntityDto<int>
    {

        public string AttributeName { get; set; }
        public string AttributeDescription { get; set; }
    }
}