using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Softify.Tourism.Web.Views
{
    public abstract class TourismRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TourismRazorPage()
        {
            LocalizationSourceName = TourismConsts.LocalizationSourceName;
        }
    }
}
