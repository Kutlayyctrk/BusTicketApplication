using BusTicketApplication.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.Models.Dtos
{
    public class PassengerDto:BaseDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string IdentityNumber { get; set; }

        public Gender Gender { get; set; }
    }
}
