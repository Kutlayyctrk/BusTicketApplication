using BusTicketApplication.Core.Models.Entities;
using BusTicketApplication.Core.RepositoryInterfaces;
using BusTicketApplication.DAL.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.DAL.RepositoryConcretes
{
    public class TripConcretes(MyContext myContext):BaseConcretes<Trip>(myContext), ITripRepository
    {
    }
}
