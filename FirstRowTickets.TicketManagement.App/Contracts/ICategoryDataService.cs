using FirstRowTickets.TicketManagement.App.Services;
using FirstRowTickets.TicketManagement.App.Services.Base;
using FirstRowTickets.TicketManagement.App.ViewModels;

namespace FirstRowTickets.TicketManagement.App.Contracts
{
    public interface ICategoryDataService
    {
        Task<List<CategoryViewModel>> GetAllCategories();
        Task<List<CategoryEventsViewModel>> GetAllCategoriesWithEvents(bool includeHistory);
        Task<ApiResponse<CategoryDto>> CreateCategory(CategoryViewModel categoryViewModel);
    }
}
