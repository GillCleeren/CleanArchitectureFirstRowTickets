using FirstRowTickets.TicketManagement.App.ViewModels;

namespace FirstRowTickets.TicketManagement.App.Contracts
{
    public interface IOrderDataService
    {
        Task<PagedOrderForMonthViewModel> GetPagedOrderForMonth(DateTime date, int page, int size);
    }
}
