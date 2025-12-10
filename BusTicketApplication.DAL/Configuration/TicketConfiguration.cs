using BusTicketApplication.Core.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.DAL.Configuration
{
    public class TicketConfiguration:BaseConfiguration<Ticket>
    {
        public override void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.Property(x => x.Price).HasPrecision(18, 2);

            base.Configure(builder);
        }
    }
}
