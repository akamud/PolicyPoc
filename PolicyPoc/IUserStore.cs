using System.Security.Claims;
using System.Threading.Tasks;

namespace PolicyPoc
{
    public interface IUserStore
    {
        bool ValidateSecurityStampAsync(ClaimsPrincipal user);
    }
}