using FirstRowTickets.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRowTickets.TicketManagement.Persistence.Configurations
{
    public class EventConfiguration
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);


        }
    }
}
