using System;
using Microsoft.AspNetCore.Authorization;

namespace PolicyPoc
{
    public static class AuthorizationPolicyBuilderExtensions
    {
        public static AuthorizationPolicyBuilder RequireNotExpiredUser(this AuthorizationPolicyBuilder builder)
        {
            builder.Requirements.Add(new DenyExpiredAuthorizationRequirement());

            return builder;
        }
    }
}
