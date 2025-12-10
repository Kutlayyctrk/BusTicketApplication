using BusTicketApplication.Core.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.DAL.Configuration
{
    public class TripConfiguration:BaseConfiguration<Trip>
    {
        public override void Configure(EntityTypeBuilder<Trip> builder)
        {

            builder.Property(x => x.Price).HasPrecision(18, 2);
            base.Configure(builder);
        }
    }
}
