using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Project;

namespace Softify.Tourism.Rooms.Dto
{
    public class CreateRoomDto
    {
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public string RoomSize { get; set; }
        public int RoomNo { get; set; }
        public int NoOfBed { get; set; }
        public int NoOfExtraBed { get; set; }
        public string Address { get; set; }
        public string RoomDescription { get; set; }
        public int NoOfChild { get; set; }
        public int NoOfAdult { get; set; }
        public int TotalAdultAllowed { get; set; }
        public int TotalChildAllowed { get; set; }
        public string RoomFacility { get; set; }
        public int ExtraAdultAllowed { get; set; }
        public int ExtraChildrenAllowed { get; set; }
        public decimal RoomRate { get; set; }
        public ICollection<Service> Services { get; set; }

    }
}
