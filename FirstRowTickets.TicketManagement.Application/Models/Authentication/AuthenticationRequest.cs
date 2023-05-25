namespace FirstRowTickets.TicketManagement.Application.Models.Authentication
{
    public class AuthenticationRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
