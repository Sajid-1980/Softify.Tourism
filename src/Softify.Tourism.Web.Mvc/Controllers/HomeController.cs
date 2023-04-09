using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Softify.Tourism.Controllers;

namespace Softify.Tourism.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TourismControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
