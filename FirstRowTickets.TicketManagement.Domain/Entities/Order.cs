using FirstRowTickets.TicketManagement.Domain.Common;

namespace FirstRowTickets.TicketManagement.Domain.Entities
{
    public class Order: AuditableEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
    }
}
