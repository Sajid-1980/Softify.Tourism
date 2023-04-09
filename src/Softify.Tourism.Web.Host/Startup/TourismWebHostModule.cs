using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Softify.Tourism.Configuration;

namespace Softify.Tourism.Web.Host.Startup
{
    [DependsOn(
       typeof(TourismWebCoreModule))]
    public class TourismWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TourismWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourismWebHostModule).GetAssembly());
        }
    }
}
