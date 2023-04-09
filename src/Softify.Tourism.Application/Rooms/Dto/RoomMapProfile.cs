using System.Linq;
using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Project;

namespace Softify.Tourism.Rooms.Dto
{
    public class RoomMapProfile : Profile
    {
        public RoomMapProfile()
        {
            CreateMap<CreateRoomDto, Room>();

            CreateMap<RoomDto, Room>();



            CreateMap<Room, CreateRoomDto>();
            CreateMap<Room, RoomDto>();
        }
    }
}
