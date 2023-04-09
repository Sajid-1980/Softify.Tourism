using System.Linq;
using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Project;

namespace Softify.Tourism.Attributes.Dto
{
    public class AttributeMapProfile : Profile
    {
        public AttributeMapProfile()
        {
            CreateMap<CreateAttributeDto, Attribute>();

            CreateMap<AttributeDto, Attribute>();

            CreateMap<Attribute, CreateAttributeDto>();

            CreateMap<Attribute, AttributeDto>();
        }
    }
}
