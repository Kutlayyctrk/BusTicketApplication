using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.Models.Entities
{
    public class Bus:BaseEntity
    {
        public string PlateNumber { get; set; }

        public int Capacity { get; set; }

        public string Brand { get; set; }

        public bool IsActive { get; set; }

        //Relational Properties

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
