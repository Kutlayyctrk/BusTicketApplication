using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.Models.Entities
{
    public class Route:BaseEntity
    {
        public string FromCity { get; set; }

        public string ToCity { get; set; }

        public int Distance { get; set; }

        //Relational Properties

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
