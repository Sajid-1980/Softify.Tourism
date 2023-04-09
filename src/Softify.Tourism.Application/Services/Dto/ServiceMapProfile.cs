using System.Linq;
using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Project;

namespace Softify.Tourism.Services.Dto
{
    public class ServiceMapProfile : Profile
    {
        public ServiceMapProfile()
        {
            CreateMap<CreateServiceDto, Service>();

            CreateMap<ServiceDto, Service>();



            CreateMap<Service, CreateServiceDto>();
            CreateMap<Service, ServiceDto>();
        }
    }
}
