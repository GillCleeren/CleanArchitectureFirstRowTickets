using FirstRowTickets.TicketManagement.Application.Models.Mail;

namespace FirstRowTickets.TicketManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
