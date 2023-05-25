using FirstRowTickets.TicketManagement.App.Contracts;
using FirstRowTickets.TicketManagement.App.Services;
using FirstRowTickets.TicketManagement.App.Services.Base;
using FirstRowTickets.TicketManagement.App.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace FirstRowTickets.TicketManagement.App.Pages
{
    public partial class AddCategory
    {
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public CategoryViewModel CategoryViewModel { get; set; }
        public string Message { get; set; }

        protected override void OnInitialized()
        {
            CategoryViewModel = new CategoryViewModel();
        }

        protected async Task HandleValidSubmit()
        {
            var response = await CategoryDataService.CreateCategory(CategoryViewModel);
            HandleResponse(response);
        }

        private void HandleResponse(ApiResponse<CategoryDto> response)
        {
            if (response.Success)
            {
                Message = "Category added";
            }
            else
            {
                Message = response.Message;
                if (!string.IsNullOrEmpty(response.ValidationErrors))
                    Message += response.ValidationErrors;
            }
        }
    }
}
