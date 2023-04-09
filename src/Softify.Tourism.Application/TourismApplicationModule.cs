using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Softify.Tourism.Authorization;

namespace Softify.Tourism
{
    [DependsOn(
        typeof(TourismCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TourismApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TourismAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TourismApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
