using Abp.AutoMapper;
using Softify.Tourism.Attributes.Dto;
using Softify.Tourism.AttributesServices.Dto;
using Softify.Tourism.Rooms.Dto;
using Softify.Tourism.Services.Dto;
using Softify.Tourism.Web.Models.Common;

namespace Softify.Tourism.Web.Models.AttributesServices
{ 
    
    public class EditAttributeServiceModalViewModel
    {
        public AttributeServiceDto AttributeService { get; set; }
    }
}
