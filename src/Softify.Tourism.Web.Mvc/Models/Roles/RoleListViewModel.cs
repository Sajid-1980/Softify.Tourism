using System.Collections.Generic;
using Softify.Tourism.Roles.Dto;

namespace Softify.Tourism.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
