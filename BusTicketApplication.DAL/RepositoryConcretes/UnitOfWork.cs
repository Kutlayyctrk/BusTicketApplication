using BusTicketApplication.Core.RepositoryInterfaces;
using BusTicketApplication.Core.UnitOfWorkInterfaces;
using BusTicketApplication.DAL.ContextClasses;
using BusTicketApplication.DAL.RepositoryConcretes;
using System;

namespace BusTicketBooking.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _context;

      
        public IBusRepository Buses { get; private set; }
        public ITripRepository Trips { get; private set; }
        public IPassengerRepository Passengers { get; private set; }
        public IRouteRepository Routes { get; private set; }
        public ITicketRepository Tickets { get; private set; }

        public UnitOfWork(MyContext context)
        {
            _context = context;

      
            Buses = new BusConcretes(_context);
            Trips = new TripConcretes(_context);
            Passengers = new PassengerConcretes(_context);
            Routes = new RouteConcretes(_context);
            Tickets = new TicketConcretes(_context);
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}