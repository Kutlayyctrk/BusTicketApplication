using BusTicketApplication.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.UnitOfWorkInterfaces
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IBusRepository Buses { get; }
        ITripRepository Trips { get; }
        IPassengerRepository Passengers { get; }
        IRouteRepository Routes { get; }
        ITicketRepository Tickets { get; }


        Task CommitAsync();
        void Commit();
    }
}
