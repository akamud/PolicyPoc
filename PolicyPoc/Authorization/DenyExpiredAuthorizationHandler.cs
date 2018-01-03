using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PolicyPoc
{
    public class DenyExpiredAuthorizationHandler : AuthorizationHandler<DenyExpiredAuthorizationRequirement>
    {
        // TODO: Utilizar a classe que vai te retornar o User do Identity, talvez nem precise disso
        private readonly IUserStore _userStore;

        public DenyExpiredAuthorizationHandler(IUserStore userStore)
        {
            _userStore = userStore;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, DenyExpiredAuthorizationRequirement requirement)
        {
            if (_userStore.ValidateSecurityStampAsync(context.User))
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
