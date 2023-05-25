﻿using FirstRowTickets.TicketManagement.App.Contracts;
using FirstRowTickets.TicketManagement.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace FirstRowTickets.TicketManagement.App.Pages
{
    public partial class Login
    {
        public LoginViewModel LoginViewModel { get; set; }
        
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public string Message { get; set; }

        [Inject]
        private IAuthenticationService AuthenticationService { get; set; }

        public Login()
        {
            
        }

        protected override void OnInitialized()
        {
            LoginViewModel = new LoginViewModel();
        }

        protected async void HandleValidSubmit()
        {
            if (await AuthenticationService.Authenticate(LoginViewModel.Email, LoginViewModel.Password))
            {
                NavigationManager.NavigateTo("home");
            }
            Message = "Username/password combination unknown";
        }
    }
}
