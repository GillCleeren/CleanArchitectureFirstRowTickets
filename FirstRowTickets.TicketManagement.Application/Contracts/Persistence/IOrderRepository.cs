using FirstRowTickets.TicketManagement.Domain.Entities;

namespace FirstRowTickets.TicketManagement.Application.Contracts.Persistence
{

    public interface IOrderRepository : IAsyncRepository<Order>
    {

    }
}
