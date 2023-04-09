using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Softify.Tourism.EntityFrameworkCore;
using Softify.Tourism.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Softify.Tourism.Web.Tests
{
    [DependsOn(
        typeof(TourismWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TourismWebTestModule : AbpModule
    {
        public TourismWebTestModule(TourismEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourismWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TourismWebMvcModule).Assembly);
        }
    }
}