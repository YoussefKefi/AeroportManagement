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
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            ////Configuration many to many
            //builder.HasMany(f => f.ListPassengers)
            //    .WithMany(p => p.Flights)
            //    .UsingEntity(j => j.ToTable("ReservationFlightPassenger"));
            ////Configuration one to many
            //builder.HasOne(f => f.MyPlane)
            //    .WithMany(p => p.ListFlights)
            //    .HasForeignKey(f => f.PlaneId)
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
