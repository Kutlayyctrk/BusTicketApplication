using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.Models.Entities
{
    public class Trip:BaseEntity
    {
        public DateTime TripDate { get; set; }
        public decimal Price { get; set; }

        public int BusId { get; set; }

        public int RouteId { get; set; }

        //Relational Properties

        public virtual Bus Bus { get; set; }
        public virtual Route Route { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
