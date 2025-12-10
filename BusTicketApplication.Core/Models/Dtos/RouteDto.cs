using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.Models.Dtos
{
    public class RouteDto:BaseDto
    {
        public string FromCity { get; set; }

        public string ToCity { get; set; }

        public int Distance { get; set; }
    }
}
