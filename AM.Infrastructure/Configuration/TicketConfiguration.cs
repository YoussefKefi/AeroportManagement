using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configuration
{
    internal class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new { t.FlightFK, t.PassengerFK });
            builder.HasOne(t => t.MyPassenger)
                .WithMany(f => f.ListTickets)
                .HasForeignKey(t => t.PassengerFK)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.MyFlight)
                .WithMany(p => p.ListTickets)
                .HasForeignKey(t => t.FlightFK)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
