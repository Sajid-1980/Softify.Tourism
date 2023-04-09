using Abp.AutoMapper;
using Softify.Tourism.Attributes.Dto;
using Softify.Tourism.Rooms.Dto;
using Softify.Tourism.Services.Dto;
using Softify.Tourism.Web.Models.Common;

namespace Softify.Tourism.Web.Models.Attributes
{ 
    
    public class EditAttributeModalViewModel
    {
        public AttributeDto  Attributes { get; set; }
    }
}
