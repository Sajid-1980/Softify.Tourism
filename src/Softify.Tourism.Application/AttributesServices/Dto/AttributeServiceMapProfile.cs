using System.Linq;
using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Project;

namespace Softify.Tourism.AttributesServices.Dto
{
    public class AttributeServiceMapProfile : Profile
    {
        public AttributeServiceMapProfile()
        {
            CreateMap<CreateAttributeServiceDto, AttributeService>();

            CreateMap<AttributeServiceDto, Attribute>();

            CreateMap<AttributeService, CreateAttributeServiceDto>();

            CreateMap<AttributeService, AttributeServiceDto>();
        }
    }
}
