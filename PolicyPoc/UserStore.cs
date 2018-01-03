using System;
using System.Security.Claims;

namespace PolicyPoc
{
    public class UserStore : IUserStore
    {
        private static bool _valido;

        public bool ValidateSecurityStampAsync(ClaimsPrincipal user)
        {
            return _valido = !_valido;
        }
    }
}
