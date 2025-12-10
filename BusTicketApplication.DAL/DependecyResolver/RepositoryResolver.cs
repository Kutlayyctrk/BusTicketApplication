using BusTicketApplication.Core.RepositoryInterfaces;
using BusTicketApplication.Core.UnitOfWorkInterfaces;
using BusTicketApplication.DAL.RepositoryConcretes;
using BusTicketBooking.Data.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.DAL.DependecyResolver
{
    public static class RepositoryResolver
    {
        public static void AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseConcretes<>));

            services.AddScoped<IBusRepository, BusConcretes>();
            services.AddScoped<ITripRepository, TripConcretes>();
            services.AddScoped<IPassengerRepository, PassengerConcretes>();
            services.AddScoped<IRouteRepository, RouteConcretes>();
            services.AddScoped<ITicketRepository, TicketConcretes>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
