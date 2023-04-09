using Abp.Authorization;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Authorization.Users;

namespace Softify.Tourism.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
