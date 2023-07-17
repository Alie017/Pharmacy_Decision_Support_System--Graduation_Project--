using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using phadec.Authorization;

namespace phadec
{
    [DependsOn(
        typeof(phadecCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class phadecApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<phadecAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(phadecApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
