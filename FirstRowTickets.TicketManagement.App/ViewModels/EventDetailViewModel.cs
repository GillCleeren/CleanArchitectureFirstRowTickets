using System.ComponentModel.DataAnnotations;

namespace FirstRowTickets.TicketManagement.App.ViewModels
{
    public class EventDetailViewModel
    {
        public Guid EventId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="The name of the event should be 50 characters or less")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(0, int.MaxValue, ErrorMessage ="Price should be a positive value")]
        public int Price { get; set; }

        [StringLength(50, ErrorMessage = "The name of the event should be 50 characters or less")]
        public string? Artist { get; set; }

        public DateTime Date { get; set; }
        
        [StringLength(500, ErrorMessage = "The description can't be longer than 500 characters")] 
        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        public CategoryViewModel Category { get; set; } = default!;
    }
}
