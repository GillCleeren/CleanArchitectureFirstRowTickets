namespace FirstRowTickets.TicketManagement.App.Services.Base
{
    public class ApiResponse<T>
    {
        public string Message { get; set; } = string.Empty;
        public string? ValidationErrors { get; set; }
        public bool Success { get; set; }
        public T? Data { get; set; }
    }
}
