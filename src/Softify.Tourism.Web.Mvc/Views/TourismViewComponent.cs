using Abp.AspNetCore.Mvc.ViewComponents;

namespace Softify.Tourism.Web.Views
{
    public abstract class TourismViewComponent : AbpViewComponent
    {
        protected TourismViewComponent()
        {
            LocalizationSourceName = TourismConsts.LocalizationSourceName;
        }
    }
}
