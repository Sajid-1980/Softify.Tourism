using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Softify.Tourism.Controllers
{
    public abstract class TourismControllerBase: AbpController
    {
        protected TourismControllerBase()
        {
            LocalizationSourceName = TourismConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
