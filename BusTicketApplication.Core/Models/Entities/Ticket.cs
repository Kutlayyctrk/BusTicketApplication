using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.Models.Entities
{
    public class Ticket:BaseEntity
    {
        public int SeatNumber { get; set; } //Koltuk No

        public decimal Price { get; set; }
        public int PassengerId { get; set; }

        public int TripId { get; set; }

        //Relational Properties

        public virtual Passenger Passenger { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
