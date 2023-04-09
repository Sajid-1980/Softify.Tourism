using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Softify.Tourism.AttributesServices.Dto;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Project;

namespace Softify.Tourism.Services.Dto
{
    public class CreateServiceDto
    {
        public string Name { get; set; }
        public string ServiceType { get; set; }
        public string Parking { get; set; }
        public string Internet { get; set; }
        public string Kitchen { get; set; }
        public string LanguageSpoken { get; set; }
        public string LivingArea { get; set; }
        public string Address { get; set; }
        public string Laundry { get; set; }
        public string FoodAndDrink { get; set; }
        public string HouseKeeping { get; set; }
        public string Gym { get; set; }
        public string Pool { get; set; }
        public string Bar { get; set; }
        public string ATMService { get; set; }
        public string NewPapers { get; set; }
        public string Outdoor { get; set; }
        public string Activities { get; set; }
        public string Transport { get; set; }
        public string Accessibility { get; set; }
        public string General { get; set; }
        public string ReceptionServices { get; set; }
        public string Pets { get; set; }
        public string SafetyAndSecurity { get; set; }
        public string BusinessFacilities { get; set; }
        public string MediaAndTechnology { get; set; }
        public string Conveniences { get; set; }
        public string Policies { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string OpeningHours { get; set; }

        //Floor
        public string FloorName { get; set; }
        public string FloorCode { get; set; }
        public string TotalNoOfRooms { get; set; }
        public string Description { get; set; }

        //CAR SERVICE
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarType { get; set; }
        public string CarRate { get; set; }
        public string CarNo { get; set; }
        public string Driver { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }


        public List<AttributeServiceDto> Attributes { get; set; }


    }
}
