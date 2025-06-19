using System.Threading.Tasks;

namespace sandysukma_fdtest.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
