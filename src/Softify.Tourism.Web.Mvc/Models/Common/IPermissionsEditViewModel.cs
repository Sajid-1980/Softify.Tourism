using System.Collections.Generic;
using Softify.Tourism.Roles.Dto;

namespace Softify.Tourism.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}