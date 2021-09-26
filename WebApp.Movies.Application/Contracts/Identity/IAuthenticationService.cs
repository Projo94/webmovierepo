using System.Threading.Tasks;
using WebApp.Movies.Application.Models.Authentication;

namespace WebApp.Movies.Application.Contracts.Identity
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
    }
}
