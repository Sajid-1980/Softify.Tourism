using Abp.AutoMapper;
using Softify.Tourism.Roles.Dto;
using Softify.Tourism.Web.Models.Common;

namespace Softify.Tourism.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
