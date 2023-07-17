using Abp.Authorization;
using phadec.Authorization.Roles;
using phadec.Authorization.Users;

namespace phadec.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
