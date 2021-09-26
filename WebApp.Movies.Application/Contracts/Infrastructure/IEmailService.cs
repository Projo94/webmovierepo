using System.Threading.Tasks;
using WebApp.Movies.Application.Models.Mail;

namespace WebApp.Movies.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
