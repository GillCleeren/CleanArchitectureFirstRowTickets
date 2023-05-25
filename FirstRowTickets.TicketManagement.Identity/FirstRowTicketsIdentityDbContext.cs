using FirstRowTickets.TicketManagement.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstRowTickets.TicketManagement.Identity
{
    public class FirstRowTicketsIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public FirstRowTicketsIdentityDbContext()
        {

        }

        public FirstRowTicketsIdentityDbContext(DbContextOptions<FirstRowTicketsIdentityDbContext> options) : base(options)
        {
        }
    }
}
