using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Softify.Tourism.Authorization
{
    public class TourismAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Services, L("Services"));
            context.CreatePermission(PermissionNames.Pages_Rooms, L("Rooms"));
            context.CreatePermission(PermissionNames.Pages_Attributes, L("Attributes"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, TourismConsts.LocalizationSourceName);
        }
    }
}
