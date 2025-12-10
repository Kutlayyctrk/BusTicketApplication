using BusTicketApplication.Core.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.DAL.Configuration
{
    public class BusConfiguration:BaseConfiguration<Bus>
    {
        public override void Configure(EntityTypeBuilder<Bus> builder)
        {
            base.Configure(builder);
        }
    }
}
