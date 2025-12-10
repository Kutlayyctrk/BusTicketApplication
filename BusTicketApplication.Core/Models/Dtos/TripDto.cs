using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.Models.Dtos
{
    public class TripDto:BaseDto
    {
        public DateTime TripDate { get; set; }
        public decimal Price { get; set; }

    }
}
