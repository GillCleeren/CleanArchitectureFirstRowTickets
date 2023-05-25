using FirstRowTickets.TicketManagement.Domain.Entities;

namespace FirstRowTickets.TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);

    }
}
