using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using phadec.EntityFrameworkCore;
using phadec.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace phadec.Web.Tests
{
    [DependsOn(
        typeof(phadecWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class phadecWebTestModule : AbpModule
    {
        public phadecWebTestModule(phadecEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(phadecWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(phadecWebMvcModule).Assembly);
        }
    }
}