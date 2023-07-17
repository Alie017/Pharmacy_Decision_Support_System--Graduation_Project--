using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace phadec.Controllers
{
    public abstract class phadecControllerBase: AbpController
    {
        protected phadecControllerBase()
        {
            LocalizationSourceName = phadecConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
