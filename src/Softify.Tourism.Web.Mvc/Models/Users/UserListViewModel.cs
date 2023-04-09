using System.Collections.Generic;
using Softify.Tourism.Roles.Dto;

namespace Softify.Tourism.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
